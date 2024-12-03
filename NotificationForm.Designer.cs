namespace Student_Note
{
    partial class NotificationForm
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
            label2 = new Label();
            button1 = new Button();
            LogInButton = new Button();
            LogUpLinkLabel = new LinkLabel();
            textBox1 = new TextBox();
            label5 = new Label();
            LoginTextBox = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
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
            HeaderLabel.Size = new Size(681, 67);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Объявление";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 36;
            label2.Text = "Заголовок";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(52, 199, 89);
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(558, 427);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 37);
            button1.TabIndex = 50;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogInButton.BackColor = Color.FromArgb(203, 66, 66);
            LogInButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInButton.Location = new Point(441, 427);
            LogInButton.Margin = new Padding(3, 4, 3, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(110, 37);
            LogInButton.TabIndex = 49;
            LogInButton.Text = "Отменить";
            LogInButton.UseVisualStyleBackColor = false;
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogUpLinkLabel.BackColor = Color.FromArgb(224, 224, 224);
            LogUpLinkLabel.Location = new Point(269, 387);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(179, 36);
            LogUpLinkLabel.TabIndex = 48;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Прикрепить файл";
            LogUpLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 18F);
            textBox1.Location = new Point(269, 387);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(179, 35);
            textBox1.TabIndex = 47;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F);
            label5.Location = new Point(24, 387);
            label5.Name = "label5";
            label5.Size = new Size(257, 35);
            label5.TabIndex = 46;
            label5.Text = "Добавить файлы:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(24, 237);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(550, 119);
            LoginTextBox.TabIndex = 45;
            LoginTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(24, 197);
            label4.Name = "label4";
            label4.Size = new Size(212, 35);
            label4.TabIndex = 44;
            label4.Text = "Текст задания";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 18F);
            textBox2.Location = new Point(24, 135);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 35);
            textBox2.TabIndex = 51;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(681, 468);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(LogInButton);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(LoginTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(HeaderLabel);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(697, 504);
            Name = "NotificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label label2;
        private Button button1;
        private Button LogInButton;
        private LinkLabel LogUpLinkLabel;
        private TextBox textBox1;
        private Label label5;
        private TextBox LoginTextBox;
        private Label label4;
        private TextBox textBox2;
    }
}