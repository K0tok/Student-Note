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
            AddFile = new LinkLabel();
            CancelHomework = new Button();
            SaveHomework = new Button();
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
            TextHomework.Location = new Point(12, 131);
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
            SelectLesson.Location = new Point(12, 97);
            SelectLesson.Name = "SelectLesson";
            SelectLesson.Size = new Size(151, 28);
            SelectLesson.TabIndex = 1;
            // 
            // LabelSubject
            // 
            LabelSubject.AutoSize = true;
            LabelSubject.Location = new Point(12, 74);
            LabelSubject.Name = "LabelSubject";
            LabelSubject.Size = new Size(70, 20);
            LabelSubject.TabIndex = 4;
            LabelSubject.Text = "Предмет";
            // 
            // SelectDate
            // 
            SelectDate.Location = new Point(169, 98);
            SelectDate.Name = "SelectDate";
            SelectDate.Size = new Size(250, 27);
            SelectDate.TabIndex = 2;
            // 
            // SelectNumberLesson
            // 
            SelectNumberLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectNumberLesson.FlatStyle = FlatStyle.Flat;
            SelectNumberLesson.FormattingEnabled = true;
            SelectNumberLesson.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "1-В", "2-В" });
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
            LabelAddFile.Location = new Point(12, 349);
            LabelAddFile.Name = "LabelAddFile";
            LabelAddFile.Size = new Size(126, 20);
            LabelAddFile.TabIndex = 9;
            LabelAddFile.Text = "Добавить файлы";
            // 
            // AddFile
            // 
            AddFile.AutoSize = true;
            AddFile.Location = new Point(144, 349);
            AddFile.Name = "AddFile";
            AddFile.Size = new Size(76, 20);
            AddFile.TabIndex = 5;
            AddFile.TabStop = true;
            AddFile.Text = "Добавить";
            // 
            // CancelHomework
            // 
            CancelHomework.Location = new Point(353, 349);
            CancelHomework.Name = "CancelHomework";
            CancelHomework.Size = new Size(94, 29);
            CancelHomework.TabIndex = 6;
            CancelHomework.Text = "Отменить";
            CancelHomework.UseVisualStyleBackColor = true;
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
            // MakeHomework
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 390);
            Controls.Add(SaveHomework);
            Controls.Add(CancelHomework);
            Controls.Add(AddFile);
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
        private LinkLabel AddFile;
        private Button CancelHomework;
        private Button SaveHomework;
    }
}