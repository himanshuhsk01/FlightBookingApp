using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FlightBookingApp
{
    public partial class RegisterForm : Form
    {
        //SqlConnection mycon;
        SqlCommand mycommand;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPassword();
            ValidateConfirmPassword();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            string patternfornumber = "^[0-9]{10}$";
            bool phoneMatch = Regex.IsMatch(textNumber.Text, patternfornumber);
            if (!phoneMatch)
            {
                isvalid = false;
                MessageBox.Show("Enter a valid 10-digit phone number.");
            }

            string patternforname = "^[a-zA-Z]+ [a-zA-Z]+$";
            bool nameMatch = Regex.IsMatch(textName.Text, patternforname);
            if (!nameMatch)
            {
                isvalid = false;
                MessageBox.Show("Enter only name and surname with one space.");
            }
            string patternforusername = "^([a-z_@-][0-9]*)+$";
            bool usernameMatch = Regex.IsMatch(txtusername.Text, patternforusername);
            if (!usernameMatch)
            {
                isvalid = false;
                MessageBox.Show("Enter Valid Username without space and lowecase");
            }
            if (isvalid == true)
            {
                Login.mycon.Open();
                
                mycommand=new SqlCommand("insert into users values(@username,@passwords,@uname,@uage,@ugender,@uidentity,@uphone)",Login.mycon);
                mycommand.Parameters.AddWithValue("@username",txtusername.Text);
                mycommand.Parameters.AddWithValue("@passwords",txtpass.Text);
                mycommand.Parameters.AddWithValue("@uname", textName.Text);
                mycommand.Parameters.AddWithValue("@uage", numericUpDown1.Text);
                mycommand.Parameters.AddWithValue("@ugender", radioButton1.Checked?"Male":"Female");
                mycommand.Parameters.AddWithValue("@uidentity", txt_id.Text);
                mycommand.Parameters.AddWithValue("@uphone", textNumber.Text);
                mycommand.ExecuteNonQuery();
                Login.mycon.Close();
                Login login=new Login();
                login.Show();
                this.Hide();
            }


        }

        private bool ValidateNewPassword()
        {
            string newPassword = txtpass.Text;
            string errorMessage = "Password should contain Sepacial Character ,digit and 6 character";
            bool isValid = true;

            if (newPassword.Length < 6)
            {
                isValid = false;
            }
            if (!Regex.IsMatch(newPassword, @"[!@#$%^&*(),.?""{}|<>]"))
            {
                isValid = false;
            }
            if (Regex.Matches(newPassword, @"[0-9]").Count < 2)
            {
                isValid = false;
            }

            label9.Text = isValid ? string.Empty : errorMessage;
            return isValid;
        }

        private bool ValidateConfirmPassword()
        {
            string newPassword = txtpass.Text;
            string confirmPassword = txtpasscnfm.Text;
            string mismatchMessage = "Passwords do not match!";
            string matchMessage = "Passwords match";
            bool isValid = newPassword == confirmPassword;

            // Update label8 based on password match status
            if (isValid && !string.IsNullOrWhiteSpace(newPassword) && !string.IsNullOrWhiteSpace(confirmPassword))
            {
                label8.Text = matchMessage;
                label8.ForeColor = System.Drawing.Color.Green; 
            }
            else
            {
                label8.Text = mismatchMessage;
                label8.ForeColor = System.Drawing.Color.Red; 
            }

            return isValid;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPassword();
            ValidateConfirmPassword();
        }

        private void txtpasscnfm_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //string connstring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //mycon=new SqlConnection(connstring);
            //comboBox1.SelectedIndex = 0;
            //string identity = "";
            //if (comboBox1.Text.Equals("Adhaar Card"))
            //{

            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



