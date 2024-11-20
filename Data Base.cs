﻿using Microsoft.Data.Sqlite;
using System.Collections.Generic;
public class ResponseMesaage
{
    public int Status { get; set; }
    public string Message { get; set; }

    public ResponseMesaage(int Status, string Message)
    {
        this.Status = Status;
        this.Message = Message;
    }
}
public class Data_Base
{
    // Подкючение к бд
    public static SqliteConnection sqliteConnect;
    // открытие подключения
    public static void DBConnectionOpen()
    {
        string connectionString = "DataSource=Student Note.db";
        sqliteConnect = new SqliteConnection(connectionString);
        try
        {
            sqliteConnect.Open();
            MessageBox.Show("Подключение установлено!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка подключения: " + ex.Message);
        }
    }
    // Закрытие подключения 
    public static void DBConnectionClose()
    {
        if (sqliteConnect != null && sqliteConnect.State == System.Data.ConnectionState.Open)
        {
            sqliteConnect.Close();
            MessageBox.Show("Соединение закрыто.");
        }
    }

    // Для запросов типа INSERT, UPDATE, DELETE
    public static ResponseMesaage ExecuteNonQueryInDB(string query, params object[] parameters)
    {
        if (sqliteConnect == null || sqliteConnect.State != System.Data.ConnectionState.Open)
        {
            return new ResponseMesaage(500, "Подключение к базе данных не открыто.");
        }

        try
        {
            using (var command = sqliteConnect.CreateCommand())
            {
                command.CommandText = query;

                // Добавление параметров
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", parameters[i] ?? DBNull.Value);
                }

                int rowsAffected = command.ExecuteNonQuery();
                return new ResponseMesaage(200, $"Успешно выполнено. Затронуто строк: {rowsAffected}.");
            }
        }
        catch (Exception ex)
        {
            return new ResponseMesaage(500, $"Ошибка выполнения запроса: {ex.Message}");
        }
    }

    // Для запросов SELECT
    public static ResponseMesaage ExecuteQueryInDB(string query, out List<Dictionary<string, object>> result, params object[] parameters)
    {
        result = new List<Dictionary<string, object>>();

        if (sqliteConnect == null || sqliteConnect.State != System.Data.ConnectionState.Open)
        {
            return new ResponseMesaage(500, "Подключение к базе данных не открыто.");
        }

        try
        {
            using (var command = sqliteConnect.CreateCommand())
            {
                command.CommandText = query;

                // Добавление параметров
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", parameters[i] ?? DBNull.Value);
                }

                using (var reader = command.ExecuteReader())
                {
                    // Чтение результата запроса
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        result.Add(row);
                    }
                }

                return new ResponseMesaage(200, $"Запрос успешно выполнен. Найдено строк: {result.Count}.");
            }
        }
        catch (Exception ex)
        {
            return new ResponseMesaage(500, $"Ошибка выполнения запроса: {ex.Message}");
        }
    }
}
