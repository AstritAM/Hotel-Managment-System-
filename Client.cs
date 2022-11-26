using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Client
        
    {
  
        DataBase dataBase = new DataBase();
        public bool inClient(String fname, String lname, String pname, int age, int passport, String country)
        {
            if (age >= 18)
            {
                MySqlCommand command = new MySqlCommand();
                String innsertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `patronymic`, `age`, `passport`, `country`) VALUES (@fn,@ln,@pn,@age,@psprt,@cnr)";
                command.CommandText = innsertQuery;
                command.Connection = dataBase.getConnection();
                //@fn,@ln,@pn,@age,@psprt,@cnr
                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pname;
                command.Parameters.Add("@age", MySqlDbType.Int32).Value = age;
                command.Parameters.Add("@psprt", MySqlDbType.Int32).Value = passport;
                command.Parameters.Add("@cnr", MySqlDbType.VarChar).Value = country;

                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    dataBase.closeConnection();
                    return true;
                }
                else
                {
                    dataBase.closeConnection();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Невозможно зарегестрировать возраст < 18");
               
                return false;
            }
        }
 //функция для создания таблицы
        public DataTable getClientTabl()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", dataBase.getConnection()) ;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand=command;
            adapter.Fill(table);

            return table;

        }
    //изменить информацию о клиенте
    public bool editClient(int id, String fname, String lname, String pname, int age, int passport, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name`=@fn,`last_name`=@ln,`patronymic`=@pn,`age`=@age,`passport`=@psprt,`country`=@cnr WHERE `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = dataBase.getConnection();
            //@fn,@ln,@pn,@age,@psprt,@cnr]
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pname;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = age;
            command.Parameters.Add("@psprt", MySqlDbType.Int32).Value = passport;
            command.Parameters.Add("@cnr", MySqlDbType.VarChar).Value = country;

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }

        }


        public bool removeClient(int id)
        {
                 MySqlCommand command = new MySqlCommand();
            String removeQuery = " DELETE FROM `clients` WHERE `id` =@cid";
            command.CommandText = removeQuery;
            command.Connection = dataBase.getConnection();
            //@fn,@ln,@pn,@age,@psprt,@cnr]
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }

        }

    }

}
