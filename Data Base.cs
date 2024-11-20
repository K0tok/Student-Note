using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Data.Sqlite;
using System.Data;

namespace Student_Note
{
    public class Data_Base
    {
        public static SqliteConnection sqliteConnect;

        public static void DBConnection()
        {
            // Путь к БД
            string connectionString = "DataSource=Student Note.db";

            // Создание подключения
            sqliteConnect = new SqliteConnection(connectionString);

            try
            {
                // Открытие подключения
                sqliteConnect.Open();
                MessageBox.Show("Подключение установлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }
    }
}
