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
        string utr;
      
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
        public void loadData()
        {
            Login.mycon.Open();
            mycommand = new SqlCommand("select booking.bsource,booking.bdestination,booking.bdeparture_date,booking.utr,booking.pnr ,flight.fname,flight.fprice from booking join flight on booking.pnr = flight.pnr where booking.username = @username;", Login.mycon);
            mycommand.Parameters.AddWithValue("@username", Login.usernameForHome);
            SqlDataReader dr = mycommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewbookinghistory.DataSource = dt;
            dr.Close();
            Login.mycon.Close();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            label2.Visible=false;
            dateTimePicker1.Visible=false;
            btn_cancel.Visible=false;
            button1.Visible=false;

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
            Login.mycon.Close();
            loadData();
            
        }

        private void dataGridViewbookinghistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                DataGridViewRow dgr = dataGridViewbookinghistory.CurrentRow;
                utr = dgr.Cells[3].Value.ToString();
                MessageBox.Show(utr + " is selected");
                Login.mycon.Open();
                 mycommand = new SqlCommand("select bdeparture_date from booking where utr=@utr", Login.mycon);
                mycommand.Parameters.AddWithValue("@utr", utr);
                SqlDataReader reader = mycommand.ExecuteReader();

            if (reader.Read())
            {
                string dateStr = reader["bdeparture_date"].ToString();

                if (DateTime.TryParseExact(dateStr, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime departureDate))
                {
                    dateTimePicker1.MinDate = departureDate;
                }
                else
                {
                    MessageBox.Show("Unable to parse the departure date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            reader.Close();
            
            Login.mycon.Close();    
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Please note: Your ticket cancellation will not be refunded", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                
                Login.mycon.Open();
                mycommand = new SqlCommand("delete from booking where utr=@utr", Login.mycon);
                mycommand.Parameters.AddWithValue("@utr", utr);
                SqlDataReader reader = mycommand.ExecuteReader();
                reader.Close();
                Login.mycon.Close();
                loadData();
               
            }

        }

        private void Reschedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on flight of booking status", "Rescheduling");
            btn_cancel.Visible = false;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please note: Please note: Once you reschedule, you cannot return to the original date ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                Login.mycon.Open();
                mycommand = new SqlCommand("update booking set bdeparture_date=@date where utr=@utr", Login.mycon);
                mycommand.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
                mycommand.Parameters.AddWithValue("@utr", utr);
                mycommand.ExecuteNonQuery();
                Login.mycon.Close();
                loadData();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on flight of booking status", "cancel ticket");
            btn_cancel.Visible = true;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Visible = false;
        }
    }
}
