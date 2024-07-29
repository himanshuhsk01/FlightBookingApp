using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
            this.Load += Parent_Load;//to wired it up
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            homeToolStripMenuItem.Text = Login.HomeLabel;
            userNameForHomePageToolStripMenuItem.Text = Login.usernameForHome;
            if (Login.HomeLabel == "Home")
            {
                Home home=new Home();
                home.MdiParent = this;
                home.Show(); 
            }
            else if(Login.HomeLabel == "Admin")
            {
                profileToolStripMenuItem.Visible=false;
                Admin admin = new Admin();
                admin.MdiParent = this;
                admin.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.HomeLabel == "Home")
            {
                Home home = new Home();
                home.MdiParent = this;
                home.Show();
            }
           
        }

        

        private void userNameForHomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.MdiParent = this;
            profile.Show();
            
        }
    }
}
