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
            HeaderLabel.Padding = new Padding(50, 0, 0, 0);
            HeaderLabel.Size = new Size(596, 50);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Объявление";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(124, 27);
            label2.TabIndex = 36;
            label2.Text = "Заголовок";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(52, 199, 89);
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(488, 320);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 50;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogInButton.BackColor = Color.FromArgb(203, 66, 66);
            LogInButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInButton.Location = new Point(386, 320);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(96, 28);
            LogInButton.TabIndex = 49;
            LogInButton.Text = "Отменить";
            LogInButton.UseVisualStyleBackColor = false;
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogUpLinkLabel.BackColor = Color.FromArgb(224, 224, 224);
            LogUpLinkLabel.Location = new Point(235, 290);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(157, 27);
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
            textBox1.Location = new Point(235, 290);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(157, 28);
            textBox1.TabIndex = 47;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F);
            label5.Location = new Point(21, 290);
            label5.Name = "label5";
            label5.Size = new Size(208, 27);
            label5.TabIndex = 46;
            label5.Text = "Добавить файлы:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(21, 178);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(481, 89);
            LoginTextBox.TabIndex = 45;
            LoginTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(169, 27);
            label4.TabIndex = 44;
            label4.Text = "Текст задания";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 18F);
            textBox2.Location = new Point(21, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 28);
            textBox2.TabIndex = 51;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(596, 351);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(LogInButton);
            Controls.Add(label5);
            Controls.Add(LoginTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(HeaderLabel);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(612, 390);
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