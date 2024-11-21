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

namespace Student_Note
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            if (Program.isLog)
            {
                Program.ReplaceForm(Program.MainForm, this);
                WrongDataLabel.Visible = false;
            }
        }

        static bool AuthenticateUser(string username, string password)
        {
            // Путь к базе данных
            string connectionString = "Data Source=your_database_path.db";

            // SQL-запрос для проверки пользователя
            string query = "SELECT COUNT(1) FROM Users WHERE username = @Username AND password = @Password";

            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        // Добавление параметров для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Если пароль хэширован, передайте хэш

                        // Выполнение запроса
                        int userExists = Convert.ToInt32(command.ExecuteScalar());

                        // Если пользователь найден (COUNT > 0), вернуть true
                        return userExists > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подключения к базе данных: {ex.Message}");
                return false;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string emailOrPhoneNumber = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            // Проверка в базе данных
            bool isAuthenticated = AuthenticateUser(emailOrPhoneNumber, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Вход выполнен успешно!");
            }
            else
            {
                WrongDataLabel.Visible = true;
            }

            if (!Regex.IsMatch(emailOrPhoneNumber, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") && !Regex.IsMatch(emailOrPhoneNumber, @"^\+?[0-9]\d{9,14}$"))
            {
                MessageBox.Show("Неправильный формат номера телефона или почта");
                //return;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!_ %*?&])[A-Za-z\d@$!%_ *?&]{8,}$")) {
                MessageBox.Show("Неверный формат пароля");
                //return;
            }
           
            //...
            Server.Entry(password, emailOrPhoneNumber);
            //..

            if (Program.isLog) 
                Program.ReplaceForm(new MainForm(), this);
        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(new SignUpForm(), this);
        }
    }
}