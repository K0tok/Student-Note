using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Note
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            UserData _userData = Program.userData;
            // Если при загрузки формы нет данных пользователя, то мы возращаем в Login Form
            if (_userData == null) { Program.ReplaceForm(Program.LogInForm, this); return; }
            else
            {
                // Отрисовка имени пользователя в кнопке
                if (_userData.second_name != "" && _userData.second_name != null)
                    button1.Text = _userData.last_name + " " + _userData.first_name.First() + "." + _userData.second_name.First() + ".";
                else
                    button1.Text = _userData.last_name + " " + _userData.first_name;

                // Инициализация ContextMenuStrip для выпадающего списка для старосты и обычного студента
                contextMenuStrip1.Items.Add("Открыть расписание", null, (s, e) => { Program.MainHomeworkForm = new MainHomeworkForm(); Program.ReplaceForm(Program.MainHomeworkForm, this); });
                contextMenuStrip1.Items.Add("Уведомления", null, (s, e) => MessageBox.Show("Открыты уведомления"));
                if (_userData.member_type) // Дополнительные менюшки для старосты
                {
                    contextMenuStrip1.Items.Add("Группа", null, (s, e) => MessageBox.Show("Показаны участники группы"));
                    contextMenuStrip1.Items.Add("Добавить объявление", null, (s, e) => MessageBox.Show("Открыта форма добавления уведомления"));
                }
                contextMenuStrip1.Items.Add("Настройки", null, (s, e) => Program.ReplaceForm(Program.SettingsForm, this));
                contextMenuStrip1.Items.Add("Выйти", null, (s, e) => Application.Exit());
            }


            label2.Text = _userData.last_name;
            label3.Text = _userData.first_name;
            label4.Text = _userData.second_name ?? "-";
            label5.Text = _userData.gender ? "Male" : "Female";
            label6.Text = _userData.birthdate.ToShortDateString();
            label7.Text = _userData.reg_date.ToShortDateString();
            label8.Text = _userData.email;
            label9.Text = _userData.phone_number;
            label10.Text = _userData.member_type ? "Староста" : "Студент";

            List<string> groups = new List<string>();
            foreach (var group in _userData.groups)
            {
                groups.Add(group.code_name);
            }
            label11.Text = string.Join(", ", groups) ?? "Нет групп";
            comboBoxGroups.DataSource = groups;

            comboBoxGroups.Text = _userData.selectGroup.code_name ?? "Нет групп";
            label12.Text = string.Join(", ", _userData.groups) ?? "Нет инвайт-кодов";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Показать меню рядом с кнопкой
            contextMenuStrip1.Show(buttonUser, new Point(0, buttonUser.Height));
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.userData == null) return;
            foreach (var group in Program.userData.groups) 
            {
                if (group.code_name == comboBoxGroups.Text)
                {
                    Program.userData.selectGroup = group;
                }
            }
        }
    }
}