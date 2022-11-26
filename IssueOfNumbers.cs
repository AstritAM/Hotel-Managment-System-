using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IssueOfNumbers : Form
    {
        public IssueOfNumbers()
        {
            InitializeComponent();
        }

        Rooms rooms = new Rooms();
        Reservation reservation = new Reservation();


        private void buttonClearFR_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            tbidres.Text = "";
            comboBoxType.SelectedIndex = 0;
            comboBoxCount.SelectedIndex = 0;
            try
            {
                comboBoxNumR.SelectedIndex = 0;
            }
            catch (Exception) { }
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;

        }

        private void IssueOfNumbers_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = rooms.roomType();
            comboBoxType.DisplayMember = "rooms_type";
            comboBoxType.ValueMember = "category_id";
            comboBoxCount.DataSource = rooms.roomCount();
            comboBoxCount.DisplayMember = "count";
            comboBoxCount.ValueMember = "category_id";
            

           
            int type = int.Parse(comboBoxType.SelectedValue.ToString());
            int count = int.Parse(comboBoxCount.SelectedValue.ToString());
            comboBoxNumR.DataSource = rooms.roomByTC(type, count);
            comboBoxNumR.DisplayMember = "number";
            comboBoxNumR.ValueMember = "number";
           

            //try
            //{
            //    if (reservation.removeReservetionDate(DateTime.Now))
                
            //        rooms.roomByCNO(roomnum, "Yes");
                

            //}
            //catch (Exception) { }
            dataGridViewRooms.DataSource = reservation.getReservTabl();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int count = Convert.ToInt32(comboBoxCount.SelectedValue.ToString());
                comboBoxNumR.DataSource = rooms.roomByTC(type, count);
                comboBoxNumR.DisplayMember = "number";
                comboBoxNumR.ValueMember = "number";
            }
            catch (Exception) { }
        }

        private void comboBoxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int count = Convert.ToInt32(comboBoxCount.SelectedValue.ToString());
                comboBoxNumR.DataSource = rooms.roomByTC(type, count);
                comboBoxNumR.DisplayMember = "number";
                comboBoxNumR.ValueMember = "number";
            }
            catch (Exception) { }
        }

        private void buttonAddR_Click(object sender, EventArgs e)
        {
            try
            {
                //int number, int clientid, ,
                int clientid = int.Parse(tbid.Text);
                int number = int.Parse(comboBoxNumR.SelectedValue.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn == DateTime.Now)
                {
                    MessageBox.Show("Невозможно выбрать эту дату въезда");
                }
                else if (dateIn > dateOut)
                {
                    MessageBox.Show("Невозможно выбрать эту дату выезда");
                }
                else
                {
                    if (reservation.addReservetion(number, clientid, dateIn, dateOut))
                    {
                        dataGridViewRooms.DataSource = reservation.getReservTabl();
                        rooms.roomByCNO(number,"No");
                        MessageBox.Show("Номер зарезервирован");
                        buttonClearFR.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Номер не зарезервирован");
                    }
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEditR_Click(object sender, EventArgs e)
        {
            try
            {
                //int number, int clientid, ,
                int reservid = int.Parse(tbidres.Text);
                int clientid = int.Parse(tbid.Text);
                int number = Convert.ToInt32(dataGridViewRooms.CurrentRow.Cells[2].Value.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn >= DateTime.Now)
                {
                    MessageBox.Show("Невозможно выбрать эту дату въезда");
                }
                else if (dateIn < dateOut)
                {
                    MessageBox.Show("Невозможно выбрать эту дату выезда");
                }
                else
                {
                    if (reservation.editReservetion(reservid,number, clientid, dateIn, dateOut))
                    {
                        dataGridViewRooms.DataSource = reservation.getReservTabl();
                        rooms.roomByCNO(number,"No");
                        MessageBox.Show("Данные о резервирование изменены");
                    }
                    else
                    {
                        MessageBox.Show("Данные о резервирование изменены");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidres.Text = dataGridViewRooms.CurrentRow.Cells[0].Value.ToString();
                tbid.Text = dataGridViewRooms.CurrentRow.Cells[1].Value.ToString();
                int roomnum = Convert.ToInt32(dataGridViewRooms.CurrentRow.Cells[2].Value.ToString());
                comboBoxType.SelectedValue = rooms.getType(roomnum);
                comboBoxCount.SelectedValue = rooms.getCount(roomnum);
                comboBoxNumR.SelectedValue = roomnum;
                dateTimePickerIN.Value = Convert.ToDateTime(dataGridViewRooms.CurrentRow.Cells[3].Value);
                dateTimePickerOUT.Value = Convert.ToDateTime(dataGridViewRooms.CurrentRow.Cells[4].Value);
            }

            //    //if (reservation.removeReservetionDate(DateTime.Now))
            //    {
            //        rooms.roomByCNO(roomnum, "Yes");
            //        MessageBox.Show("да");

            //    }
            //    else
            //    {
            //        MessageBox.Show("ytn");
            //    }
            //}
            catch (Exception) { }

        }
  
        private void buttonRemoveR_Click(object sender, EventArgs e)
        {

            try
            {
                int reservid = int.Parse(tbidres.Text);
                   int number = Convert.ToInt32(dataGridViewRooms.CurrentRow.Cells[2].Value.ToString());
                if (reservation.removeReservetion(reservid))
                {
                    dataGridViewRooms.DataSource = reservation.getReservTabl();
                    rooms.roomByCNO(number, "Yes");
                    MessageBox.Show("Данные о резервирование удалены");
                    buttonClearFR.PerformClick();
                }
                else
                {
                    MessageBox.Show("Данные о резервирование не удалены");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BackToMain2_Click(object sender, EventArgs e)
        {
            
           
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
        
        }
        

      private void BackToMain2_MouseEnter_1(object sender, EventArgs e)
        {
           BackToMain2.ForeColor = Color.White;
        }

        private void BackToMain2_MouseLeave_1(object sender, EventArgs e)
        {
            BackToMain2.ForeColor = Color.Black;
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

        //ALTER TABLE rooms add CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES rooms_type(category_id) on UPDATE CASCADE on DELETE CASCADE; 
        //ALTER TABLE rooms add CONSTRAINT fk_count_id FOREIGN KEY (count) REFERENCES count_client(category_id) on UPDATE CASCADE on DELETE CASCADE; 
    //ALTER TABLE reservations add CONSTRAINT fk_room_number FOREIGN KEY (roomNumber) REFERENCES rooms(number) on UPDATE CASCADE on DELETE CASCADE; 
//ALTER TABLE reservations add CONSTRAINT fk_client_id FOREIGN KEY (clientid) REFERENCES clients(id) on UPDATE CASCADE on DELETE CASCADE; 
