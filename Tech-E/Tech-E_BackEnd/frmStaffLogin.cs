using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_E_BackEnd
{
    public partial class frmStaffLogin : Form
    {
        private TextBox txtStaffID;
        private Label lblPassword;
        private Label lblStaffLogin;
    
        public frmStaffLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.Location = new System.Drawing.Point(11, 44);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(43, 13);
            this.lblStaffLogin.TabIndex = 0;
            this.lblStaffLogin.Text = "StaffID:";
            this.lblStaffLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(71, 46);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(148, 20);
            this.txtStaffID.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // frmStaffLogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffLogin);
            this.Name = "frmStaffLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
