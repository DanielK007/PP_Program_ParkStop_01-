using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingStop.Forms
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUser.Text == "a" && txtBoxPassword.Text == "1")
            {
                this.Hide();
                new FrontPage().Show();
                pnlInvalid.Visible = false;
            }
            else
            {
                pnlInvalid.Visible = true;
            }
            
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtBoxUser.Clear(); 
            txtBoxPassword.Clear();
        }

        private void chkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPass.Checked == false)
                txtBoxPassword.UseSystemPasswordChar = true;
            else
                txtBoxPassword.UseSystemPasswordChar = false;
        }
    }
}
