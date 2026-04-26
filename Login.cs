using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string name = txt_Username.Text;
            string pass = txt_Pass.Text;
            if(name == "" || pass == "")
            {
                //lbl_error.Location = new Point(19, 270);
                //lbl_error.Text = "Please enter both Username and Password";
                MessageBox.Show("Please enter both Username and Password");
            }
            else if (name == Admin.Username && pass == Admin.Password)
            {
                MessageBox.Show("Welcome Coach");
                DashForm frm = new DashForm();
                this.Hide();
                frm.ShowDialog();
                this.Close();

            }
            else
            {
                //lbl_error.Location = new Point(49 , 270);
                //lbl_error.Text = "Invalid Username or Password!";
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpass.Checked == true)
                txt_Pass.PasswordChar = '\0';
            else
                txt_Pass.PasswordChar = '*';
            
        }

        private void lnk_forgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Changepass changepass = new Changepass();
            this.Hide();
            changepass.ShowDialog();
            this.Close();

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
        public static class Admin
        {
            public static string Username = "1";
            public static string Password = "2";
            //public static string Code = "GYM123@";
        }
    }
   
}
