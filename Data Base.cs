using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Note
{
    public class Data_Base
    {
        // Метод для загрузки и вывода расписания
        public async Task PrintScheduleAsync()
        {
            string url = "https://nti.urfu.ru/schedule/schedule_students.json?17";
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();

                // Десериализуем JSON в список объектов ScheduleItem
                var scheduleData = JsonSerializer.Deserialize<ScheduleData>(jsonString);

                //MessageBox.Show(scheduleData.Schedule.ToString());
                // Выводим расписание
                if (scheduleData != null && scheduleData.Schedule != null)
                {
                    foreach (var item in scheduleData.Schedule)
                    {
                        MessageBox.Show($"Дата: {item.Date}, Время: {item.Time}, Предмет: {item.Subject}, Аудитория: {item.Room}");
                    }
                }
                //MessageBox.Show($"Process try was be finish");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
