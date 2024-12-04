using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Student_Note.Menu
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Показываем контекстное меню
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void Settings_Load(object sender, EventArgs e)
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
                contextMenuStrip1.Items.Add("Профиль", null, (s, e) => Program.ReplaceForm(Program.ProfileForm, this));  // Открытие профиля
                contextMenuStrip1.Items.Add("Уведомления", null, (s, e) => MessageBox.Show("Открыты уведомления"));
                if (_userData.member_type) // Дополнительные менюшки для старосты
                {
                    contextMenuStrip1.Items.Add("Группа", null, (s, e) => MessageBox.Show("Показаны участники группы"));
                    contextMenuStrip1.Items.Add("Добавить объявление", null, (s, e) => MessageBox.Show("Открыта форма добавления уведомления"));
                }
                contextMenuStrip1.Items.Add("Выйти", null, (s, e) => Application.Exit());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.userData == null) { Program.ReplaceForm(Program.LogInForm, this); return; };

            if (ScheduleLoader.AddUserInGroup(Program.userData.id, textCodeGroup.Text, this))
            {
                Program.MainHomeworkForm = new MainHomeworkForm();
                Program.ReplaceForm(Program.MainHomeworkForm, this);
            }
        }
    }
}
