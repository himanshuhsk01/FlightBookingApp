namespace FlightBookingApp
{
    partial class ForgotPassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usn = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.txt_confirmpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lbl_cfmpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(762, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // txt_usn
            // 
            this.txt_usn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usn.Location = new System.Drawing.Point(868, 217);
            this.txt_usn.Name = "txt_usn";
            this.txt_usn.Size = new System.Drawing.Size(245, 30);
            this.txt_usn.TabIndex = 3;
            this.txt_usn.TextChanged += new System.EventHandler(this.txt_usn_TextChanged);
            // 
            // txt_newpass
            // 
            this.txt_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpass.Location = new System.Drawing.Point(868, 281);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '*';
            this.txt_newpass.Size = new System.Drawing.Size(245, 30);
            this.txt_newpass.TabIndex = 4;
            this.txt_newpass.TextChanged += new System.EventHandler(this.txt_newpass_TextChanged);
            // 
            // txt_confirmpass
            // 
            this.txt_confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpass.Location = new System.Drawing.Point(868, 352);
            this.txt_confirmpass.Name = "txt_confirmpass";
            this.txt_confirmpass.PasswordChar = '*';
            this.txt_confirmpass.Size = new System.Drawing.Size(245, 30);
            this.txt_confirmpass.TabIndex = 5;
            this.txt_confirmpass.TextChanged += new System.EventHandler(this.txt_confirmpass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_save.Location = new System.Drawing.Point(818, 477);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 51);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.ForeColor = System.Drawing.Color.Red;
            this.lbl_newpass.Location = new System.Drawing.Point(868, 314);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(0, 16);
            this.lbl_newpass.TabIndex = 8;
            // 
            // lbl_cfmpass
            // 
            this.lbl_cfmpass.AutoSize = true;
            this.lbl_cfmpass.ForeColor = System.Drawing.Color.Red;
            this.lbl_cfmpass.Location = new System.Drawing.Point(868, 385);
            this.lbl_cfmpass.Name = "lbl_cfmpass";
            this.lbl_cfmpass.Size = new System.Drawing.Size(0, 16);
            this.lbl_cfmpass.TabIndex = 9;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 890);
            this.Controls.Add(this.lbl_cfmpass);
            this.Controls.Add(this.lbl_newpass);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_confirmpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_usn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_confirmpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_usn;
        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.Label lbl_cfmpass;
    }
}
