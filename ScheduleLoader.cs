using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Student_Note
{
    public class ScheduleLoader
    {
        // Хранение десериализованного расписания
        public Schedule CurrentSchedule { get; private set; }

        // Метод для загрузки и вывода расписания
        public async Task GetScheduleAsync()
        {
            try
            {
                // Загружаем JSON
                await GetJson();

                // Десериализация расписания
                CurrentSchedule = Deserialize(json);

                // Проверяем, есть ли группы
                if (CurrentSchedule != null && CurrentSchedule.Groups != null && CurrentSchedule.Groups.Count > 0)
                {
                    foreach (var group in CurrentSchedule.Groups)
                    {
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
                            if (day.Value == null) continue;

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
                                if (period.Value == null || period.Value.Count == 0) continue;

                                foreach (var lesson in period.Value)
                                {
                                    if (string.IsNullOrWhiteSpace(lesson.Name)) continue;
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

        // Метод для получения JSON
        static public string json = "{}";

        static public async Task GetJson()
        {
            string url = "https://nti.urfu.ru/api/schedule/schedule_nti_1";
            HttpClient client = new HttpClient();

            try
            {
                json = await client.GetStringAsync(url);
                MessageBox.Show("Полученный JSON загружен успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить JSON: {ex.Message}");
                json = "{}";
            }
        }

        // Метод для десериализации
        public static Schedule Deserialize(string json)
        {
            try
            {
                var schedule = new Schedule { Groups = new Dictionary<string, GroupSchedule>() };
                var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
                foreach (var property in jsonObject.Properties())
                {
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
    }
}
