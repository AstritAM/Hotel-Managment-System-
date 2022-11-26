using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace WindowsFormsApp1
{
    class Reservation
    {
        DataBase dataBase = new DataBase();
      

        public DataTable getReservTabl()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }

        
        

        public bool addReservetion(int number, int clientid, DateTime dateIn,DateTime dateOut )
        {

            MySqlCommand command = new MySqlCommand();
            String innsertQuery = "INSERT INTO `reservations`( `clientid`, `roomNumber`, `dateIn`, `dateOut`) VALUES (@cid, @rnum, @din,@dout)";
            command.CommandText = innsertQuery;
            command.Connection = dataBase.getConnection();
            //@cid, @rnum, @din,@dout
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientid;
            command.Parameters.Add("@rnum", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;
       

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
        public bool editReservetion(int reservId, int number, int clientid, DateTime dateIn, DateTime dateOut )
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `reservations` SET `clientid`=@cid,`roomNumber`=@rnum,`dateIn`=@din,`dateOut`= @dout WHERE `reservid`=@rid";
            command.CommandText = editQuery;
            command.Connection = dataBase.getConnection();
            //@cid, @rnum, @din,@dout
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientid;
            command.Parameters.Add("@rnum", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

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

        public bool removeReservetion(int resevid)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = " DELETE FROM `reservations` WHERE `reservid`=@rid";
            command.CommandText = removeQuery;
            command.Connection = dataBase.getConnection();
            //@fn,@ln,@pn,@age,@psprt,@cnr]
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = resevid;


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
            public bool removeReservetionDate(DateTime dataOut)
            {
                MySqlCommand command = new MySqlCommand();
                String removeQuery = " DELETE FROM `reservations` WHERE `dateOut`<@do";
                command.CommandText = removeQuery;
                command.Connection = dataBase.getConnection();
                //@fn,@ln,@pn,@age,@psprt,@cnr]
                command.Parameters.Add("@do", MySqlDbType.DateTime).Value = dataOut;


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
         //ALTER TABLE rooms add CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES rooms_type(category_id) on UPDATE CASCADE on DELETE CASCADE; 
        //ALTER TABLE rooms add CONSTRAINT fk_count_id FOREIGN KEY (count) REFERENCES count_client(category_id) on UPDATE CASCADE on DELETE CASCADE; 
    }//ALTER TABLE reservations add CONSTRAINT fk_room_number FOREIGN KEY (roomNumber) REFERENCES rooms(number) on UPDATE CASCADE on DELETE CASCADE; 
}//ALTER TABLE reservations add CONSTRAINT fk_client_id FOREIGN KEY (clientid) REFERENCES clients(id) on UPDATE CASCADE on DELETE CASCADE; 
