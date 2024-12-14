using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Student_Note.Menu
{
    
    public partial class ShowUsersInGroupForm : Form
    {

        public ShowUsersInGroupForm()
        {
            InitializeComponent();
        }
        public static List<User> Users;
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            // Путь к базе данных
            string connectionString = $"Data Source={Program.fullPath}";
            string Query = @"SELECT U.id, U.last_name, U.first_name, U.second_name, U.sex, U.birthdate, U.reg_date, U.email, U.phone_number, U.member_type From Groups AS G
	            INNER JOIN users_in_groups AS U_I_G ON U_I_G.group_id=G.id
	            INNER JOIN Users AS U ON U.id=U_I_G.user_id
	            WHERE G.code = @code
            ";
            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                if (Program.userData == null) { Program.ReplaceForm(Program.LogInForm, this);               return users; }
                if (Program.userData.selectGroup == null) { Program.ReplaceForm(Program.LogInForm, this);   return users; }

                // Создание запрроса на получение списка групп пользователя
                cmd.CommandText = Query;

                // Добавление параметров для защиты от SQL-инъекций
                cmd.Parameters.AddWithValue("@code", Program.userData.selectGroup.code.ToString());

                // Выполнение запроса
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User( 
                            reader["last_name"].ToString(),     reader["first_name"].ToString(), 
                            reader["second_name"].ToString(),   reader["sex"].ToString(), 
                            reader["birthdate"].ToString(),     reader["reg_date"].ToString(), 
                            reader["email"].ToString(),         reader["phone_number"].ToString(), 
                            reader["member_type"].ToString(),   reader["last_name"].ToString()
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
            return users;

        }
        public void ShowUsers(List<User> users)
        {
         
            dataGridView1.DataSource = users;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Показываем контекстное меню
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }
        private void ShowUsersInGroupForm_Load(object sender, EventArgs e)
        {
            UserData _userData;
            // Если при загрузки формы нет данных пользователя, то мы возращаем в Login Form
            if (Program.userData == null) { Program.ReplaceForm(Program.LogInForm, this); return; }
            else
            {
                _userData = Program.userData;
                // Отрисовка имени пользователя в кнопке
                if (_userData.second_name != "" && _userData.second_name != null)
                    button1.Text = _userData.last_name + " " + _userData.first_name.First() + "." + _userData.second_name.First() + ".";
                else
                    button1.Text = _userData.last_name + " " + _userData.first_name;

                // Инициализация ContextMenuStrip для выпадающего списка для старосты и обычного студента
                contextMenuStrip1.Items.Add("Открыть расписание", null, (s, e) => { Program.MainHomeworkForm = new MainHomeworkForm(); Program.ReplaceForm(Program.MainHomeworkForm, this); });
                contextMenuStrip1.Items.Add("Профиль", null, (s, e) => Program.ReplaceForm(Program.ShowUsersInGroupForm, this));  // Открытие профиля
                contextMenuStrip1.Items.Add("Уведомления", null, (s, e) => MessageBox.Show("Открыты уведомления"));
                if (_userData.member_type) // Дополнительные менюшки для старосты
                {
                    contextMenuStrip1.Items.Add("Добавить объявление", null, (s, e) => MessageBox.Show("Открыта форма добавления уведомления"));
                }
                contextMenuStrip1.Items.Add("Настройки", null, (s, e) => Program.ReplaceForm(Program.SettingsForm, this));
                contextMenuStrip1.Items.Add("Выйти", null, (s, e) => Application.Exit());
            }
            Users = GetUsers();
            ShowUsers(Users);
        }
    }
}
