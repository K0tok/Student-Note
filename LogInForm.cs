﻿using System;
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
            }
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string emailOrPhohneNumber = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (!Regex.IsMatch(emailOrPhohneNumber, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") && !Regex.IsMatch(emailOrPhohneNumber, @"^\+?[0-9]\d{9,14}$"))
            {
                MessageBox.Show("Неправильный формат номера телефона или почта");
                //return;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!_ %*?&])[A-Za-z\d@$!%_ *?&]{8,}$")) {
                MessageBox.Show("Неверный формат пароля");
                //return;
            }

            //...
            Server.Entry(password, emailOrPhohneNumber);
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