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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
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
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(444, 10);
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
            label1.Size = new Size(731, 60);
            label1.TabIndex = 5;
            label1.Text = "Профиль";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Font = new Font("Arial", 18F);
            lblLastName.Location = new Point(3, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(246, 47);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Фамилия";
            lblLastName.TextAlign = ContentAlignment.MiddleRight;
            lblLastName.Click += label2_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Font = new Font("Arial", 18F);
            lblFirstName.Location = new Point(3, 47);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(246, 47);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Имя";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Dock = DockStyle.Fill;
            lblSecondName.Font = new Font("Arial", 18F);
            lblSecondName.Location = new Point(3, 94);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(246, 47);
            lblSecondName.TabIndex = 8;
            lblSecondName.Text = "Отчество";
            lblSecondName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Dock = DockStyle.Fill;
            lblGender.Font = new Font("Arial", 18F);
            lblGender.Location = new Point(3, 141);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(246, 47);
            lblGender.TabIndex = 9;
            lblGender.Text = "Пол";
            lblGender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Dock = DockStyle.Fill;
            lblBirthdate.Font = new Font("Arial", 18F);
            lblBirthdate.Location = new Point(3, 188);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(246, 47);
            lblBirthdate.TabIndex = 10;
            lblBirthdate.Text = "День рождения";
            lblBirthdate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Dock = DockStyle.Fill;
            lblRegDate.Font = new Font("Arial", 18F);
            lblRegDate.Location = new Point(3, 235);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(246, 47);
            lblRegDate.TabIndex = 11;
            lblRegDate.Text = "Дата регистарции";
            lblRegDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Arial", 18F);
            lblEmail.Location = new Point(3, 282);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(246, 47);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Dock = DockStyle.Fill;
            lblPhoneNumber.Font = new Font("Arial", 18F);
            lblPhoneNumber.Location = new Point(3, 329);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(246, 47);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Номер телефона";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMemberType
            // 
            lblMemberType.AutoSize = true;
            lblMemberType.Dock = DockStyle.Fill;
            lblMemberType.Font = new Font("Arial", 18F);
            lblMemberType.Location = new Point(3, 376);
            lblMemberType.Name = "lblMemberType";
            lblMemberType.Size = new Size(246, 47);
            lblMemberType.TabIndex = 14;
            lblMemberType.Text = "Статус";
            lblMemberType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGroups
            // 
            lblGroups.AutoSize = true;
            lblGroups.Dock = DockStyle.Fill;
            lblGroups.Font = new Font("Arial", 18F);
            lblGroups.Location = new Point(3, 423);
            lblGroups.Name = "lblGroups";
            lblGroups.Size = new Size(246, 47);
            lblGroups.TabIndex = 15;
            lblGroups.Text = "Мои группы";
            lblGroups.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSelectedGroup
            // 
            lblSelectedGroup.AutoSize = true;
            lblSelectedGroup.Dock = DockStyle.Fill;
            lblSelectedGroup.Font = new Font("Arial", 18F);
            lblSelectedGroup.Location = new Point(3, 470);
            lblSelectedGroup.Name = "lblSelectedGroup";
            lblSelectedGroup.Size = new Size(246, 55);
            lblSelectedGroup.TabIndex = 16;
            lblSelectedGroup.Text = "Действующая группа";
            lblSelectedGroup.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(252, 10);
            label2.Margin = new Padding(0, 10, 0, 10);
            label2.Name = "label2";
            label2.Size = new Size(479, 27);
            label2.TabIndex = 17;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial", 18F);
            label3.Location = new Point(252, 57);
            label3.Margin = new Padding(0, 10, 0, 10);
            label3.Name = "label3";
            label3.Size = new Size(479, 27);
            label3.TabIndex = 18;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(252, 104);
            label4.Margin = new Padding(0, 10, 0, 10);
            label4.Name = "label4";
            label4.Size = new Size(479, 27);
            label4.TabIndex = 19;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Arial", 18F);
            label5.Location = new Point(252, 151);
            label5.Margin = new Padding(0, 10, 0, 10);
            label5.Name = "label5";
            label5.Size = new Size(479, 27);
            label5.TabIndex = 20;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial", 18F);
            label6.Location = new Point(252, 198);
            label6.Margin = new Padding(0, 10, 0, 10);
            label6.Name = "label6";
            label6.Size = new Size(479, 27);
            label6.TabIndex = 21;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Arial", 18F);
            label7.Location = new Point(252, 245);
            label7.Margin = new Padding(0, 10, 0, 10);
            label7.Name = "label7";
            label7.Size = new Size(479, 27);
            label7.TabIndex = 22;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Arial", 18F);
            label8.Location = new Point(252, 292);
            label8.Margin = new Padding(0, 10, 0, 10);
            label8.Name = "label8";
            label8.Size = new Size(479, 27);
            label8.TabIndex = 23;
            label8.Text = "label8";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Arial", 18F);
            label9.Location = new Point(252, 339);
            label9.Margin = new Padding(0, 10, 0, 10);
            label9.Name = "label9";
            label9.Size = new Size(479, 27);
            label9.TabIndex = 24;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Arial", 18F);
            label10.Location = new Point(252, 386);
            label10.Margin = new Padding(0, 10, 0, 10);
            label10.Name = "label10";
            label10.Size = new Size(479, 27);
            label10.TabIndex = 25;
            label10.Text = "label10";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Arial", 18F);
            label11.Location = new Point(252, 433);
            label11.Margin = new Padding(0, 10, 0, 10);
            label11.Name = "label11";
            label11.Size = new Size(479, 27);
            label11.TabIndex = 26;
            label11.Text = "label11";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGroups.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(252, 480);
            comboBoxGroups.Margin = new Padding(0, 10, 0, 10);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(479, 35);
            comboBoxGroups.TabIndex = 28;
            comboBoxGroups.SelectedIndexChanged += comboBoxGroups_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblLastName, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxGroups, 1, 10);
            tableLayoutPanel1.Controls.Add(lblFirstName, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSelectedGroup, 0, 10);
            tableLayoutPanel1.Controls.Add(label11, 1, 9);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 1, 8);
            tableLayoutPanel1.Controls.Add(lblGroups, 0, 9);
            tableLayoutPanel1.Controls.Add(lblSecondName, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 1, 7);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(lblMemberType, 0, 8);
            tableLayoutPanel1.Controls.Add(label8, 1, 6);
            tableLayoutPanel1.Controls.Add(lblGender, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 1, 5);
            tableLayoutPanel1.Controls.Add(lblPhoneNumber, 0, 7);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(lblBirthdate, 0, 4);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 6);
            tableLayoutPanel1.Controls.Add(lblRegDate, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(731, 525);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(731, 585);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonUser);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1900, 624);
            MinimumSize = new Size(747, 624);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}