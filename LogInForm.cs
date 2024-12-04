using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Note;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace Student_Note
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Скрытие всех wrong labels
        /// </summary>
        private void labels_invisible()
        {
            WrongPasswordLabel.Visible = false;
            WrongDataLabel.Visible = false;
            WrongLoginLabel.Visible = false;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            labels_invisible();
            if (Program.isLog)
            {
                Program.ReplaceForm(Program.MainHomeworkForm, this);
            }
        }
        /// <summary>
        /// Проверяет существование пользователя и получает его данные
        /// </summary>
        /// <param name="emailOrPhoneNumber">Почта или номер телефона</param>
        /// <param name="password">Пароль</param>
        /// <returns>true or false</returns>
        static bool AuthenticateUser(string emailOrPhoneNumber, string password)
        {
            // Путь к базе данных
            string connectionString = $"Data Source={Program.fullPath}";

            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Добавление параметров для защиты от SQL-инъекций
                cmd.Parameters.AddWithValue("@EmailOrPhoneNumber", emailOrPhoneNumber);
                cmd.Parameters.AddWithValue("@Password", password);

                // Проверка на наличие пользователя и получение его данных
                cmd.CommandText = @"SELECT id, last_name, first_name, second_name, sex, birthdate, reg_date, email, phone_number, member_type 
                    FROM Users WHERE (email = @EmailOrPhoneNumber OR phone_number = @EmailOrPhoneNumber) AND password = @Password";


                // Выполнение запроса
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Program.isLog = true;

                        Program.userData = new UserData(
                            reader["id"].ToString(),
                            reader["last_name"].ToString(),
                            reader["first_name"].ToString(),
                            reader["second_name"].ToString(),
                            reader["sex"].ToString(),
                            reader["birthdate"].ToString(),
                            reader["reg_date"].ToString(),
                            reader["email"].ToString(),
                            reader["phone_number"].ToString(),
                            reader["member_type"].ToString()
                            );
                    }
                }
                if (Program.isLog)
                {
                    return true;
                }
                else { return false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
                return false;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string emailOrPhoneNumber = /*LoginTextBox.Text*/"+79892674364";
            string password = /*PasswordTextBox.Text*/"19643826_kurwaBobr111";


            labels_invisible();

            bool hasErrors = false;

            if (!Regex.IsMatch(emailOrPhoneNumber, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") && !Regex.IsMatch(emailOrPhoneNumber, @"^\+?[0-9]\d{9,14}$"))
            {
                WrongLoginLabel.Visible = true;
                hasErrors = true;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!_ %*?&])[A-Za-z\d@$!%_ *?&]{8,}$"))
            {
                WrongPasswordLabel.Visible = true;
                hasErrors = true;
            }

            // Если есть ошибки, прекратить выполнение дальнейшей логики
            if (hasErrors)
            {
                return;
            }

            // Проверка в базе данных
            Program.isLog = AuthenticateUser(emailOrPhoneNumber, password);

            if (Program.isLog)
            {
                Program.ReplaceForm(Program.MainHomeworkForm, this);
            }
            else
            {
                WrongDataLabel.Visible = true;
            }
        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(Program.SignUpForm, this);
        }
    }
}