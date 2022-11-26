using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Rooms
    {

        DataBase dataBase = new DataBase();
       //comdoBox
        public DataTable roomType()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_type`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            return table;
        }
    
        public DataTable roomCount()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `count_clirnt`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            return table;
        }
        //comboBox номер коминаты
        public DataTable roomByTC(int type,int count)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `free`=@yes and `type`= @tpe AND `count`= @cnt ", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            //@tpe,@cnt
            command.Parameters.Add("@tpe", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@cnt", MySqlDbType.Int32).Value = count;
            command.Parameters.Add("@yes", MySqlDbType.VarChar).Value = "Yes";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //free  освобождение номера
        public bool roomByCNO(int number,string yorn)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET `free`=@NO WHERE `number`=@num", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            //@tpe,@cnt
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            
            command.Parameters.Add("@NO", MySqlDbType.VarChar).Value = yorn;

            dataBase.openConnection();
             
            if(command.ExecuteNonQuery() == 1)
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

        //для dataGraiv

        public int getType(int number)
        {

            MySqlCommand command = new MySqlCommand("SELECT `type` FROM `rooms` WHERE  `number`=@num", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
           // command.Parameters.Add("@yes", MySqlDbType.VarChar).Value = "Yes";
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }
        public int getnumid(int id)
        {

            MySqlCommand command = new MySqlCommand("SELECT `roomNumber` FROM `rooms` WHERE  `reservid`=@num", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = id;
            // command.Parameters.Add("@yes", MySqlDbType.VarChar).Value = "Yes";
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }
        
        
        public int getCount(int number)
        {

            MySqlCommand command = new MySqlCommand("SELECT `count` FROM `rooms` WHERE  `number`=@num", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            //command.Parameters.Add("@yes", MySqlDbType.VarChar).Value = "Yes";
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }


        public bool addRooms(int number, int type, int count, string phone, string free)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                String innsertQuery = "INSERT INTO `rooms`(`number`, `type`, `count`, `phone`, `free`) VALUES (@num,@tp,@cnt,@ph,@fr)";
                command.CommandText = innsertQuery;
                command.Connection = dataBase.getConnection();
                //@num,@tp,@cnt,@ph,@fr
                command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
                command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
                command.Parameters.Add("@cnt", MySqlDbType.Int32).Value = count;
                command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;


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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
         
        }

        public DataTable getRoomsTabl()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
        public bool editRoom(int number, int type, int count, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `rooms` SET `type`=@tp,`count`=@cnt,`phone`=@ph,`free`=@fr WHERE `number`=@num";
            command.CommandText = editQuery;
            command.Connection = dataBase.getConnection();
            //@fn,@ln,@pn,@age,@psprt,@cnr]
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@cnt", MySqlDbType.Int32).Value = count;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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


        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = " DELETE FROM `rooms` WHERE `number`=@num ";
            command.CommandText = removeQuery;
            command.Connection = dataBase.getConnection();
            //@fn,@ln,@pn,@age,@psprt,@cnr]
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;


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
