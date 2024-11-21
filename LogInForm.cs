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

        private void labels_invisible()
        {
            WrongPasswordLabel.Visible = false;
            WrongDataLabel.Visible = false;
            WrongLoginLabel.Visible = false;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            if (Program.isLog)
            {
                Program.ReplaceForm(Program.MainForm, this);
                labels_invisible();
            }
        }

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

                // Проверка на наличие пользователя
                cmd.CommandText = "SELECT COUNT(1) FROM Users WHERE (email = @EmailOrPhoneNumber OR phone_number = @EmailOrPhoneNumber) AND password = @Password";

                // Выполнение запроса
                int userExists = Convert.ToInt32(cmd.ExecuteScalar());

                // Если пользователь найден (COUNT > 0), вернуть true
                return userExists > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
                return false;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string emailOrPhoneNumber = LoginTextBox.Text;
            string password = PasswordTextBox.Text;


            labels_invisible();

            bool hasErrors = false;

            if (!Regex.IsMatch(emailOrPhoneNumber, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") && !Regex.IsMatch(emailOrPhoneNumber, @"^\+?[0-9]\d{9,14}$"))
            {
                WrongLoginLabel.Visible = true;
                hasErrors = true;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!_ %*?&])[A-Za-z\d@$!%_ *?&]{8,}$")) {
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
                MessageBox.Show("Вход выполнен успешно!");
                Program.ReplaceForm(new MainForm(), this);
            }
            else
            {
                WrongDataLabel.Visible = true;
            }  
        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(new SignUpForm(), this);
        }
    }
}