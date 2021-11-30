using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO
{
    public class ADOConnection
    {
        public void Connection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=usersdb;Integrated Security=True";
            string sql = "SELECT * FROM Users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                
            }
        }
    }
}
