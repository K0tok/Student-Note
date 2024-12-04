using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Data.Sqlite;
using System.Security.Policy;

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

        public static bool AddUserInGroup(int userId, string groupCode, Form thisForm)
        {
            try
            {
                // Строка подключения к базе данных SQLite
                string connectionString = "Data Source=Student Note.db";


                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // SQL-запрос
                            string query = @"
                                WITH UserCheck AS (
                                    SELECT 1 AS user_exists
                                    FROM Users
                                    WHERE id = @userId
                                ),
                                GroupCheck AS (
                                    SELECT id AS group_id
                                    FROM Groups
                                    WHERE code = @groupCode
                                ),
                                MembershipCheck AS (
                                    SELECT 1 AS membership_exists
                                    FROM users_in_groups
                                    WHERE user_id = @userId AND group_id = (SELECT group_id FROM GroupCheck)
                                )
                                INSERT INTO users_in_groups (user_id, group_id)
                                SELECT @userId, group_id
                                FROM GroupCheck
                                WHERE EXISTS (SELECT 1 FROM UserCheck)
                                  AND EXISTS (SELECT 1 FROM GroupCheck)
                                  AND NOT EXISTS (SELECT 1 FROM MembershipCheck);
                            ";

                            using (var command = new SqliteCommand(query, connection, transaction)) // Привязка транзакции
                            {
                                // Добавляем параметры
                                command.Parameters.AddWithValue("@userId", userId);
                                command.Parameters.AddWithValue("@groupCode", groupCode);

                                // Выполнение команды
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected < 1)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Вы уже есть в этой группе");
                                    return false;
                                }
                            }

                            // Фиксация транзакции
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            // Откат транзакции в случае ошибки
                            transaction.Rollback();
                            MessageBox.Show("Ошибка: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Возникла ошибка: " + ex.Message);
            }
            return false;
        }
    }
}
