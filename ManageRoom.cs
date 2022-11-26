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
    public partial class ManageRoom : Form
    {
        public ManageRoom()
        {
            InitializeComponent();
        }

        Rooms rooms = new Rooms();
        private void ManageRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = rooms.roomType();
            comboBoxType.DisplayMember = "rooms_type";
            comboBoxType.ValueMember = "category_id";
            comboBoxCount.DataSource = rooms.roomCount();
            comboBoxCount.DisplayMember = "count";
            comboBoxCount.ValueMember = "category_id";
            dataGridViewRooms.DataSource = rooms.getRoomsTabl();
        }

        private void buttonAddR_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbid.Text);
            int type = int.Parse(comboBoxType.SelectedValue.ToString());
            int count= int.Parse(comboBoxCount.SelectedValue.ToString());
            string phone = tbPhone.Text;
            string free="";


            if (radioButYes.Checked)
            {
                free = "Yes";
            }
            else
            {
                free = "No";
            }

            if (rooms.addRooms(number, type, count,phone,free))
            {
                dataGridViewRooms.DataSource =rooms.getRoomsTabl();
                MessageBox.Show("Номер удачно добавлен");
            }
            else
            {
                MessageBox.Show("Номер не добавлен");
            }
        
        }

        private void buttonClearFR_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            comboBoxType.SelectedIndex = 0;
            comboBoxCount.SelectedIndex = 0;
            tbPhone.Text = "";
            radioButYes.Checked = true;
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonEditR_Click(object sender, EventArgs e)
        {

            try
            {
                int number = int.Parse(tbid.Text);
                int type = int.Parse(comboBoxType.SelectedValue.ToString());
                int count = int.Parse(comboBoxCount.SelectedValue.ToString());
                string phone = tbPhone.Text;
                string free;


                if (radioButYes.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";
                }

                if (rooms.editRoom(number, type, count, phone, free))
                {
                    dataGridViewRooms.DataSource = rooms.getRoomsTabl();
                    MessageBox.Show("Данные удачно изменены");
                }
                else
                {
                    MessageBox.Show("Данные  не изменить");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonRemoveR_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(tbid.Text);


                if (rooms.removeRoom(number))
                {
                    dataGridViewRooms.DataSource = rooms.getRoomsTabl();
                    MessageBox.Show("Данныt удалены");
                    buttonClearFR.PerformClick();
                }
                else
                {
                    MessageBox.Show("Данные  не изменены");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbid.Text = dataGridViewRooms.CurrentRow.Cells[0].Value.ToString();
            comboBoxType.Text = dataGridViewRooms.CurrentRow.Cells[1].Value.ToString();
            comboBoxCount.Text = dataGridViewRooms.CurrentRow.Cells[2].Value.ToString();
            tbPhone.Text =  dataGridViewRooms.CurrentRow.Cells[3].Value.ToString();

            string free= dataGridViewRooms.CurrentRow.Cells[4].Value.ToString();

            if (free.Equals("Да")){
                radioButYes.Checked=true;
            }
            else if (free.Equals("Нет")){
                radioButNO.Checked = true;
            }

        }

        

        private void BackToMain2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BackToMain2_MouseEnter(object sender, EventArgs e)
        {
            BackToMain2.ForeColor = Color.White;
        }

        private void BackToMain2_MouseLeave(object sender, EventArgs e)
        {
            BackToMain2.ForeColor = Color.Black;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
