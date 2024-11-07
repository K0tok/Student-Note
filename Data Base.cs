using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Student_Note
{
    public class Data_Base
    {
        // Метод для загрузки и вывода расписания
        public async Task GetScheduleAsync()
        {
            string url = "https://nti.urfu.ru/schedule/schedule_students.json?17";
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();

                // Десериализуем JSON в список объектов ScheduleItem
                var scheduleData = JsonConvert.DeserializeObject<ScheduleData>(jsonString);

                MessageBox.Show(jsonString.Substring(0, 100));


                if (scheduleData != null && scheduleData.Groups != null)
                {
                    foreach (var item in scheduleData.Groups)
                    {
                        foreach (var item1 in item.Days)
                        {
                            foreach (var item2 in item1.Lessons)
                            {
                                foreach (var item3 in item2.Couples)
                                {
                                    MessageBox.Show($"{item3.a}{item3.n}{item3.p}" );
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось десерализировать" + scheduleData.Groups);
                }


                //MessageBox.Show(scheduleData.Schedule.ToString());
                // Выводим расписание
                //if (scheduleData != null && scheduleData.Schedule != null)
                //{
                //    foreach (var item in scheduleData.Schedule)
                //    {
                //        MessageBox.Show($"Дата: {item.Date}, Время: {item.Time}, Предмет: {item.Subject}, Аудитория: {item.Room}");
                //    }
                //}
                //MesszageBox.Show($"Process try was be finish");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
