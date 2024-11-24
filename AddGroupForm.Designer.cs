namespace Student_Note
{
    partial class AddGroupForm
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
            NameGroup = new Label();
            CreateGroup = new Button();
            CenselCreateGroup = new Button();
            TextBoxNameGroup = new TextBox();
            GroupSpeNames = new ComboBox();
            label1 = new Label();
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
            HeaderLabel.Size = new Size(548, 67);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Создание группы";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameGroup
            // 
            NameGroup.AutoSize = true;
            NameGroup.Location = new Point(12, 82);
            NameGroup.Name = "NameGroup";
            NameGroup.Size = new Size(132, 20);
            NameGroup.TabIndex = 3;
            NameGroup.Text = "Название группы";
            // 
            // CreateGroup
            // 
            CreateGroup.Location = new Point(212, 139);
            CreateGroup.Name = "CreateGroup";
            CreateGroup.Size = new Size(151, 29);
            CreateGroup.TabIndex = 5;
            CreateGroup.Text = "Создать";
            CreateGroup.UseVisualStyleBackColor = true;
            CreateGroup.Click += CreateGroup_Click;
            // 
            // CenselCreateGroup
            // 
            CenselCreateGroup.Location = new Point(12, 139);
            CenselCreateGroup.Name = "CenselCreateGroup";
            CenselCreateGroup.Size = new Size(194, 29);
            CenselCreateGroup.TabIndex = 6;
            CenselCreateGroup.Text = "Отменить";
            CenselCreateGroup.UseVisualStyleBackColor = true;
            CenselCreateGroup.Click += CenselCreateGroup_Click;
            // 
            // TextBoxNameGroup
            // 
            TextBoxNameGroup.Location = new Point(12, 106);
            TextBoxNameGroup.Name = "TextBoxNameGroup";
            TextBoxNameGroup.Size = new Size(194, 27);
            TextBoxNameGroup.TabIndex = 7;
            // 
            // GroupSpeNames
            // 
            GroupSpeNames.FormattingEnabled = true;
            GroupSpeNames.Location = new Point(212, 105);
            GroupSpeNames.Name = "GroupSpeNames";
            GroupSpeNames.Size = new Size(151, 28);
            GroupSpeNames.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 82);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 9;
            label1.Text = "Специализация";
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 303);
            Controls.Add(label1);
            Controls.Add(GroupSpeNames);
            Controls.Add(TextBoxNameGroup);
            Controls.Add(CenselCreateGroup);
            Controls.Add(CreateGroup);
            Controls.Add(NameGroup);
            Controls.Add(HeaderLabel);
            Name = "AddGroupForm";
            Text = "AddGroupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label NameGroup;
        private Button CreateGroup;
        private Button CenselCreateGroup;
        private TextBox TextBoxNameGroup;
        private ComboBox GroupSpeNames;
        private Label label1;
    }
}