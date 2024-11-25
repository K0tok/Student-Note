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
using Microsoft.Data.Sqlite;
using Student_Note;

namespace Student_Note
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void labels_invisible()
        {
            WrongPasswordLabel.Visible = false;
            WrongMailLabel.Visible = false;
            WrongPhoneLabel.Visible = false;
            WrongSurnameLabel.Visible = false;
            WrongNameLabel.Visible = false;
            WrongMiddlenameLabel.Visible = false;
            WrongBirthdateLabel.Visible = false;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            labels_invisible();
        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(Program.LogInForm, this);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string surname = SurnameText.Text;
            string name = NameText.Text;
            string middleName = MiddleName.Text;
            string gender = listBox1.Text;
            int sex = 1;
            // Проверка пола
            if(gender == "Женский")
            {
                sex = 0;
            }
            string birthdate = BirthdateText.Text;
            string reg_date = DateTime.Now.Date.ToString("dd-MM-yyyy");
            string email = EmailText.Text;
            string phoneNumber = PhoneNumberText.Text;
            string status = listBox2.Text;
            int status_int = 0;
            // Проверка статуса
            if (status == "Староста")
            {
                status_int = 1;
            }
            string password = PasswordText.Text;

            labels_invisible();

            bool hasErrors = false;
            
            // Проверки
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%_*?&])[A-Za-z\d@$!_%*?&]{8,}$"))
            {
                WrongPasswordLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                WrongMailLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\+?[1-9]\d{9,14}$"))
            {
                WrongPhoneLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(surname, @"^[A-Za-zА-Яа-яЁё]{2,50}$"))
            {
                WrongSurnameLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(name, @"^[A-Za-zА-Яа-яЁё]{2,50}$"))
            {
                WrongNameLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(middleName, @"^([A-Za-zА-Яа-яЁё]{2,50})?$"))
            {
                WrongMiddlenameLabel.Visible = true;
                hasErrors = true;
            }

            if (!Regex.IsMatch(birthdate, @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.(19|20)\d{2}$"))
            {
                WrongBirthdateLabel.Visible = true;
                hasErrors = true;
            }

            // Если есть ошибки, прекратить выполнение дальнейшей логики
            if (hasErrors)
            {
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
                cmd.Parameters.AddWithValue("@Last_name", surname);
                cmd.Parameters.AddWithValue("@First_name", name);
                cmd.Parameters.AddWithValue("@Second_name", middleName);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                cmd.Parameters.AddWithValue("@Reg_date", reg_date);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@Member_type", status_int);
                cmd.Parameters.AddWithValue("@Password", password);

                // SQL-запрос
                cmd.CommandText = "INSERT INTO Users (last_name, first_name, second_name, sex, birthdate, reg_date, email, phone_number, member_type, password) " +
                    "VALUES (@Last_name, @First_name, @Second_name, @Sex, @Birthdate, @Reg_date, @Email, @Phone_number, @Member_type, @Password)";
                int countRows = cmd.ExecuteNonQuery();

                // Проверка на ответ 
                if (countRows != 1)
                {
                    return;
                }

                // Проверка на наличие пользователя и получение его данных
                cmd.CommandText = @"SELECT id, last_name, first_name, second_name, sex, birthdate, reg_date, email, phone_number, member_type 
                    FROM Users WHERE phone_number = @Phone_number AND password = @Password";


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

            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Регистрация не удалась. Возникла ошибка: " + ex.Message);
            }


            if (Program.isLog)
                if (status_int == 0)    Program.ReplaceForm(Program.MainForm, this);    // Переход, если пользователь регистрируется как не староста 
                else                    Program.ReplaceForm(Program.AddGroupForm, this);// Переход, если пользователь регистрируется как староста 


        }
    }
}