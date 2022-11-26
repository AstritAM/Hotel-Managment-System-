using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

     

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLable_MouseEnter(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.Red;
        }

        private void CloseLable_MouseLeave(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.Black;
        }
        Point lPoint;

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint.X;
                this.Top += e.Y - lPoint.Y;
            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint.X;
                this.Top += e.Y - lPoint.Y;
            }

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint = new Point(e.X, e.Y);
        }

        private void ManegeClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageClient mclient = new ManageClient();
            mclient.Show();

        }

        private void ManegeResevertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueOfNumbers issueOfNumbers = new IssueOfNumbers();
            issueOfNumbers.Show();

        }

        private void ManegeRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRoom manageRoom = new ManageRoom();
            manageRoom.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
