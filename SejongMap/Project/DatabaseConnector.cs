using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    public class DatabaseConnector
    {
        private string connectionString;

        public DatabaseConnector(string server, string database, string username, string password)
        {
            // SQL Server 연결 문자열 생성
            connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // 에러 처리
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
                return dataTable;
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // 에러 처리
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }
        }
    }
}
