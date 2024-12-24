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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Note
{
    public partial class MakeHomework : Form
    {
        public MakeHomework(Homework homework, MainHomeworkForm mainHomeworkForm)
        {
            InitializeComponent();

            textSubject.Text = homework.Lesson;
            SelectDate.Value = DateTime.Parse(homework.Date);
            TextHomework.Text = homework.HomeworkText;
            textLessonNumber.Text = homework.LessonNumber.ToString();
            FileLink.Text = homework.File;
            id = homework.Id;
            this.mainHomeworkForm = mainHomeworkForm;
        }

        public int id;
        MainHomeworkForm mainHomeworkForm;
        /// <summary>
        /// Нажатие на кнопку сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveHomework_Click(object sender, EventArgs e)
        {
            string lesson = textSubject.Text;
            string date = SelectDate.Value.Date.ToString("yyyy-MM-dd");
            int lesson_number = int.Parse(textLessonNumber.Text);
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


            if (IsScheduleExist(date, lesson_number))
            {
                if (UpdateSchedule(id, lesson, date, lesson_number, homework_text, file, Program.userData.selectGroup.id))
                {
                    mainHomeworkForm.WeekComboBox_SelectedIndexChanged(
                        new object(),
                        new EventArgs());
                    Close();
                }
                else
                    return;
            }
            else
            {
                if (AddHomeWork(lesson, date, lesson_number, homework_text, file, Program.userData.selectGroup.id))
                {
                    mainHomeworkForm.WeekComboBox_SelectedIndexChanged(
                        new object(),
                        new EventArgs());
                    Close();
                }
                else 
                { 
                    MessageBox.Show("Возникла ошибка при добавлении"); 
                }
            }
        }
        /// <summary>
        /// Обновление домашнего задания 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lesson"></param>
        /// <param name="date"></param>
        /// <param name="lessonNumber"></param>
        /// <param name="homeworkText"></param>
        /// <param name="file"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public bool UpdateSchedule(int id, string lesson, string date, int lessonNumber, string homeworkText, string file, int groupId)
        {
            // Укажите строку подключения к вашей базе данных SQLite
            string connectionString = $"Data Source={Program.fullPath}";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Schedules
                    SET lesson = @lesson,
                        date = @date,
                        lesson_number = @lessonNumber,
                        homework_text = @homeworkText,
                        file = @file,
                        group_id = @groupId
                    WHERE id = @id;
                ";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@lesson", lesson);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@lessonNumber", lessonNumber);
                    command.Parameters.AddWithValue("@homeworkText", homeworkText);
                    command.Parameters.AddWithValue("@file", file);
                    command.Parameters.AddWithValue("@groupId", groupId);

                    int countRows = command.ExecuteNonQuery();

                    // Проверка на ответ 
                    if (countRows == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Добавление домашнего задания
        /// </summary>
        /// <param name="lesson"></param>
        /// <param name="date"></param>
        /// <param name="lesson_number"></param>
        /// <param name="homework_text"></param>
        /// <param name="file"></param>
        /// <param name="group_id"></param>
        /// <returns></returns>
        public bool AddHomeWork(string lesson, string date, int lesson_number, string homework_text, string file, int group_id)
        {
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

                if (lesson_number == null) return false;

                // Добавляем параметры
                cmd.Parameters.AddWithValue("@Lesson", lesson);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Lesson_number", lesson_number);
                cmd.Parameters.AddWithValue("@Homework_text", homework_text);
                cmd.Parameters.AddWithValue("@File", file);
                cmd.Parameters.AddWithValue("@Group_id", group_id);

                // SQL-запрос
                cmd.CommandText = "INSERT INTO Schedules (lesson, date, lesson_number, homework_text, file, group_id) " +
                    "VALUES (@Lesson, @Date, @Lesson_number, @Homework_text, @File, @Group_id)";

                int countRows = cmd.ExecuteNonQuery();

                // Проверка на ответ 
                if (countRows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Не удалось добавить домашнее задание. Возникла ошибка: " + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Проверка на существование записи об расписании на это место 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="lessonNumber"></param>
        /// <returns></returns>
        public bool IsScheduleExist(string date, int lessonNumber)
        {
            string connectionString = $"Data Source={Program.fullPath}";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            string query = @"
                    SELECT EXISTS (
                        SELECT 1, id
                        FROM Schedules
                        WHERE date = @date AND lesson_number = @lessonNumber
                    );
                ";
            using var command = new SqliteCommand(query, connection);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@lessonNumber", lessonNumber);

            return Convert.ToBoolean(command.ExecuteScalar());
        }
        private void CancelHomework_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}