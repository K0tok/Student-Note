namespace Student_Note
{
    partial class HomeworkForm
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            LoginTextBox = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            LogUpLinkLabel = new LinkLabel();
            LogInButton = new Button();
            button1 = new Button();
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
            HeaderLabel.Text = "Домашнее задание";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(224, 224, 224);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Items.AddRange(new object[] { "...", "..." });
            listBox1.Location = new Point(21, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(226, 27);
            listBox1.TabIndex = 31;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(224, 224, 224);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Arial", 18F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 27;
            listBox2.Items.AddRange(new object[] { "...", "..." });
            listBox2.Location = new Point(272, 101);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 27);
            listBox2.TabIndex = 32;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(224, 224, 224);
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Arial", 18F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 27;
            listBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            listBox3.Location = new Point(416, 101);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(86, 27);
            listBox3.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(109, 27);
            label2.TabIndex = 34;
            label2.Text = "Предмет";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F);
            label1.Location = new Point(272, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 35;
            label1.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F);
            label3.Location = new Point(416, 71);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 36;
            label3.Text = "Номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(169, 27);
            label4.TabIndex = 37;
            label4.Text = "Текст задания";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(21, 178);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(481, 89);
            LoginTextBox.TabIndex = 38;
            LoginTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F);
            label5.Location = new Point(21, 290);
            label5.Name = "label5";
            label5.Size = new Size(208, 27);
            label5.TabIndex = 39;
            label5.Text = "Добавить файлы:";
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
            textBox1.TabIndex = 40;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // LogUpLinkLabel
            // 
            LogUpLinkLabel.BackColor = Color.FromArgb(224, 224, 224);
            LogUpLinkLabel.Location = new Point(235, 290);
            LogUpLinkLabel.Name = "LogUpLinkLabel";
            LogUpLinkLabel.Size = new Size(157, 27);
            LogUpLinkLabel.TabIndex = 41;
            LogUpLinkLabel.TabStop = true;
            LogUpLinkLabel.Text = "Прикрепить файл";
            LogUpLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(203, 66, 66);
            LogInButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInButton.Location = new Point(386, 320);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(96, 28);
            LogInButton.TabIndex = 42;
            LogInButton.Text = "Отменить";
            LogInButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 199, 89);
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(488, 320);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 43;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomeworkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(596, 351);
            Controls.Add(button1);
            Controls.Add(LogInButton);
            Controls.Add(LogUpLinkLabel);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(LoginTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeworkForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeworkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox LoginTextBox;
        private Label label5;
        private TextBox textBox1;
        private LinkLabel LogUpLinkLabel;
        private Button LogInButton;
        private Button button1;
    }
}