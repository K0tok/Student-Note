using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.JavaScript;

namespace Student_Note
{
    public partial class MakeHomework : Form
    {
        private string _lessonNumber;
        private string _subject;
        private DateTime _lessonDate;
        public MakeHomework()
        {
            InitializeComponent();
            //MainHomeworkForm.SetHomeworkData(string lessonNumber, string subject, DateTime lessonDate);
            SelectNumberLesson.DataSource = new List<string>{"1", "2", "3", "4", "5", "1-B", "2-B"};
            SelectLesson.DataSource = new List<string> { "Математика", "Не математика"};
            TextHomework.Text = "StartHomeWork";
            SelectDate.Value = new DateTime(2001, 10, 20);
        }
        // Метод для установки данных домашнего задания
        public void SetHomeworkData(string lessonNumber, string subject, DateTime lessonDate)
        {
            _lessonNumber = lessonNumber;
            _subject = subject;
            _lessonDate = lessonDate;

            MessageBox.Show(_lessonNumber + _subject + _lessonDate.ToString());
            // Отображаем данные на форме
            //SelectNumberLesson.Text = _lessonNumber;
            //SelectLesson.Text = _subject;
            //homeworkTextBox.Text = _homework;
        }
        private void SaveHomework_Click(object sender, EventArgs e)
        {
            string lesson = SelectLesson.Text;
            DateTime date = SelectDate.Value;
            string lesson_number = SelectNumberLesson.Text;
            string homework_text = TextHomework.Text;
            string file = FileLink.Text;
            if (Program.userData == null)
            {
                Program.ReplaceForm(Program.LogInForm, this);  // Переход на форму логина, если пользователь не авторизован
                return;
            }

            if (Program.userData.selectGroup == null)
            {
                Program.ReplaceForm(Program.LogInForm, this);  // Переход на форму логина, если пользователь не авторизован
                return;
            }

            try
            {
                // Укажите строку подключения к вашей базе данных SQLite
                string connectionString = $"Data Source={Program.fullPath}";

                // Создаем подключение
                using SqliteConnection connection = new SqliteConnection(connectionString);
                // Открываем соединение
                connection.Open();

                // Создаем команду
                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection; // Указываем подключение для команды
                cmd.CommandType = CommandType.Text;

                // Добавляем параметры
                cmd.Parameters.AddWithValue("@Lesson", lesson);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Lesson_number", lesson_number);
                cmd.Parameters.AddWithValue("@Homework_text", homework_text);
                cmd.Parameters.AddWithValue("@File", file);
                cmd.Parameters.AddWithValue("@Group_id", Program.userData.selectGroup.id);

                // SQL-запрос
                cmd.CommandText = "INSERT INTO Schedules (lesson, date, lesson_number, homework_text, file, group_id) " +
                    "VALUES (@Lesson, @Date, @Lesson_number, @Homework_text, @File, @Group_id)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Не удалось добавить домашнее задание. Возникла ошибка: " + ex.Message);
            }
        }
    }
}
