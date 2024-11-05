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
            LoginTextBox = new TextBox();
            WrongMailLabel = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            WrongNameLable = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            WrongPhoneLabel = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            WrongMiddlenameLabel = new Label();
            label12 = new Label();
            textBox6 = new TextBox();
            WrongPasswordLabel = new Label();
            label14 = new Label();
            textBox7 = new TextBox();
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
            HeaderLabel.Padding = new Padding(57, 0, 0, 0);
            HeaderLabel.Size = new Size(725, 67);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Зарегистрироваться";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WrongSurnameLabel
            // 
            WrongSurnameLabel.AutoSize = true;
            WrongSurnameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongSurnameLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongSurnameLabel.Location = new Point(209, 176);
            WrongSurnameLabel.Name = "WrongSurnameLabel";
            WrongSurnameLabel.Size = new Size(139, 17);
            WrongSurnameLabel.TabIndex = 8;
            WrongSurnameLabel.Text = "*Неверный формат";
            WrongSurnameLabel.Visible = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Arial", 18F);
            LoginLabel.Location = new Point(14, 95);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(143, 35);
            LoginLabel.TabIndex = 7;
            LoginLabel.Text = "Фамилия";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(14, 135);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(330, 35);
            LoginTextBox.TabIndex = 6;
            LoginTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongMailLabel
            // 
            WrongMailLabel.AutoSize = true;
            WrongMailLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongMailLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongMailLabel.Location = new Point(576, 176);
            WrongMailLabel.Name = "WrongMailLabel";
            WrongMailLabel.Size = new Size(139, 17);
            WrongMailLabel.TabIndex = 11;
            WrongMailLabel.Text = "*Неверный формат";
            WrongMailLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(381, 95);
            label2.Name = "label2";
            label2.Size = new Size(98, 35);
            label2.TabIndex = 10;
            label2.Text = "Почта";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 18F);
            textBox1.Location = new Point(381, 135);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 35);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongNameLable
            // 
            WrongNameLable.AutoSize = true;
            WrongNameLable.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongNameLable.ForeColor = Color.FromArgb(255, 59, 48);
            WrongNameLable.Location = new Point(209, 291);
            WrongNameLable.Name = "WrongNameLable";
            WrongNameLable.Size = new Size(139, 17);
            WrongNameLable.TabIndex = 14;
            WrongNameLable.Text = "*Неверный формат";
            WrongNameLable.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(14, 209);
            label4.Name = "label4";
            label4.Size = new Size(74, 35);
            label4.TabIndex = 13;
            label4.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 18F);
            textBox2.Location = new Point(14, 249);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 35);
            textBox2.TabIndex = 12;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongPhoneLabel
            // 
            WrongPhoneLabel.AutoSize = true;
            WrongPhoneLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongPhoneLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongPhoneLabel.Location = new Point(576, 291);
            WrongPhoneLabel.Name = "WrongPhoneLabel";
            WrongPhoneLabel.Size = new Size(139, 17);
            WrongPhoneLabel.TabIndex = 17;
            WrongPhoneLabel.Text = "*Неверный формат";
            WrongPhoneLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F);
            label6.Location = new Point(381, 209);
            label6.Name = "label6";
            label6.Size = new Size(251, 35);
            label6.TabIndex = 16;
            label6.Text = "Номер телефона";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(224, 224, 224);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 18F);
            textBox3.Location = new Point(381, 249);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 35);
            textBox3.TabIndex = 15;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 18F);
            label8.Location = new Point(381, 324);
            label8.Name = "label8";
            label8.Size = new Size(226, 35);
            label8.TabIndex = 19;
            label8.Text = "Укажите статус";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 18F);
            label10.Location = new Point(14, 439);
            label10.Name = "label10";
            label10.Size = new Size(70, 35);
            label10.TabIndex = 25;
            label10.Text = "Пол";
            // 
            // WrongMiddlenameLabel
            // 
            WrongMiddlenameLabel.AutoSize = true;
            WrongMiddlenameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongMiddlenameLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongMiddlenameLabel.Location = new Point(209, 405);
            WrongMiddlenameLabel.Name = "WrongMiddlenameLabel";
            WrongMiddlenameLabel.Size = new Size(139, 17);
            WrongMiddlenameLabel.TabIndex = 23;
            WrongMiddlenameLabel.Text = "*Неверный формат";
            WrongMiddlenameLabel.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 18F);
            label12.Location = new Point(14, 324);
            label12.Name = "label12";
            label12.Size = new Size(156, 35);
            label12.TabIndex = 22;
            label12.Text = "Отчество*";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.BackColor = Color.FromArgb(224, 224, 224);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Arial", 18F);
            textBox6.Location = new Point(14, 364);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(330, 35);
            textBox6.TabIndex = 21;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // WrongPasswordLabel
            // 
            WrongPasswordLabel.AutoSize = true;
            WrongPasswordLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongPasswordLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongPasswordLabel.Location = new Point(576, 520);
            WrongPasswordLabel.Name = "WrongPasswordLabel";
            WrongPasswordLabel.Size = new Size(139, 17);
            WrongPasswordLabel.TabIndex = 29;
            WrongPasswordLabel.Text = "*Неверный формат";
            WrongPasswordLabel.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 18F);
            label14.Location = new Point(381, 439);
            label14.Name = "label14";
            label14.Size = new Size(119, 35);
            label14.TabIndex = 28;
            label14.Text = "Пароль";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top;
            textBox7.BackColor = Color.FromArgb(224, 224, 224);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Arial", 18F);
            textBox7.Location = new Point(381, 477);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(330, 35);
            textBox7.TabIndex = 27;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(224, 224, 224);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Items.AddRange(new object[] { "Мужской", "Женский" });
            listBox1.Location = new Point(14, 479);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 35);
            listBox1.TabIndex = 30;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(224, 224, 224);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Arial", 18F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 35;
            listBox2.Items.AddRange(new object[] { "Студент", "Староста" });
            listBox2.Location = new Point(381, 365);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(330, 35);
            listBox2.TabIndex = 31;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(52, 199, 89);
            LogInButton.Font = new Font("Arial", 18F);
            LogInButton.Location = new Point(225, 545);
            LogInButton.Margin = new Padding(3, 4, 3, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(274, 65);
            LogInButton.TabIndex = 32;
            LogInButton.Text = "Вход";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 607);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 33;
            label1.Text = "Есть аккаунт?";
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.AutoSize = true;
            LogUpLinkLabel.Location = new Point(383, 607);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(55, 20);
            LogUpLinkLabel.TabIndex = 34;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Войти!";
            LogUpLinkLabel.LinkClicked += LogUpLinkLabel_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(725, 639);
            Controls.Add(label1);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(LogInButton);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(WrongPasswordLabel);
            Controls.Add(label14);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(WrongMiddlenameLabel);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(WrongPhoneLabel);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(WrongNameLable);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(WrongMailLabel);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(WrongSurnameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox LoginTextBox;
        private Label WrongMailLabel;
        private Label label2;
        private TextBox textBox1;
        private Label WrongNameLable;
        private Label label4;
        private TextBox textBox2;
        private Label WrongPhoneLabel;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label WrongMiddlenameLabel;
        private Label label12;
        private TextBox textBox6;
        private Label WrongPasswordLabel;
        private Label label14;
        private TextBox textBox7;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button LogInButton;
        private Label label1;
        private LinkLabel LogUpLinkLabel;
    }
}