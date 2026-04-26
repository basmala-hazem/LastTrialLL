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
    public partial class OurTeam : Form
    {
        DashForm dashForm;
        public OurTeam()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Coaches());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Details());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Finance());
        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new MemberForm(this.dashForm));
        }

        private void OurTeam_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new DashForm());
        }
    }
}
