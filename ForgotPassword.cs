using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FlightBookingApp
{
    public partial class ForgotPassword : Form
    {
        SqlCommand mycommand;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void txt_confirmpass_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }

        private void txt_usn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPassword();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Login.mycon.Open();
            mycommand = new SqlCommand("select username from users where username=@username", Login.mycon);
            mycommand.Parameters.AddWithValue("@username", txt_usn.Text);
            SqlDataReader reader1 = mycommand.ExecuteReader();
            string usernametoview = null;
            if (reader1.Read())
            {
                usernametoview = reader1["username"].ToString();
            }
            reader1.Close();



            if (usernametoview != txt_usn.Text)
            {
                MessageBox.Show("Username is not valid", "Invalid");
            }
            Login.mycon.Close();


            if (ValidateNewPassword() && ValidateConfirmPassword()&&usernametoview!=null)
            {
                Login.mycon.Open();
                mycommand = new SqlCommand("update users set passwords=@pass where username=@username", Login.mycon);
                mycommand.Parameters.AddWithValue("@username", txt_usn.Text);
                mycommand.Parameters.AddWithValue("@pass", txt_newpass.Text);
                mycommand.ExecuteNonQuery();
               
                 MessageBox.Show("Password reset successfully!");
               
                Login.mycon.Close();
                this.Hide();    

            }

           


        }

        private bool ValidateNewPassword()
        {
            string newPassword = txt_newpass.Text;
            string errorMessage = "Please enter a strong password! The password must contain a special character and at least two digits and minimum 6 character length!";
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

            lbl_newpass.Text = isValid ? string.Empty : errorMessage;
            return isValid;
        }

        private bool ValidateConfirmPassword()
        {
            string newPassword = txt_newpass.Text;
            string confirmPassword = txt_confirmpass.Text;
            string errorMessage = "Passwords do not match!";
            bool isValid = newPassword == confirmPassword;

            lbl_cfmpass.Text = isValid ? string.Empty : errorMessage;
            return isValid;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
           
        }
    }
}
