using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class Admin : Form
    {
        SqlCommand myCommand;
        DataTable dt;
        SqlDataReader dr;
        //Rushi
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Login.mycon.Open();
            myCommand = new SqlCommand("select uname,uphone,locations,departure_date,utr from users inner join booking on users.username=booking.username", Login.mycon);
            dr = myCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            Login.mycon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != comboBox2.Text)
            {
                Login.mycon.Open();
                string location = comboBox1.Text + "To" + comboBox2.Text;
                myCommand = new SqlCommand("select uname,uphone,locations,departure_date,utr from users inner join booking on users.username=booking.username where locations=@locations", Login.mycon);
                myCommand.Parameters.AddWithValue("@locations", location);
                dr = myCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                Login.mycon.Close();
            }
            else
            {
                MessageBox.Show("source and destination should not be same");
            }
           
        }
    }
}
