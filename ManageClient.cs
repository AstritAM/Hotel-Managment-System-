using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageClient : Form
    {
        public ManageClient()
        {
            InitializeComponent();
        }

        private void BackToMain1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BackToMain1_MouseEnter(object sender, EventArgs e)
        {
            BackToMain1.ForeColor = Color.White;


        }

        private void BackToMain1_MouseLeave(object sender, EventArgs e)
        {
            BackToMain1.ForeColor = Color.Black;
        }

        private void buttonClearF_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbid.Text = "";
            tbLName.Text = "";
            tbPName.Text = "";
            tbAge.Text = "";
            tbPass.Text = "";
            tbContry.Text = "";
        }
        Client client = new Client();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fname = tbName.Text;
            String lname = tbLName.Text;
            String pname = tbPName.Text;
            string age = tbAge.Text;
            string  passport = tbPass.Text;
            String country = tbContry.Text;
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || pname.Trim().Equals("") || age.Trim().Equals("") || passport.Trim().Equals("") || country.Trim().Equals(""))
            {
              

                MessageBox.Show("Введены не все данные");
            }
            else
            {
                bool insClient = client.inClient(fname, lname, pname,int.Parse( age), int.Parse(passport), country);
                
                if (insClient)
                {
                    dataGridView1.DataSource = client.getClientTabl();
                    MessageBox.Show("Клиент удачно добавлен");
                }
                else
                {
                    MessageBox.Show("Клиент не добавлен");
                }
            }
        }

        private void ManageClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClientTabl();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( tbid.Text);
            string fname = tbName.Text;
            String lname = tbLName.Text;
            String pname = tbPName.Text;
            string age = tbAge.Text;
            string passport = tbPass.Text;
            String country = tbContry.Text;
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || pname.Trim().Equals("") || age.Trim().Equals("") || passport.Trim().Equals("") || country.Trim().Equals(""))
            {


                MessageBox.Show("Введены не все данные");
            }
            else
            {

                bool editClient = client.editClient(id, fname, lname, pname, int.Parse(age), int.Parse(passport), country) ;
               
                if (editClient)
                {
                    dataGridView1.DataSource = client.getClientTabl();
                    MessageBox.Show("Данные успешно изменены");
                }
                else
                {
                    MessageBox.Show("Данные не изменены");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

tbid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbPName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbAge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbPass.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbContry.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }



        //заметка
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAge.MaxLength = 2;

            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch)) && (ch!= (char)Keys.Back) && (ch != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch)) && (ch != (char)Keys.Back) && (ch != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbid.Text);
                if (client.removeClient(id))
                {
                    dataGridView1.DataSource = client.getClientTabl();
                    MessageBox.Show("Данные о клиенте удалены");
                    buttonClearF.PerformClick();
                }
                else
                {
                    MessageBox.Show("Данные не удалены");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
