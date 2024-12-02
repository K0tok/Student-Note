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
            HeaderLabel.Padding = new Padding(50, 0, 0, 0);
            HeaderLabel.Size = new Size(490, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Добавить домашнее задание";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextHomework
            // 
            TextHomework.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextHomework.Location = new Point(10, 98);
            TextHomework.Margin = new Padding(3, 2, 3, 2);
            TextHomework.Multiline = true;
            TextHomework.Name = "TextHomework";
            TextHomework.Size = new Size(469, 162);
            TextHomework.TabIndex = 4;
            // 
            // SelectLesson
            // 
            SelectLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectLesson.FlatStyle = FlatStyle.Flat;
            SelectLesson.FormattingEnabled = true;
            SelectLesson.Items.AddRange(new object[] { "Математика", "Философия" });
            SelectLesson.Location = new Point(10, 73);
            SelectLesson.Margin = new Padding(3, 2, 3, 2);
            SelectLesson.Name = "SelectLesson";
            SelectLesson.Size = new Size(133, 23);
            SelectLesson.TabIndex = 1;
            // 
            // LabelSubject
            // 
            LabelSubject.AutoSize = true;
            LabelSubject.Location = new Point(10, 56);
            LabelSubject.Name = "LabelSubject";
            LabelSubject.Size = new Size(55, 15);
            LabelSubject.TabIndex = 4;
            LabelSubject.Text = "Предмет";
            // 
            // SelectDate
            // 
            SelectDate.Location = new Point(148, 74);
            SelectDate.Margin = new Padding(3, 2, 3, 2);
            SelectDate.Name = "SelectDate";
            SelectDate.Size = new Size(219, 23);
            SelectDate.TabIndex = 2;
            // 
            // SelectNumberLesson
            // 
            SelectNumberLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectNumberLesson.FlatStyle = FlatStyle.Flat;
            SelectNumberLesson.FormattingEnabled = true;
            SelectNumberLesson.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "1-В", "2-В" });
            SelectNumberLesson.Location = new Point(373, 73);
            SelectNumberLesson.Margin = new Padding(3, 2, 3, 2);
            SelectNumberLesson.Name = "SelectNumberLesson";
            SelectNumberLesson.Size = new Size(107, 23);
            SelectNumberLesson.TabIndex = 3;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Location = new Point(148, 56);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(42, 15);
            LabelDate.TabIndex = 7;
            LabelDate.Text = "Число";
            // 
            // LabelNumberLesson
            // 
            LabelNumberLesson.AutoSize = true;
            LabelNumberLesson.Location = new Point(372, 58);
            LabelNumberLesson.Name = "LabelNumberLesson";
            LabelNumberLesson.Size = new Size(77, 15);
            LabelNumberLesson.TabIndex = 8;
            LabelNumberLesson.Text = "Номер пары";
            // 
            // LabelAddFile
            // 
            LabelAddFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelAddFile.AutoSize = true;
            LabelAddFile.Location = new Point(10, 262);
            LabelAddFile.Name = "LabelAddFile";
            LabelAddFile.Size = new Size(100, 15);
            LabelAddFile.TabIndex = 9;
            LabelAddFile.Text = "Добавить файлы";
            // 
            // AddFile
            // 
            AddFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddFile.AutoSize = true;
            AddFile.Location = new Point(126, 262);
            AddFile.Name = "AddFile";
            AddFile.Size = new Size(59, 15);
            AddFile.TabIndex = 5;
            AddFile.TabStop = true;
            AddFile.Text = "Добавить";
            // 
            // CancelHomework
            // 
            CancelHomework.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelHomework.Location = new Point(309, 262);
            CancelHomework.Margin = new Padding(3, 2, 3, 2);
            CancelHomework.Name = "CancelHomework";
            CancelHomework.Size = new Size(82, 22);
            CancelHomework.TabIndex = 6;
            CancelHomework.Text = "Отменить";
            CancelHomework.UseVisualStyleBackColor = true;
            // 
            // SaveHomework
            // 
            SaveHomework.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveHomework.Location = new Point(396, 262);
            SaveHomework.Margin = new Padding(3, 2, 3, 2);
            SaveHomework.Name = "SaveHomework";
            SaveHomework.Size = new Size(82, 22);
            SaveHomework.TabIndex = 7;
            SaveHomework.Text = "Сохранить";
            SaveHomework.UseVisualStyleBackColor = true;
            SaveHomework.Click += SaveHomework_Click;
            // 
            // MakeHomework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 292);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(506, 331);
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