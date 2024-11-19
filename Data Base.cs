using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Data.Sqlite;
using System.Data;

namespace Student_Note
{
    public class Data_Base
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

        static public string json = "{}";

        static public async Task GetJson()
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

        public static Schedule Deserialize(string json)
        {
            try
            {
                // Используем JObject для обработки динамических данных
                var schedule = new Schedule { Groups = new Dictionary<string, GroupSchedule>() };

                var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
                foreach (var property in jsonObject.Properties())
                {
                    // Предполагается, что каждая группа соответствует структуре GroupSchedule
                    try
                    {
                        var groupSchedule = property.Value.ToObject<GroupSchedule>();
                        schedule.Groups[property.Name] = groupSchedule;
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

        public static SqliteConnection sqliteConnect;

        public void DBConnection()
        {
            // Путь к БД
            string connectionString = "DataSource=Student Note.db";

            // Создание подключения
            sqliteConnect = new SqliteConnection(connectionString);

            try
            {
                // Открытие подключения
                sqliteConnect.Open();
                MessageBox.Show("Подключение установлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }
    }
}
