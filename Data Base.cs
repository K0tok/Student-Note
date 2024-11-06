using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Student_Note
{ 
    // Класс для работы с расписанием
    public class Data_Base
    {
        private readonly HttpClient _httpClient = new HttpClient();

        // Метод для загрузки и вывода расписания
        public async Task PrintScheduleAsync()
        {
            string url = "https://nti.urfu.ru/schedule/schedule_students.json?17";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();
                int i = 0;
                foreach (var item in jsonString)
                {
                    MessageBox.Show(jsonString.Substring(i, i+100));
                    i += 100;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
