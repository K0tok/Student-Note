namespace Student_Note
{
    partial class ProfileForm
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
            components = new System.ComponentModel.Container();
            buttonUser = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            label1 = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblSecondName = new Label();
            lblGender = new Label();
            lblBirthdate = new Label();
            lblRegDate = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblMemberType = new Label();
            lblGroups = new Label();
            lblSelectedGroup = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBoxGroups = new ComboBox();
            SuspendLayout();
            // 
            // buttonUser
            // 
            buttonUser.ContextMenuStrip = contextMenuStrip1;
            buttonUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUser.Location = new Point(473, 12);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(315, 54);
            buttonUser.TabIndex = 3;
            buttonUser.Text = "Войдите в аккаунт";
            buttonUser.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(419, 12);
            button1.Name = "button1";
            button1.Size = new Size(315, 54);
            button1.TabIndex = 4;
            button1.Text = "Войдите в аккаунт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(52, 199, 89);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(100, 0, 0, 0);
            label1.Size = new Size(800, 80);
            label1.TabIndex = 5;
            label1.Text = "Профиль";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 96);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(73, 20);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Фамилия";
            lblLastName.Click += label2_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 116);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(39, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Имя";
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(12, 136);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(72, 20);
            lblSecondName.TabIndex = 8;
            lblSecondName.Text = "Отчество";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(12, 156);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(37, 20);
            lblGender.TabIndex = 9;
            lblGender.Text = "Пол";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Location = new Point(12, 176);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(119, 20);
            lblBirthdate.TabIndex = 10;
            lblBirthdate.Text = "День рождения";
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Location = new Point(12, 196);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(134, 20);
            lblRegDate.TabIndex = 11;
            lblRegDate.Text = "Дата регистарции";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 236);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(127, 20);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Номер телефона";
            // 
            // lblMemberType
            // 
            lblMemberType.AutoSize = true;
            lblMemberType.Location = new Point(12, 256);
            lblMemberType.Name = "lblMemberType";
            lblMemberType.Size = new Size(52, 20);
            lblMemberType.TabIndex = 14;
            lblMemberType.Text = "Статус";
            // 
            // lblGroups
            // 
            lblGroups.AutoSize = true;
            lblGroups.Location = new Point(12, 276);
            lblGroups.Name = "lblGroups";
            lblGroups.Size = new Size(95, 20);
            lblGroups.TabIndex = 15;
            lblGroups.Text = "Мои группы";
            // 
            // lblSelectedGroup
            // 
            lblSelectedGroup.AutoSize = true;
            lblSelectedGroup.Location = new Point(12, 296);
            lblSelectedGroup.Name = "lblSelectedGroup";
            lblSelectedGroup.Size = new Size(156, 20);
            lblSelectedGroup.TabIndex = 16;
            lblSelectedGroup.Text = "Действующая группа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 116);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 136);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 156);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 176);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 196);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 216);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 23;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 236);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 24;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(169, 256);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 25;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 276);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 26;
            label11.Text = "label11";
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(169, 296);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(151, 28);
            comboBoxGroups.TabIndex = 28;
            comboBoxGroups.SelectedIndexChanged += comboBoxGroups_SelectedIndexChanged;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(comboBoxGroups);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSelectedGroup);
            Controls.Add(lblGroups);
            Controls.Add(lblMemberType);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblRegDate);
            Controls.Add(lblBirthdate);
            Controls.Add(lblGender);
            Controls.Add(lblSecondName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonUser);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUser;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Label label1;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblSecondName;
        private Label lblGender;
        private Label lblBirthdate;
        private Label lblRegDate;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblMemberType;
        private Label lblGroups;
        private Label lblSelectedGroup;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxGroups;
    }
}