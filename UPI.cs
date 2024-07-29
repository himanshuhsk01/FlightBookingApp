﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightBookingApp.Properties;

namespace FlightBookingApp
{
    public partial class UPI : Form
    {
        static public int c;
        static public string utr;

        public UPI()
        {
            InitializeComponent();
            c = Settings.Default.counter; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            utr = "UTRF100" + c.ToString();
            label2.Text = utr;

            // Save the updated counter value to the settings
            Settings.Default.counter = c;
            Settings.Default.Save();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}