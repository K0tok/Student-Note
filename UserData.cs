using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Student_Note
{
    public class UserData
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string? second_name { get; set; }
        public bool gender { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime reg_date { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public bool member_type { get; set; }
        //public List<string> Group { get; set; }
        public GroupData? selectGroup { get; set; }
        public List<GroupData> groups { get; set; }
        //public List<string> Codes { get; set; }
        /// <summary>
        /// id, last_name, first_name, second_name, sex, birthdate, reg_date, email, phone_number, member_type
        /// Конструктор
        /// </summary>
        public UserData(
            string id,
            string last_name,
            string first_name,
            string? second_name,
            string gender,
            string birthdate,
            string reg_date,
            string email,
            string phone_number,
            string member_type
            )
        {
            try
            {
                this.id = int.Parse(id);
                this.last_name = last_name;
                this.first_name = first_name;
                this.second_name = second_name;
                this.gender = gender == "1";
                this.birthdate = DateTime.Parse(birthdate);
                this.reg_date = DateTime.Parse(reg_date);
                this.email = email;
                this.phone_number = phone_number;
                this.member_type = member_type == "1";
                //this.Group = GetGroups(this.id)[0];
                //this.Codes = GetGroups(this.id)[1];
                this.groups = GetGroups(this.id);
                this.selectGroup = groups.Count() > 0 ? groups[0] : null;
            }
            catch
            { MessageBox.Show("Ошибка в получении данных пользователя"); }

        }

        public static List<GroupData> GetGroups(int UserID)
        {
            List<GroupData> groupDatas = new List<GroupData>();

            List<string> Groups = new List<string>();

            List<string> Codes = new List<string>();

            string Query = @"SELECT G.id, code_name, specialization_id, code From Groups AS G
	            INNER JOIN users_in_groups AS U_I_G ON U_I_G.group_id=G.id
	            INNER JOIN Users AS U ON U.id=U_I_G.user_id
	            WHERE U.id = @id";

            // Путь к базе данных
            string connectionString = $"Data Source={Program.fullPath}";

            try
            {
                using SqliteConnection connection = new SqliteConnection(connectionString);
                connection.Open();

                using SqliteCommand cmd = new SqliteCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Добавление параметров для защиты от SQL-инъекций
                cmd.Parameters.AddWithValue("@id", UserID);

                // Создание запрроса на получение списка групп пользователя
                cmd.CommandText = Query;

                // Выполнение запроса
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groupDatas.Add(new GroupData(reader["id"].ToString(), reader["code_name"].ToString(), 
                           reader["specialization_id"].ToString(), reader["code"].ToString()));
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }

            return groupDatas;
        }
    }
    public class GroupData
    {
        public int id { get; set; }
        public string code_name { get; set; }
        public int specialization_id { get; set; }
        public string code { get; set; }

        public GroupData(string id, string code_name, string specialization_id, string code)
        {
            try 
            { 
                this.id = int.Parse(id);
                this.code_name = code_name;
                this.specialization_id = int.Parse(specialization_id);
                this.code = code;
            }
            catch
            {
                MessageBox.Show("Ошибка в получении данных группы");
            }
        }
    }
}
