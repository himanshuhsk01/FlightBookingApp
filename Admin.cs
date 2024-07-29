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
        SqlCommand mycommand;
        DataTable dt;
        SqlDataReader dr;
        public bool flag = false;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (flag)
                {
                    Login.mycon.Open();
                    mycommand = new SqlCommand("SELECT u.uname, u.uage, u.ugender, u.uidentity, u.uphone, b.bsource, b.bdestination, b.bdeparture_date, b.pnr, f.fname, f.fprice FROM users u JOIN booking b ON u.username = b.username JOIN flight f ON f.pnr = b.pnr where bsource=@bsource and bdestination=@bdestination", Login.mycon);
                    mycommand.Parameters.AddWithValue("@bsource",comboBox1.Text);
                    mycommand.Parameters.AddWithValue("@bdestination", comboBox2.Text);
                    dr = mycommand.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    Login.mycon.Close();
                }
                else
                {
                
                Login.mycon.Open();
                mycommand = new SqlCommand("SELECT u.uname, u.uage, u.ugender, u.uidentity, u.uphone, b.bsource, b.bdestination, b.bdeparture_date, b.pnr, f.fname, f.fprice FROM users u JOIN booking b ON u.username = b.username JOIN flight f ON f.pnr = b.pnr WHERE CONVERT(date, SUBSTRING(b.bdeparture_date, 7, 4) + '-' + SUBSTRING(b.bdeparture_date, 4, 2) + '-' + SUBSTRING(b.bdeparture_date, 1, 2)) BETWEEN CONVERT(date, @blower) AND CONVERT(date, @bhigher)", Login.mycon);

                
                string lowerDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string higherDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                
                mycommand.Parameters.AddWithValue("@blower", lowerDate);
                mycommand.Parameters.AddWithValue("@bhigher", higherDate);

     
                dr = mycommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                
                Login.mycon.Close();
            }
            

           
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter.Text == "Source_&_Destination")
            {
                //RangeOfDate
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "Source";
                label2.Text = "Destination";
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                button1.Visible = true;
                flag = true;

            }
            else if (filter.Text == "RangeOfDate")
            {
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "From";
                label2.Text = "To";
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                button1.Visible = true;
                flag = false;

                
            }
            else if(filter.Text == "All")
            {
                Login.mycon.Open();
                mycommand = new SqlCommand("SELECT u.uname, u.uage, u.ugender, u.uidentity, u.uphone, b.bsource, b.bdestination, b.bdeparture_date, b.pnr, f.fname, f.fprice FROM users u JOIN booking b ON u.username = b.username JOIN flight f ON f.pnr = b.pnr where b.bdeparture_date >= @blower and b.bdeparture_date <= @bhigher", Login.mycon);
                mycommand.Parameters.AddWithValue("@blower", dateTimePicker1.Value.ToShortDateString());
                mycommand.Parameters.AddWithValue("@bhigher", dateTimePicker2.Value.ToShortDateString());
                dr = mycommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                Login.mycon.Close();



            }
        }
    }
}
