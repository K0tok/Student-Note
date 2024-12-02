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
            lblInviteCode = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // buttonUser
            // 
            buttonUser.ContextMenuStrip = contextMenuStrip1;
            buttonUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUser.Location = new Point(414, 9);
            buttonUser.Margin = new Padding(3, 2, 3, 2);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(276, 40);
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
            button1.Location = new Point(367, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(276, 40);
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
            label1.Padding = new Padding(88, 0, 0, 0);
            label1.Size = new Size(700, 60);
            label1.TabIndex = 5;
            label1.Text = "Профиль";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(10, 72);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(58, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Фамилия";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(10, 87);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(31, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Имя";
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(10, 102);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(58, 15);
            lblSecondName.TabIndex = 8;
            lblSecondName.Text = "Отчество";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(10, 117);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(30, 15);
            lblGender.TabIndex = 9;
            lblGender.Text = "Пол";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Location = new Point(10, 132);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(92, 15);
            lblBirthdate.TabIndex = 10;
            lblBirthdate.Text = "День рождения";
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Location = new Point(10, 147);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(105, 15);
            lblRegDate.TabIndex = 11;
            lblRegDate.Text = "Дата регистрации";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(10, 177);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(101, 15);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Номер телефона";
            // 
            // lblMemberType
            // 
            lblMemberType.AutoSize = true;
            lblMemberType.Location = new Point(10, 192);
            lblMemberType.Name = "lblMemberType";
            lblMemberType.Size = new Size(43, 15);
            lblMemberType.TabIndex = 14;
            lblMemberType.Text = "Статус";
            // 
            // lblGroups
            // 
            lblGroups.AutoSize = true;
            lblGroups.Location = new Point(10, 207);
            lblGroups.Name = "lblGroups";
            lblGroups.Size = new Size(76, 15);
            lblGroups.TabIndex = 15;
            lblGroups.Text = "Мои группы";
            // 
            // lblSelectedGroup
            // 
            lblSelectedGroup.AutoSize = true;
            lblSelectedGroup.Location = new Point(10, 222);
            lblSelectedGroup.Name = "lblSelectedGroup";
            lblSelectedGroup.Size = new Size(125, 15);
            lblSelectedGroup.TabIndex = 16;
            lblSelectedGroup.Text = "Действующая группа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 72);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 102);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 117);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 132);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 147);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 22;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(148, 162);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 23;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 177);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 24;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(148, 192);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 25;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 207);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 26;
            label11.Text = "label11";
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(148, 222);
            comboBoxGroups.Margin = new Padding(3, 2, 3, 2);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(133, 23);
            comboBoxGroups.TabIndex = 28;
            comboBoxGroups.SelectedIndexChanged += comboBoxGroups_SelectedIndexChanged;
            // 
            // lblInviteCode
            // 
            lblInviteCode.AutoSize = true;
            lblInviteCode.Location = new Point(10, 245);
            lblInviteCode.Name = "lblInviteCode";
            lblInviteCode.Size = new Size(115, 15);
            lblInviteCode.TabIndex = 29;
            lblInviteCode.Text = "Инвайт-коды групп";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(148, 245);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 30;
            label12.Text = "label12";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 492);
            Controls.Add(label12);
            Controls.Add(lblInviteCode);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblInviteCode;
        private Label label12;
    }
}