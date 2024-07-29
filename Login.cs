//using ImageProcessor.Imaging;
//using ImageProcessor;
//using ImageProcessor.Imaging.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightBookingApp.Properties;
//login pag


namespace FlightBookingApp
{
    public partial class Login : Form
    {
        public static SqlConnection mycon;
        SqlCommand mycommand;
        public static string usernameForHome;
        public static string HomeLabel;
      
        public Login()
        {
            InitializeComponent();
            InitializePictureBox();       
        }

        public void InitializePictureBox()
        {
            PictureBox pictureBox = new PictureBox
            {
                Name = "pictureBox1",
                Size = new Size(300, 300), 
                Location = new Point(10,100), 
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pictureBox);
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string connstring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            mycon = new SqlConnection(connstring);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            mycon.Open();
            mycommand = new SqlCommand("select passwords from users where username=@username",mycon);
            mycommand.Parameters.AddWithValue("@username",txt_username.Text);
            SqlDataReader reader = mycommand.ExecuteReader();
            string password = null;
            if (reader.Read())
            {
                password = reader["passwords"].ToString();
            }
            

            reader.Close();
            

            if (txt_password.Text == password && !string.IsNullOrEmpty(password)) {

                usernameForHome=txt_username.Text.ToString();
                if (txt_username.Text.Equals("mona_123") || txt_username.Text.Equals("kiran_123"))
                {
                    HomeLabel = "Admin";  
                }
                else
                {
                    HomeLabel = "Home";  
                }
                mycon.Close();
                Parent parent = new Parent();
                parent.Show();
                this.Hide();
               

            }
            else
            {
                MessageBox.Show("Password or Username is incorrect", "Invalid");
            }
            mycon.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lnk_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register=new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void eye_icon_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !txt_password.UseSystemPasswordChar;
            if(txt_password.UseSystemPasswordChar)
            {
                
               eye_icon.Image=Properties.Resources.eyeclose;

            }
            else
            {
               eye_icon.Image = Properties.Resources.open_eye;
            }
        }
    }
}
