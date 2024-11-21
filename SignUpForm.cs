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

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(new LogInForm(), this);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string surname = SurnameText.Text;
            string name = NameText.Text;
            string middleName = MiddleName.Text;
            if (middleName == null)
            {
                middleName = "-";
            }
            string gender = listBox1.Text;
            int sex = 1;
            // Проверка пола
            if(gender == "Женский")
            {
                sex = 0;
            }
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
            //if (Data_Base.sqliteConnect != null && Data_Base.sqliteConnect.State == System.Data.ConnectionState.Open)
            //{
            //using (SqliteConnection connection = new SqliteConnection("Data Source=Student Note.db"))
            //{
            //    // Открываем подключение
            //    connection.Open();
                try
                {
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.CommandType = CommandType.Text;
                    // Параметры с защитой от SQL инъекций
                    cmd.Parameters.AddWithValue("@Last_name", surname);
                    cmd.Parameters.AddWithValue("@First_name", name);
                    cmd.Parameters.AddWithValue("@Second_name", middleName);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Reg_date", reg_date);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone_number", phoneNumber);
                    cmd.Parameters.AddWithValue("@Member_type", status_int);
                    cmd.Parameters.AddWithValue("@Password", password);
                    // Команда для SQL запроса
                    cmd.CommandText = "INSERT INTO Users(last_name, first_name, second_name, sex, email, phone_number, member_type) " +
                        "VALUES (@Last_name, @First_name, @Second_name, @Sex, @Reg_date, @Email, @Phone_number, @Member_type)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO Passwords(password) VALUES (@Password)";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Регистрация не удалась. Возникла ошибка: " + ex.Message);
                }
            //}
            //else
            //{
            //    MessageBox.Show("База данных не открыта!");
            //}

                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%_ *?&])[A-Za-z\d@$!_ %*?&]{8,}$"))
            {
                MessageBox.Show("Неверный формат пароля");
                //return;
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Неправильный формат почты");
                //return;
            }
            if (!Regex.IsMatch(phoneNumber, @"^\+?[1-9]\d{9,14}$"))
            {
                MessageBox.Show("Неправильный формат номера телефона");
                //return;
            }
            if (!Regex.IsMatch(surname, @"^[A-Za-zА-Яа-яЁё]{2,50}$"))
            {
                MessageBox.Show("Неправильный формат фамилии");
                //return;
            }
            if (!Regex.IsMatch(name, @"^[A-Za-zА-Яа-яЁё]{2,50}$"))
            {
                MessageBox.Show("Неправильный формат имени");
                //return;
            }
            if (!Regex.IsMatch(middleName, @"^[A-Za-zА-Яа-яЁё]{2,50}$"))
            {
                MessageBox.Show("Неправильный формат отчества");
                //return;
            }

            //...
            // Проверка от сервера
            Program.isLog = true;
            //..

            if (Program.isLog)
                Program.ReplaceForm(new MainForm(), this);
        }
    }
}