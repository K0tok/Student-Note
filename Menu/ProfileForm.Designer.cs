using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Note
{
    public partial class ProfileForm : Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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

            SuspendLayout();

            // buttonUser
            buttonUser.ContextMenuStrip = contextMenuStrip1;
            buttonUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUser.Location = new Point(414, 9);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(315, 53);
            buttonUser.TabIndex = 3;
            buttonUser.Text = "Войдите в аккаунт";
            buttonUser.UseVisualStyleBackColor = true;

            // contextMenuStrip1
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);

            // button1
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(679, 13);
            button1.Size = new Size(276, 40);
            button1.TabIndex = 4;
            button1.Text = "Войдите в аккаунт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // label1
            label1.BackColor = Color.FromArgb(52, 199, 89);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Padding = new Padding(101, 0, 0, 0);
            label1.Size = new Size(1007, 80);
            label1.TabIndex = 5;
            label1.Text = "Профиль";
            label1.TextAlign = ContentAlignment.MiddleLeft;

            // lblLastName
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 96);
            lblLastName.Size = new Size(246, 47);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Фамилия";

            // lblFirstName
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Font = new Font("Arial", 18F);
            lblFirstName.Location = new Point(3, 47);
            lblFirstName.Size = new Size(246, 47);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Имя";

            // lblSecondName
            lblSecondName.Dock = DockStyle.Fill;
            lblSecondName.Font = new Font("Arial", 18F);
            lblSecondName.Location = new Point(3, 94);
            lblSecondName.Size = new Size(246, 47);
            lblSecondName.TabIndex = 8;
            lblSecondName.Text = "Отчество";

            // lblGender
            lblGender.Dock = DockStyle.Fill;
            lblGender.Font = new Font("Arial", 18F);
            lblGender.Location = new Point(3, 141);
            lblGender.Size = new Size(246, 47);
            lblGender.TabIndex = 9;
            lblGender.Text = "Пол";

            // lblBirthdate
            lblBirthdate.Dock = DockStyle.Fill;
            lblBirthdate.Font = new Font("Arial", 18F);
            lblBirthdate.Location = new Point(3, 188);
            lblBirthdate.Size = new Size(246, 47);
            lblBirthdate.TabIndex = 10;
            lblBirthdate.Text = "День рождения";

            // tableLayoutPanel1
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.RowCount = 11;

            // ProfileForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1007, 769);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(2169, 918);
            MinimumSize = new Size(908, 816);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        private ComboBox comboBoxGroups;
        private Button buttonUser;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Label label1, lblLastName, lblFirstName, lblSecondName, lblGender, lblBirthdate;
        private Label lblRegDate, lblEmail, lblPhoneNumber, lblMemberType, lblGroups, lblSelectedGroup;
        private Label label2, label3, label4, label5, label6, label7, label8, label9, label10, label11;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
