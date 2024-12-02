namespace Student_Note
{
    partial class GroupCreateForm
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
            GroupLabel = new Label();
            LoginTextBox = new TextBox();
            SpecLabel = new Label();
            textBox1 = new TextBox();
            CreateButton = new Button();
            ErrorLabel = new Label();
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
            HeaderLabel.Size = new Size(301, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Создание группы";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GroupLabel
            // 
            GroupLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GroupLabel.Font = new Font("Arial", 18F);
            GroupLabel.Location = new Point(65, 77);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(171, 27);
            GroupLabel.TabIndex = 3;
            GroupLabel.Text = "Номер группы";
            GroupLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.BackColor = Color.FromArgb(224, 224, 224);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Arial", 18F);
            LoginTextBox.Location = new Point(57, 107);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(186, 28);
            LoginTextBox.TabIndex = 4;
            LoginTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SpecLabel
            // 
            SpecLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SpecLabel.Font = new Font("Arial", 18F);
            SpecLabel.Location = new Point(57, 157);
            SpecLabel.Name = "SpecLabel";
            SpecLabel.Size = new Size(186, 27);
            SpecLabel.TabIndex = 5;
            SpecLabel.Text = "Специализация";
            SpecLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 18F);
            textBox1.Location = new Point(57, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 28);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CreateButton.BackColor = Color.FromArgb(52, 199, 89);
            CreateButton.Font = new Font("Arial", 18F);
            CreateButton.Location = new Point(57, 221);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(186, 49);
            CreateButton.TabIndex = 8;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ErrorLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrorLabel.ForeColor = Color.FromArgb(255, 59, 48);
            ErrorLabel.Location = new Point(82, 273);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(136, 15);
            ErrorLabel.TabIndex = 11;
            ErrorLabel.Text = "*Какая-нибудь ошибка";
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(301, 299);
            Controls.Add(ErrorLabel);
            Controls.Add(CreateButton);
            Controls.Add(textBox1);
            Controls.Add(SpecLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(GroupLabel);
            Controls.Add(HeaderLabel);
            MinimumSize = new Size(317, 338);
            Name = "GroupCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GroupCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label GroupLabel;
        private TextBox LoginTextBox;
        private Label SpecLabel;
        private TextBox textBox1;
        private Button CreateButton;
        private Label ErrorLabel;
    }
}