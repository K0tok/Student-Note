namespace Student_Note
{
    partial class MakeHomework
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
            TextHomework = new TextBox();
            SelectLesson = new ComboBox();
            LabelSubject = new Label();
            SelectDate = new DateTimePicker();
            SelectNumberLesson = new ComboBox();
            LabelDate = new Label();
            LabelNumberLesson = new Label();
            LabelAddFile = new Label();
            CancelHomework = new Button();
            SaveHomework = new Button();
            FileLink = new TextBox();
            textSubject = new TextBox();
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
            HeaderLabel.Size = new Size(560, 67);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Добавить домашнее задание";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextHomework
            // 
            TextHomework.Location = new Point(11, 131);
            TextHomework.Multiline = true;
            TextHomework.Name = "TextHomework";
            TextHomework.Size = new Size(535, 215);
            TextHomework.TabIndex = 4;
            // 
            // SelectLesson
            // 
            SelectLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectLesson.FlatStyle = FlatStyle.Flat;
            SelectLesson.FormattingEnabled = true;
            SelectLesson.Items.AddRange(new object[] { "Математика", "Философия" });
            SelectLesson.Location = new Point(0, 378);
            SelectLesson.Name = "SelectLesson";
            SelectLesson.Size = new Size(151, 28);
            SelectLesson.TabIndex = 1;
            SelectLesson.SelectedIndexChanged += SelectLesson_SelectedIndexChanged;
            // 
            // LabelSubject
            // 
            LabelSubject.AutoSize = true;
            LabelSubject.Location = new Point(11, 75);
            LabelSubject.Name = "LabelSubject";
            LabelSubject.Size = new Size(70, 20);
            LabelSubject.TabIndex = 4;
            LabelSubject.Text = "Предмет";
            // 
            // SelectDate
            // 
            SelectDate.Location = new Point(169, 99);
            SelectDate.Name = "SelectDate";
            SelectDate.Size = new Size(250, 27);
            SelectDate.TabIndex = 2;
            SelectDate.Value = new DateTime(2024, 12, 4, 22, 10, 51, 0);
            // 
            // SelectNumberLesson
            // 
            SelectNumberLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectNumberLesson.FlatStyle = FlatStyle.Flat;
            SelectNumberLesson.FormattingEnabled = true;
            SelectNumberLesson.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "1 - В", "2 - В" });
            SelectNumberLesson.Location = new Point(426, 97);
            SelectNumberLesson.Name = "SelectNumberLesson";
            SelectNumberLesson.Size = new Size(122, 28);
            SelectNumberLesson.TabIndex = 3;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Location = new Point(169, 75);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(52, 20);
            LabelDate.TabIndex = 7;
            LabelDate.Text = "Число";
            // 
            // LabelNumberLesson
            // 
            LabelNumberLesson.AutoSize = true;
            LabelNumberLesson.Location = new Point(425, 77);
            LabelNumberLesson.Name = "LabelNumberLesson";
            LabelNumberLesson.Size = new Size(98, 20);
            LabelNumberLesson.TabIndex = 8;
            LabelNumberLesson.Text = "Номер пары";
            // 
            // LabelAddFile
            // 
            LabelAddFile.AutoSize = true;
            LabelAddFile.Location = new Point(11, 355);
            LabelAddFile.Name = "LabelAddFile";
            LabelAddFile.Size = new Size(187, 20);
            LabelAddFile.TabIndex = 9;
            LabelAddFile.Text = "Добавить ссылку на файл";
            // 
            // CancelHomework
            // 
            CancelHomework.Location = new Point(353, 349);
            CancelHomework.Name = "CancelHomework";
            CancelHomework.Size = new Size(94, 29);
            CancelHomework.TabIndex = 6;
            CancelHomework.Text = "Отменить";
            CancelHomework.UseVisualStyleBackColor = true;
            CancelHomework.Click += CancelHomework_Click;
            // 
            // SaveHomework
            // 
            SaveHomework.Location = new Point(453, 349);
            SaveHomework.Name = "SaveHomework";
            SaveHomework.Size = new Size(94, 29);
            SaveHomework.TabIndex = 7;
            SaveHomework.Text = "Сохранить";
            SaveHomework.UseVisualStyleBackColor = true;
            SaveHomework.Click += SaveHomework_Click;
            // 
            // FileLink
            // 
            FileLink.BorderStyle = BorderStyle.None;
            FileLink.Location = new Point(190, 355);
            FileLink.Margin = new Padding(3, 4, 3, 4);
            FileLink.Name = "FileLink";
            FileLink.Size = new Size(157, 20);
            FileLink.TabIndex = 10;
            // 
            // textSubject
            // 
            textSubject.Location = new Point(12, 97);
            textSubject.Name = "textSubject";
            textSubject.ReadOnly = true;
            textSubject.Size = new Size(151, 27);
            textSubject.TabIndex = 11;
            // 
            // MakeHomework
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 389);
            Controls.Add(textSubject);
            Controls.Add(FileLink);
            Controls.Add(SaveHomework);
            Controls.Add(CancelHomework);
            Controls.Add(LabelAddFile);
            Controls.Add(LabelNumberLesson);
            Controls.Add(LabelDate);
            Controls.Add(SelectNumberLesson);
            Controls.Add(SelectDate);
            Controls.Add(LabelSubject);
            Controls.Add(SelectLesson);
            Controls.Add(TextHomework);
            Controls.Add(HeaderLabel);
            Name = "MakeHomework";
            Text = "MakeHomework";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox TextHomework;
        private ComboBox SelectLesson;
        private Label LabelSubject;
        private DateTimePicker SelectDate;
        private ComboBox SelectNumberLesson;
        private Label LabelDate;
        private Label LabelNumberLesson;
        private Label LabelAddFile;
        private Button CancelHomework;
        private Button SaveHomework;
        private TextBox FileLink;
        private TextBox textSubject;
    }
}