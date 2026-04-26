using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Login;

namespace WindowsFormsApp1
{
    public partial class Changepass : Form
    {
        public Changepass()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string code = txt_Code.Text;
            string Newpass = txt_NewPass.Text;
            string Confirmnewpass = txt_Confirmnewpass.Text;
            string Code = "GYM123@";
            if (code == Code)
            {
                if (code == "" || Newpass == "" || Confirmnewpass == "")
                {
                    //lbl_error2.Location = new Point();
                    //lbl_error2.Text = "Please fill in all fields!";
                    MessageBox.Show("Please fill in all fields!");
                }
                else if (Newpass == Confirmnewpass)
                {

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txt_Code.Text;
            string Newpass = txt_NewPass.Text;
            string Confirmnewpass = txt_Confirmnewpass.Text;
            string Code = "GYM123@";
            if (code == Code)
            {
                if ( Newpass == "" || Confirmnewpass == "")
                {
                    
                    MessageBox.Show("Please fill in all fields!");
                }
                else {
                    if (Newpass == Confirmnewpass)
                    {
                        
                        MessageBox.Show("Password Changed!");
                        this.Hide();
                        Admin.Password = Newpass;
                        Login login = new Login();
                        login.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!");
                    }
                }
                
                {

                }

            }
            else
            {
                MessageBox.Show("Invalid Code!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_shownewpass.Checked == true)
                txt_NewPass.PasswordChar = '\0';
            else
                txt_NewPass.PasswordChar = '*';
        }

        private void check_showconfirmnewpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showconfirmnewpass.Checked == true)
                txt_Confirmnewpass.PasswordChar = '\0';
            else
                txt_Confirmnewpass.PasswordChar = '*';
            
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
