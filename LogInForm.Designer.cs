namespace Student_Note
{
    partial class LogInForm
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
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            WrongLoginLabel = new Label();
            WrongPasswordLabel = new Label();
            LogInButton = new Button();
            label6 = new Label();
            LogUpLinkLabel = new LinkLabel();
            WrongDataLabel = new Label();
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
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Войти в аккаунт";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(173, 107);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(289, 28);
            LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Arial", 18F);
            LoginLabel.Location = new Point(173, 74);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(289, 27);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Почта / Номер телефона";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Arial", 18F);
            PasswordLabel.Location = new Point(173, 159);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 27);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.BackColor = Color.FromArgb(224, 224, 224);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Arial", 18F);
            PasswordTextBox.Location = new Point(173, 192);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(289, 28);
            PasswordTextBox.TabIndex = 3;
            // 
            // WrongLoginLabel
            // 
            WrongLoginLabel.AutoSize = true;
            WrongLoginLabel.BackColor = Color.Transparent;
            WrongLoginLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongLoginLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongLoginLabel.Location = new Point(173, 138);
            WrongLoginLabel.Name = "WrongLoginLabel";
            WrongLoginLabel.Size = new Size(118, 15);
            WrongLoginLabel.TabIndex = 5;
            WrongLoginLabel.Text = "*Неверный формат";
            WrongLoginLabel.Visible = false;
            // 
            // WrongPasswordLabel
            // 
            WrongPasswordLabel.AutoSize = true;
            WrongPasswordLabel.BackColor = Color.Transparent;
            WrongPasswordLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongPasswordLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongPasswordLabel.Location = new Point(173, 223);
            WrongPasswordLabel.Name = "WrongPasswordLabel";
            WrongPasswordLabel.Size = new Size(118, 15);
            WrongPasswordLabel.TabIndex = 6;
            WrongPasswordLabel.Text = "*Неверный формат";
            WrongPasswordLabel.Visible = false;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(52, 199, 89);
            LogInButton.Font = new Font("Arial", 18F);
            LogInButton.Location = new Point(197, 250);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(240, 49);
            LogInButton.TabIndex = 7;
            LogInButton.Text = "Вход";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(216, 300);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 8;
            label6.Text = "Нет аккаунта?";
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.AutoSize = true;
            LogUpLinkLabel.BackColor = Color.Transparent;
            LogUpLinkLabel.Location = new Point(297, 300);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(122, 15);
            LogUpLinkLabel.TabIndex = 9;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Зарегистрироваться!";
            LogUpLinkLabel.LinkClicked += LogUpLinkLabel_LinkClicked;
            // 
            // WrongDataLabel
            // 
            WrongDataLabel.AutoSize = true;
            WrongDataLabel.BackColor = Color.Transparent;
            WrongDataLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WrongDataLabel.ForeColor = Color.FromArgb(255, 59, 48);
            WrongDataLabel.Location = new Point(230, 317);
            WrongDataLabel.Name = "WrongDataLabel";
            WrongDataLabel.Size = new Size(175, 15);
            WrongDataLabel.TabIndex = 10;
            WrongDataLabel.Text = "*Неверный логин или пароль";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(634, 361);
            Controls.Add(WrongDataLabel);
            Controls.Add(label6);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(LogInButton);
            Controls.Add(WrongPasswordLabel);
            Controls.Add(WrongLoginLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += LogInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label WrongLoginLabel;
        private Label WrongPasswordLabel;
        private Button LogInButton;
        private Label label6;
        private LinkLabel LogUpLinkLabel;
        private Label WrongDataLabel;
    }
}