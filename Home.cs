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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightBookingApp
{
    public partial class Home : Form
    {
        SqlCommand mycommand;
        public static string pnrAccess;
        public Home()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate=DateTime.Now.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != comboBox2.Text)
            {
                if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    if (textBox3.Text == UPI.utr)
                    {
                        Login.mycon.Open();
                        mycommand = new SqlCommand("insert into booking values(@username, @bsource, @bdestination,@bdeparture_date,@pnr, @UTR)", Login.mycon);
                        mycommand.Parameters.AddWithValue("@username", Login.usernameForHome);
                        mycommand.Parameters.AddWithValue("@bsource", comboBox1.Text);
                        mycommand.Parameters.AddWithValue("@bdestination", comboBox2.Text);
                        mycommand.Parameters.AddWithValue("@bdeparture_date", dateTimePicker1.Value.ToShortDateString());
                        mycommand.Parameters.AddWithValue("@pnr", pnrAccess);
                        mycommand.Parameters.AddWithValue("@UTR", textBox3.Text);
                        mycommand.ExecuteNonQuery();



                        Login.mycon.Close();
                        MessageBox.Show("Your Ticket is Booked");
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        textBox3.Text = "";
                        radioButton1.Checked = false;
                        //dataGridView1.Rows.Clear();
                        dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
                        DataTable dtn=new DataTable();
                        dataGridView1.DataSource = dtn;
                    }
                    else
                    {
                        MessageBox.Show("Your UTR number is invalid", "UTR number Invalid");
                    }
                }
                else
                {
                    MessageBox.Show("Enter all fields");
                }
            }
            else
            {
                MessageBox.Show("source and destination should not be same");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
               UPI upi= new UPI();
               upi.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Login.mycon.Open();
            mycommand = new SqlCommand("select * from flight where fsource=@source and fdestination=@destination", Login.mycon);
            mycommand.Parameters.AddWithValue("@source",comboBox1.Text);
            mycommand.Parameters.AddWithValue("@destination", comboBox2.Text);
            SqlDataReader dr = mycommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            Login.mycon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dataGridView1.CurrentRow;
            pnrAccess = dgr.Cells[0].Value.ToString();
            MessageBox.Show(pnrAccess + " is selected");
        }
    }
}
