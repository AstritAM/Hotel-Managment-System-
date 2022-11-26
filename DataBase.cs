using MySql.Data.MySqlClient;
using System;


namespace WindowsFormsApp1
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("host=localhost;port=3306;user=root;password=root;database=mydatabase");
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();

            }
        }

    }
}
