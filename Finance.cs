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
    public partial class Finance : Form
    {
        DashForm dashForm;
        public Finance()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label5.Text = Global.CurrentCountC.ToString();
        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new MemberForm(this.dashForm));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Coaches());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Details());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new OurTeam());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new DashForm());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = Person.TotalBalance.ToString();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = Global.CurrentCountC.ToString();
        }
    }
}
