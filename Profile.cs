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
    public partial class Profile : Form
    {
        SqlCommand mycommand;
      
        public Profile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Login.mycon.Open();
            mycommand = new SqlCommand("select uname,uphone from users where username=@username", Login.mycon);
            mycommand.Parameters.AddWithValue("@username", Login.usernameForHome);
            SqlDataReader reader = mycommand.ExecuteReader();
            
            if (reader.Read())
            {
                 txtProfileName.Text= reader["uname"].ToString();
                txtProfilePhoneNumber.Text = reader["uphone"].ToString() ;
            }
            reader.Close();
            
            mycommand =new SqlCommand("select booking.bsource,booking.bdestination,booking.bdeparture_date,booking.utr,booking.pnr ,flight.fname,flight.fprice from booking join flight on booking.pnr = flight.pnr where booking.username = @username;", Login.mycon);
            mycommand.Parameters.AddWithValue("@username", Login.usernameForHome);
            SqlDataReader dr = mycommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewbookinghistory.DataSource = dt;
            Login.mycon.Close();
           
        }

        private void dataGridViewbookinghistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
