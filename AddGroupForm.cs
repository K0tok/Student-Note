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

namespace Student_Note
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
            GetGroups();
            selectGroups.DataSource = GroupNames;
        }
        public static List<string> GroupNames = new List<string>{};
        static void GetGroups()
        {
            // Путь к базе данных
            string connectionString = $"Data Source=" + "Student Note.db";

            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Получаем группы
                cmd.CommandText = "SELECT code_name FROM 'Groups'";
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            GroupNames.Add(reader.GetString(0));
                        }
                    }
                }

                if (GroupNames.Count < 1)
                    MessageBox.Show("Ошибка в получении списка групп");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
