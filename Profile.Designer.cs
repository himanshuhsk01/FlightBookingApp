namespace FlightBookingApp
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfilePhoneNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtProfilePhoneNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewbookinghistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbookinghistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(902, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FlightBookingApp.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(856, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(814, 161);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(100, 36);
            this.lblProfileName.TabIndex = 2;
            this.lblProfileName.Text = "Name ";
            // 
            // lblProfilePhoneNumber
            // 
            this.lblProfilePhoneNumber.AutoSize = true;
            this.lblProfilePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilePhoneNumber.Location = new System.Drawing.Point(758, 272);
            this.lblProfilePhoneNumber.Name = "lblProfilePhoneNumber";
            this.lblProfilePhoneNumber.Size = new System.Drawing.Size(231, 36);
            this.lblProfilePhoneNumber.TabIndex = 3;
            this.lblProfilePhoneNumber.Text = " Phone Number ";
            this.lblProfilePhoneNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(912, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Booking Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(1036, 161);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(297, 36);
            this.txtProfileName.TabIndex = 5;
            // 
            // txtProfilePhoneNumber
            // 
            this.txtProfilePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfilePhoneNumber.Location = new System.Drawing.Point(1036, 274);
            this.txtProfilePhoneNumber.Name = "txtProfilePhoneNumber";
            this.txtProfilePhoneNumber.ReadOnly = true;
            this.txtProfilePhoneNumber.Size = new System.Drawing.Size(297, 36);
            this.txtProfilePhoneNumber.TabIndex = 6;
            // 
            // dataGridViewbookinghistory
            // 
            this.dataGridViewbookinghistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewbookinghistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewbookinghistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbookinghistory.Location = new System.Drawing.Point(575, 479);
            this.dataGridViewbookinghistory.Name = "dataGridViewbookinghistory";
            this.dataGridViewbookinghistory.RowHeadersWidth = 51;
            this.dataGridViewbookinghistory.RowTemplate.Height = 24;
            this.dataGridViewbookinghistory.Size = new System.Drawing.Size(979, 203);
            this.dataGridViewbookinghistory.TabIndex = 7;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 683);
            this.Controls.Add(this.dataGridViewbookinghistory);
            this.Controls.Add(this.txtProfilePhoneNumber);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProfilePhoneNumber);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbookinghistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfilePhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtProfilePhoneNumber;
        private System.Windows.Forms.DataGridView dataGridViewbookinghistory;
    }
}