using System.Linq.Expressions;

namespace Copy 1

{
    public partial class FormLogIn : Form
    {


        public FormLogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;
            string password = txtPassword.Text;

            if (name == "" || password == "")
            {
                lblerror.Location = new Point(65, 270);
                lblerror.Text = "Please enter both username and password.";
            }
            else if (name == Admin.username && password == Admin.password)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2.Show();
                this.Close();
            }
            else
            {
                lblerror.Location = new Point(98, 270);
                lblerror.Text = "Invalid username or password.";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormChangePassword formforgetpass = new FormChangePassword();
            formforgetpass.ShowDialog();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    static class Admin // Static class to hold admin credentials
    {
        public static string username = "admin";
        public static string password = "adminadmin123";
    }
}
