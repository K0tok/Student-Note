﻿namespace Student_Note
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            WrongSurnameLabel = new Label();
            LoginLabel = new Label();
            SurnameText = new TextBox();
            WrongMailLabel = new Label();
            label2 = new Label();
            EmailText = new TextBox();
            WrongNameLable = new Label();
            label4 = new Label();
            NameText = new TextBox();
            WrongPhoneLabel = new Label();
            label6 = new Label();
            PhoneNumberText = new TextBox();
            label8 = new Label();
            label10 = new Label();
            WrongMiddlenameLabel = new Label();
            label12 = new Label();
            MiddleName = new TextBox();
            WrongPasswordLabel = new Label();
            label14 = new Label();
            PasswordText = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            LogInButton = new Button();
            label1 = new Label();
            LogUpLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.BackColor = Color.FromArgb(52, 199, 89);
            HeaderLabel.Dock = DockStyle.Top;
            HeaderLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Margin = new Padding(0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Padding = new Padding(50, 0, 0, 0);
            HeaderLabel.Size = new Size(634, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Зарегистрироваться";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WrongSurnameLabel
            // 
            WrongSurnameLabel.AutoSize = true;
            WrongSurnameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongSurnameLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongSurnameLabel.Location = new Point(183, 132);
            WrongSurnameLabel.Name = "WrongSurnameLabel";
            WrongSurnameLabel.Size = new Size(118, 15);
            WrongSurnameLabel.TabIndex = 8;
            WrongSurnameLabel.Text = "*Неверный формат";
            WrongSurnameLabel.Visible = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Arial", 18F);
            LoginLabel.Location = new Point(12, 71);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(113, 27);
            LoginLabel.TabIndex = 7;
            LoginLabel.Text = "Фамилия";
            // 
            // SurnameText
            // 
            SurnameText.Anchor = AnchorStyles.Top;
            SurnameText.BackColor = Color.FromArgb(224, 224, 224);
            SurnameText.BorderStyle = BorderStyle.None;
            SurnameText.Font = new Font("Arial", 18F);
            SurnameText.Location = new Point(14, 135);
            SurnameText.Margin = new Padding(3, 4, 3, 4);
            SurnameText.Name = "SurnameText";
            SurnameText.Size = new Size(330, 35);
            SurnameText.TabIndex = 6;
            SurnameText.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongMailLabel
            // 
            WrongMailLabel.AutoSize = true;
            WrongMailLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongMailLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongMailLabel.Location = new Point(504, 132);
            WrongMailLabel.Name = "WrongMailLabel";
            WrongMailLabel.Size = new Size(118, 15);
            WrongMailLabel.TabIndex = 11;
            WrongMailLabel.Text = "*Неверный формат";
            WrongMailLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(333, 71);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 10;
            label2.Text = "Почта";
            // 
            // EmailText
            // 
            EmailText.Anchor = AnchorStyles.Top;
            EmailText.BackColor = Color.FromArgb(224, 224, 224);
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Font = new Font("Arial", 18F);
            EmailText.Location = new Point(381, 135);
            EmailText.Margin = new Padding(3, 4, 3, 4);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(330, 35);
            EmailText.TabIndex = 9;
            EmailText.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongNameLable
            // 
            WrongNameLable.AutoSize = true;
            WrongNameLable.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongNameLable.ForeColor = Color.FromArgb(255, 59, 48);
            WrongNameLable.Location = new Point(183, 218);
            WrongNameLable.Name = "WrongNameLable";
            WrongNameLable.Size = new Size(118, 15);
            WrongNameLable.TabIndex = 14;
            WrongNameLable.Text = "*Неверный формат";
            WrongNameLable.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(59, 27);
            label4.TabIndex = 13;
            label4.Text = "Имя";
            // 
            // NameText
            // 
            NameText.Anchor = AnchorStyles.Top;
            NameText.BackColor = Color.FromArgb(224, 224, 224);
            NameText.BorderStyle = BorderStyle.None;
            NameText.Font = new Font("Arial", 18F);
            NameText.Location = new Point(14, 249);
            NameText.Margin = new Padding(3, 4, 3, 4);
            NameText.Name = "NameText";
            NameText.Size = new Size(330, 35);
            NameText.TabIndex = 12;
            NameText.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongPhoneLabel
            // 
            WrongPhoneLabel.AutoSize = true;
            WrongPhoneLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongPhoneLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongPhoneLabel.Location = new Point(504, 218);
            WrongPhoneLabel.Name = "WrongPhoneLabel";
            WrongPhoneLabel.Size = new Size(118, 15);
            WrongPhoneLabel.TabIndex = 17;
            WrongPhoneLabel.Text = "*Неверный формат";
            WrongPhoneLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F);
            label6.Location = new Point(333, 157);
            label6.Name = "label6";
            label6.Size = new Size(202, 27);
            label6.TabIndex = 16;
            label6.Text = "Номер телефона";
            // 
            // PhoneNumberText
            // 
            PhoneNumberText.Anchor = AnchorStyles.Top;
            PhoneNumberText.BackColor = Color.FromArgb(224, 224, 224);
            PhoneNumberText.BorderStyle = BorderStyle.None;
            PhoneNumberText.Font = new Font("Arial", 18F);
            PhoneNumberText.Location = new Point(381, 249);
            PhoneNumberText.Margin = new Padding(3, 4, 3, 4);
            PhoneNumberText.Name = "PhoneNumberText";
            PhoneNumberText.Size = new Size(330, 35);
            PhoneNumberText.TabIndex = 15;
            PhoneNumberText.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 18F);
            label8.Location = new Point(333, 243);
            label8.Name = "label8";
            label8.Size = new Size(181, 27);
            label8.TabIndex = 19;
            label8.Text = "Укажите статус";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 18F);
            label10.Location = new Point(12, 329);
            label10.Name = "label10";
            label10.Size = new Size(55, 27);
            label10.TabIndex = 25;
            label10.Text = "Пол";
            // 
            // WrongMiddlenameLabel
            // 
            WrongMiddlenameLabel.AutoSize = true;
            WrongMiddlenameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongMiddlenameLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongMiddlenameLabel.Location = new Point(183, 304);
            WrongMiddlenameLabel.Name = "WrongMiddlenameLabel";
            WrongMiddlenameLabel.Size = new Size(118, 15);
            WrongMiddlenameLabel.TabIndex = 23;
            WrongMiddlenameLabel.Text = "*Неверный формат";
            WrongMiddlenameLabel.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 18F);
            label12.Location = new Point(12, 243);
            label12.Name = "label12";
            label12.Size = new Size(126, 27);
            label12.TabIndex = 22;
            label12.Text = "Отчество*";
            // 
            // MiddleName
            // 
            MiddleName.Anchor = AnchorStyles.Top;
            MiddleName.BackColor = Color.FromArgb(224, 224, 224);
            MiddleName.BorderStyle = BorderStyle.None;
            MiddleName.Font = new Font("Arial", 18F);
            MiddleName.Location = new Point(14, 364);
            MiddleName.Margin = new Padding(3, 4, 3, 4);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(330, 35);
            MiddleName.TabIndex = 21;
            MiddleName.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongPasswordLabel
            // 
            WrongPasswordLabel.AutoSize = true;
            WrongPasswordLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongPasswordLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongPasswordLabel.Location = new Point(504, 390);
            WrongPasswordLabel.Name = "WrongPasswordLabel";
            WrongPasswordLabel.Size = new Size(118, 15);
            WrongPasswordLabel.TabIndex = 29;
            WrongPasswordLabel.Text = "*Неверный формат";
            WrongPasswordLabel.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 18F);
            label14.Location = new Point(333, 329);
            label14.Name = "label14";
            label14.Size = new Size(95, 27);
            label14.TabIndex = 28;
            label14.Text = "Пароль";
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.Top;
            PasswordText.BackColor = Color.FromArgb(224, 224, 224);
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Font = new Font("Arial", 18F);
            PasswordText.Location = new Point(381, 477);
            PasswordText.Margin = new Padding(3, 4, 3, 4);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(330, 35);
            PasswordText.TabIndex = 27;
            PasswordText.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(224, 224, 224);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Items.AddRange(new object[] { "Мужской", "Женский" });
            listBox1.Location = new Point(12, 359);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 27);
            listBox1.TabIndex = 30;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(224, 224, 224);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Arial", 18F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 27;
            listBox2.Items.AddRange(new object[] { "Студент", "Староста" });
            listBox2.Location = new Point(333, 274);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(289, 27);
            listBox2.TabIndex = 31;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(52, 199, 89);
            LogInButton.Font = new Font("Arial", 18F);
            LogInButton.Location = new Point(197, 409);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(240, 49);
            LogInButton.TabIndex = 32;
            LogInButton.Text = "Вход";
            LogInButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 455);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 33;
            label1.Text = "Есть аккаунт?";
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.AutoSize = true;
            LogUpLinkLabel.Location = new Point(335, 455);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(43, 15);
            LogUpLinkLabel.TabIndex = 34;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Войти!";
            LogUpLinkLabel.LinkClicked += LogUpLinkLabel_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(634, 479);
            Controls.Add(label1);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(LogInButton);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(WrongPasswordLabel);
            Controls.Add(label14);
            Controls.Add(PasswordText);
            Controls.Add(label10);
            Controls.Add(WrongMiddlenameLabel);
            Controls.Add(label12);
            Controls.Add(MiddleName);
            Controls.Add(label8);
            Controls.Add(WrongPhoneLabel);
            Controls.Add(label6);
            Controls.Add(PhoneNumberText);
            Controls.Add(WrongNameLable);
            Controls.Add(label4);
            Controls.Add(NameText);
            Controls.Add(WrongMailLabel);
            Controls.Add(label2);
            Controls.Add(EmailText);
            Controls.Add(WrongSurnameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(SurnameText);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label WrongSurnameLabel;
        private Label LoginLabel;
        private TextBox SurnameText;
        private Label WrongMailLabel;
        private Label label2;
        private TextBox EmailText;
        private Label WrongNameLable;
        private Label label4;
        private TextBox NameText;
        private Label WrongPhoneLabel;
        private Label label6;
        private TextBox PhoneNumberText;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label WrongMiddlenameLabel;
        private Label label12;
        private TextBox MiddleName;
        private Label WrongPasswordLabel;
        private Label label14;
        private TextBox PasswordText;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button LogInButton;
        private Label label1;
        private LinkLabel LogUpLinkLabel;
    }
}