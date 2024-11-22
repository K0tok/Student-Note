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
            selectGroups = new ComboBox();
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
            HeaderLabel.Size = new Size(562, 67);
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
            NameGroup.Click += label1_Click;
            // 
            // selectGroups
            // 
            selectGroups.FormattingEnabled = true;
            selectGroups.Location = new Point(12, 105);
            selectGroups.Name = "selectGroups";
            selectGroups.Size = new Size(151, 28);
            selectGroups.TabIndex = 4;
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 364);
            Controls.Add(selectGroups);
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
        private ComboBox selectGroups;
    }
}