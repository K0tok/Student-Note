using System.Data;
using Microsoft.Data.Sqlite;

namespace Student_Note
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
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
                string RandomCode = Server.GenerateRandomCode();

                // Добавление параметров для защиты от SQL-инъекций
                cmd.Parameters.AddWithValue("@code_name", ComboBoxNames.Text);
                cmd.Parameters.AddWithValue("@long_name", GroupSpeNames.Text);
                cmd.Parameters.AddWithValue("@code", RandomCode);

                // Получаем группы
                cmd.CommandText = "INSERT INTO 'Groups' (code_name, specialization_id, code) VALUES (@code_name, (SELECT id FROM 'Specializations' WHERE long_name=@long_name), @code)";
                int countRows = cmd.ExecuteNonQuery();

                // Проверка на ответ 
                if (countRows == 1)
                {
                    CopyableMessageBox.Show(RandomCode, "Группа создана \n Нажмите на код чтобы сохранить его");
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
            Program.ReplaceForm(Program.MainForm, this);
        }

        /// <summary>
        /// Список специальностей  
        /// </summary>
        public static List<string> GroupSpecializationNames = new();
        /// <summary>
        /// Список возможных групп
        /// </summary>
        public static List<string> GroupNames = new();
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

        private async void AddGroupForm_Load(object sender, EventArgs e)
        {
            GetSpecializationGroups();
            GroupSpeNames.DataSource = GroupSpecializationNames;

            try
            {
                ScheduleLoader _scheduleLoader = MainForm._scheduleLoader;
                // Загружаем расписание
                await _scheduleLoader.GetScheduleAsync();
                foreach (var item in _scheduleLoader.CurrentSchedule.Groups)
                {
                    GroupNames.Add(item.Key);
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка в получении списка возможных групп");
            }
             ComboBoxNames.DataSource = GroupNames;

        }

        
        public class CopyableMessageBox : Form
        {   /// <summary>
            /// Форма для вывода Meassge для копирования в буфер обмена
            /// </summary>
            public CopyableMessageBox(string message, string data)
            {
                // Настройки формы
                this.Text = "Message";
                this.Size = new Size(400, 200);
                this.StartPosition = FormStartPosition.CenterScreen;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                // Label для текста
                Label messageLabel = new Label
                {
                    Text = message,
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12),
                    ForeColor = Color.Blue,
                    Cursor = Cursors.Hand
                };

                // Добавляем обработчик клика
                messageLabel.Click += (sender, e) =>
                {
                    Clipboard.SetText(message);
                    MessageBox.Show("Текст скопирован в буфер обмена!", "Копирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                // Добавляем Label на форму
                this.Controls.Add(messageLabel);

                // Кнопка закрытия
                Button closeButton = new Button
                {
                    Text = data,
                    Dock = DockStyle.Bottom,
                    Height = 40
                };

                closeButton.Click += (sender, e) => this.Close();

                this.Controls.Add(closeButton);
            }
            /// <summary>
            /// Функия для показа формы с возможностью копирования в буфер обмена 
            /// </summary>
            /// <param name="message"></param>
            /// <param name="data"></param>
            public static void Show(string message, string data)
            {
                using (CopyableMessageBox form = new CopyableMessageBox(message, data))
                {
                    form.ShowDialog();
                }
            }
        }

    }
}
