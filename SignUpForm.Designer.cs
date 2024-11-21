namespace Student_Note
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            LogInButton = new Button();
            label1 = new Label();
            LogUpLinkLabel = new LinkLabel();
            PasswordText = new TextBox();
            label3 = new Label();
            label5 = new Label();
            BirthdateText = new TextBox();
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
            HeaderLabel.Text = "Регистрация";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WrongSurnameLabel
            // 
            WrongSurnameLabel.AutoSize = true;
            WrongSurnameLabel.BackColor = Color.Transparent;
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
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Arial", 18F);
            LoginLabel.Location = new Point(12, 68);
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
            SurnameText.Location = new Point(12, 101);
            SurnameText.Name = "SurnameText";
            SurnameText.Size = new Size(289, 28);
            SurnameText.TabIndex = 6;
            // 
            // WrongMailLabel
            // 
            WrongMailLabel.AutoSize = true;
            WrongMailLabel.BackColor = Color.Transparent;
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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(333, 68);
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
            EmailText.Location = new Point(333, 101);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(289, 28);
            EmailText.TabIndex = 9;
            // 
            // WrongNameLable
            // 
            WrongNameLable.AutoSize = true;
            WrongNameLable.BackColor = Color.Transparent;
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
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(12, 154);
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
            NameText.Location = new Point(12, 187);
            NameText.Name = "NameText";
            NameText.Size = new Size(289, 28);
            NameText.TabIndex = 12;
            // 
            // WrongPhoneLabel
            // 
            WrongPhoneLabel.AutoSize = true;
            WrongPhoneLabel.BackColor = Color.Transparent;
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
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 18F);
            label6.Location = new Point(333, 154);
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
            PhoneNumberText.Location = new Point(333, 187);
            PhoneNumberText.Name = "PhoneNumberText";
            PhoneNumberText.Size = new Size(289, 28);
            PhoneNumberText.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 18F);
            label8.Location = new Point(333, 240);
            label8.Name = "label8";
            label8.Size = new Size(181, 27);
            label8.TabIndex = 19;
            label8.Text = "Укажите статус";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 18F);
            label10.Location = new Point(12, 325);
            label10.Name = "label10";
            label10.Size = new Size(55, 27);
            label10.TabIndex = 25;
            label10.Text = "Пол";
            // 
            // WrongMiddlenameLabel
            // 
            WrongMiddlenameLabel.AutoSize = true;
            WrongMiddlenameLabel.BackColor = Color.Transparent;
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
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 18F);
            label12.Location = new Point(12, 240);
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
            MiddleName.Location = new Point(12, 273);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(289, 28);
            MiddleName.TabIndex = 21;
            // 
            // WrongPasswordLabel
            // 
            WrongPasswordLabel.AutoSize = true;
            WrongPasswordLabel.BackColor = Color.Transparent;
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
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 18F);
            label14.Location = new Point(333, 325);
            label14.Name = "label14";
            label14.Size = new Size(95, 27);
            label14.TabIndex = 28;
            label14.Text = "Пароль";
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
            LogInButton.Location = new Point(347, 422);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(251, 49);
            LogInButton.TabIndex = 32;
            LogInButton.Text = "Зарегистрироваться";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(411, 474);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 33;
            label1.Text = "Есть аккаунт?";
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.AutoSize = true;
            LogUpLinkLabel.BackColor = Color.Transparent;
            LogUpLinkLabel.Location = new Point(497, 474);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(43, 15);
            LogUpLinkLabel.TabIndex = 34;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Войти!";
            LogUpLinkLabel.LinkClicked += LogUpLinkLabel_LinkClicked;
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.Top;
            PasswordText.BackColor = Color.FromArgb(224, 224, 224);
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Font = new Font("Arial", 18F);
            PasswordText.Location = new Point(333, 359);
            PasswordText.Margin = new Padding(3, 4, 3, 4);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(289, 28);
            PasswordText.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(255, 59, 48);
            label3.Location = new Point(183, 474);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 37;
            label3.Text = "*Неверный формат";
            label3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F);
            label5.Location = new Point(12, 409);
            label5.Name = "label5";
            label5.Size = new Size(180, 27);
            label5.TabIndex = 36;
            label5.Text = "Дата рождения";
            // 
            // BirthdateText
            // 
            BirthdateText.Anchor = AnchorStyles.Top;
            BirthdateText.BackColor = Color.FromArgb(224, 224, 224);
            BirthdateText.BorderStyle = BorderStyle.None;
            BirthdateText.Font = new Font("Arial", 18F);
            BirthdateText.Location = new Point(12, 443);
            BirthdateText.Margin = new Padding(3, 4, 3, 4);
            BirthdateText.Name = "BirthdateText";
            BirthdateText.Size = new Size(289, 28);
            BirthdateText.TabIndex = 38;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(634, 506);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(BirthdateText);
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
            MaximizeBox = false;
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
        private Label label3;
        private Label label5;
        private TextBox BirthdateText;
    }
}