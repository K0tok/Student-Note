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
            GroupSpeNames = new ComboBox();
            label1 = new Label();
            ComboBoxNames = new ComboBox();
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
            HeaderLabel.Size = new Size(366, 50);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Создание группы";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameGroup
            // 
            NameGroup.AutoSize = true;
            NameGroup.Location = new Point(10, 62);
            NameGroup.Name = "NameGroup";
            NameGroup.Size = new Size(103, 15);
            NameGroup.TabIndex = 3;
            NameGroup.Text = "Название группы";
            // 
            // CreateGroup
            // 
            CreateGroup.Location = new Point(186, 104);
            CreateGroup.Margin = new Padding(3, 2, 3, 2);
            CreateGroup.Name = "CreateGroup";
            CreateGroup.Size = new Size(170, 22);
            CreateGroup.TabIndex = 5;
            CreateGroup.Text = "Создать";
            CreateGroup.UseVisualStyleBackColor = true;
            CreateGroup.Click += CreateGroup_Click;
            // 
            // CenselCreateGroup
            // 
            CenselCreateGroup.Location = new Point(10, 104);
            CenselCreateGroup.Margin = new Padding(3, 2, 3, 2);
            CenselCreateGroup.Name = "CenselCreateGroup";
            CenselCreateGroup.Size = new Size(170, 22);
            CenselCreateGroup.TabIndex = 6;
            CenselCreateGroup.Text = "Отменить";
            CenselCreateGroup.UseVisualStyleBackColor = true;
            CenselCreateGroup.Click += CenselCreateGroup_Click;
            // 
            // GroupSpeNames
            // 
            GroupSpeNames.FormattingEnabled = true;
            GroupSpeNames.Location = new Point(186, 79);
            GroupSpeNames.Margin = new Padding(3, 2, 3, 2);
            GroupSpeNames.Name = "GroupSpeNames";
            GroupSpeNames.Size = new Size(170, 23);
            GroupSpeNames.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 62);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 9;
            label1.Text = "Специализация";
            // 
            // ComboBoxNames
            // 
            ComboBoxNames.FormattingEnabled = true;
            ComboBoxNames.Location = new Point(10, 79);
            ComboBoxNames.Margin = new Padding(3, 2, 3, 2);
            ComboBoxNames.Name = "ComboBoxNames";
            ComboBoxNames.Size = new Size(170, 23);
            ComboBoxNames.TabIndex = 10;
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 133);
            Controls.Add(ComboBoxNames);
            Controls.Add(label1);
            Controls.Add(GroupSpeNames);
            Controls.Add(CenselCreateGroup);
            Controls.Add(CreateGroup);
            Controls.Add(NameGroup);
            Controls.Add(HeaderLabel);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(382, 172);
            MinimumSize = new Size(382, 172);
            Name = "AddGroupForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AddGroupForm";
            Load += AddGroupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label NameGroup;
        private Button CreateGroup;
        private Button CenselCreateGroup;
        private ComboBox GroupSpeNames;
        private Label label1;
        private ComboBox ComboBoxNames;
    }
}