using System.Data;
using Microsoft.Data.Sqlite;

namespace Student_Note
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
            GetSpecializationGroups();
            GroupSpeNames.DataSource = GroupSpecializationNames;
        }
        private void CreateGroup_Click(object sender, EventArgs e)
        {
            //GetGroups();
            //if (!GroupNames.Contains(TextBoxNameGroup.Text))
            //{
            //    MessageBox.Show("Creating group...");
            //}
            //else { MessageBox.Show("Такая группа уже существует "); }

            // Путь к базе данных
            string connectionString = $"Data Source=Student Note.db";

            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;


                // Добавление параметров для защиты от SQL-инъекций
                cmd.Parameters.AddWithValue("@code_name", TextBoxNameGroup.Text);
                cmd.Parameters.AddWithValue("@long_name", GroupSpeNames.Text);

                // Получаем группы
                cmd.CommandText = "INSERT INTO 'Groups' (code_name, specialization_id) VALUES (@code_name, (SELECT id FROM 'Specializations' WHERE long_name=@long_name))";
                int countRows = cmd.ExecuteNonQuery();

                // Проверка на ответ 
                if (countRows == 1)
                {
                    MessageBox.Show("Группа создана");
                    Program.ReplaceForm(Program.MainForm, this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }


        }
        private void CenselCreateGroup_Click(object sender, EventArgs e)
        {

        }











        /// <summary>
        /// Список специальностей  
        /// </summary>
        public static List<string> GroupSpecializationNames = new List<string> { };
        /// <summary>
        /// Получение списка специальностей  
        /// </summary>
        static void GetSpecializationGroups()
        {
            // Путь к базе данных
            string connectionString = $"Data Source=Student Note.db";

            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Получаем группы
                cmd.CommandText = "SELECT long_name FROM 'Specializations'";
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            GroupSpecializationNames.Add(reader.GetString(0));
                        }
                    }
                }

                if (GroupSpecializationNames.Count < 1)
                    MessageBox.Show("Ошибка в получении списка групп");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
        }
    }
}
