using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Student_Note
{
    public class Server
    {
        // Метод для загрузки и вывода расписания
        public async Task GetScheduleAsync()
        {
            try
            {
                // Загружаем JSON
                await GetJson();

                // Десериализация расписания
                var schedule = Deserialize(json);

                // Проверяем, есть ли группы
                if (schedule != null && schedule.Groups != null && schedule.Groups.Count > 0)
                {
                    //MessageBox.Show("Группы найдены! Вывод расписания:");

                    // Обрабатываем каждую группу
                    foreach (var group in schedule.Groups)
                    {
                        MessageBox.Show($"\nГруппа: {group.Key}");

                        // Проходим по дням недели
                        foreach (var day in new Dictionary<string, DaySchedule>
                            {
                                {"Понедельник", group.Value.Monday},
                                {"Вторник", group.Value.Tuesday},
                                {"Среда", group.Value.Wednesday},
                                {"Четверг", group.Value.Thursday},
                                {"Пятница", group.Value.Friday},
                                {"Суббота", group.Value.Saturday}
                            })
                        {
                            MessageBox.Show($"  {day.Key}:");
                            if (day.Value == null)
                            {
                                //MessageBox.Show("    Данных о расписании нет.");
                                continue;
                            }

                            // Обрабатываем каждый период
                            foreach (var period in new Dictionary<string, List<Lesson>>
                                {
                                    {"I", day.Value.I},
                                    {"II", day.Value.II},
                                    {"III", day.Value.III},
                                    {"IV", day.Value.IV},
                                    {"V", day.Value.V},
                                    {"I - В", day.Value.I_V},
                                    {"II - В", day.Value.II_V}
                                })
                            {
                                if (period.Value == null || period.Value.Count == 0)
                                {
                                    //MessageBox.Show($"    Пара: {period.Key} - данных нет.");
                                    continue;
                                }

                                MessageBox.Show($"    {period.Key}:");
                                foreach (var lesson in period.Value)
                                {
                                    if (string.IsNullOrWhiteSpace(lesson.Name))
                                    {
                                        //MessageBox.Show("      Ошибка: название предмета не указано!");
                                        continue;
                                    }

                                    MessageBox.Show($"      Предмет: {lesson.Name}, Аудитория: {lesson.Auditorium}, Преподаватель: {lesson.Professor}");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Группы не найдены или данные отсутствуют.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        public static string json = "{}";

        public static async Task GetJson()
        {
            // Чтение и десериализация JSON из URL
            string url = "https://nti.urfu.ru/schedule/schedule_students.json";
            HttpClient client = new HttpClient();

            try
            {
                json = await client.GetStringAsync(url);
                MessageBox.Show("Полученный JSON загружен успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить JSON: {ex.Message}");
                json = "{}"; // Устанавливаем пустой JSON, чтобы избежать дальнейших ошибок
            }
        }

        public static Schedule? Deserialize(string json)
        {
            try
            {
                // Проверяем, что входной JSON не пуст
                if (string.IsNullOrWhiteSpace(json))
                {
                    MessageBox.Show("Передан пустой JSON.");
                    return null;
                }

                // Используем JObject для обработки динамических данных
                var schedule = new Schedule { Groups = new Dictionary<string, GroupSchedule>() };

                // Десериализуем JSON в JObject
                var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
                if (jsonObject == null)
                {
                    MessageBox.Show("Десериализация JSON вернула null.");
                    return null;
                }

                foreach (var property in jsonObject.Properties())
                {
                    // Проверяем, что свойство не null перед обработкой
                    if (property.Value == null)
                    {
                        MessageBox.Show($"Группа {property.Name} содержит null. Пропускаем...");
                        continue;
                    }

                    try
                    {
                        // Предполагается, что каждая группа соответствует структуре GroupSchedule
                        var groupSchedule = property.Value.ToObject<GroupSchedule>();
                        if (groupSchedule != null)
                        {
                            schedule.Groups[property.Name] = groupSchedule;
                        }
                        else
                        {
                            MessageBox.Show($"Не удалось преобразовать данные группы: {property.Name}");
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Ошибка при обработке группы: {property.Name}. Пропускаем...");
                    }
                }

                return schedule;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка десериализации JSON: {ex.Message}");
                return null;
            }
        }

        public static bool Entry(string password, string emailOrPhohneNumber)
        {
            string query = "SELECT * FROM Users AS U \r\nINNER JOIN Passwords As P ON U.id = P.id \r\nWHERE (U.email = \"offernomail@gmail.com\" or phone_number = \"offernomail@gmail.com\") AND P.password = \"19643826kurwabobr111\"";

            Data_Base.DBConnectionOpen();
            if (Data_Base.QuerySendGet(query, out var result, emailOrPhohneNumber, emailOrPhohneNumber, password).Status == 200)
            {
                foreach (var row in result)
                {
                    //MessageBox.Show($"Name: {row["Name"]}, Age: {row["Age"]}");
                    MessageBox.Show(row["Email"].ToString());
                    Program.isLog = true;
                }
            }
            else {
                MessageBox.Show(".Status != 200");
            }
            

            Data_Base.DBConnectionClose();


            return true; 
        }
    }
}
