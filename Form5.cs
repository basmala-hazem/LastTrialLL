using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_Project
{
    public partial class FormChangePassword : Form
    {
        

        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string code = txtCode.Text;
            string newPassword = txtPass.Text;
            string confirmPassword = txtPassConfirm.Text;
            string Code = "GYM123";
            if (code == Code)
            {
                if (newPassword == "" || confirmPassword == "" || code == "")
                {
                    lblerror2.Location = new Point(115, 310);
                    lblerror2.Text = "Please fill in all fields.";

                }
                else if (newPassword == confirmPassword)
                {

                    lblerror2.Text = "";
                    MessageBox.Show("Password changed successfully!");
                    this.Hide();
                    Admin.password = newPassword;
                    FormLogIn formlogin = new FormLogIn();
                    formlogin.ShowDialog();
                }
                else if (newPassword != confirmPassword)
                {
                    lblerror2.Location = new Point(110, 310);
                    lblerror2.Text = "Passwords do not match.";
                }

            }
            else
            {
                lblerror2.Location = new Point(100, 310);
                lblerror2.Text = "Please enter the correct code.";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogIn formlogin = new FormLogIn();
            formlogin.ShowDialog();
            this.Close();
        }
    }
}
