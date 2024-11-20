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
            string gender = listBox1.Text;
            string email = EmailText.Text;
            string phohneNumber = PhoneNumberText.Text;
            string status = listBox2.Text;
            string password = PasswordText.Text;

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
            if (!Regex.IsMatch(phohneNumber, @"^\+?[1-9]\d{9,14}$"))
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
