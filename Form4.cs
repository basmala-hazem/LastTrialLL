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
    
    public partial class DashForm : Form
    {
        public static DashForm Instance;
        public DashForm()
        {
            InitializeComponent();
            Instance = this;
            
        }
        public static void NavigateTo(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.ShowDialog();      
        }

        private void dataGridViewDash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            NavigateTo(this, new MemberForm(this));
            //MemberForm memberForm = new MemberForm(this);
            //memberForm.ShowDialog();
            // this.Close();
            //this.Hide();

            //MemberForm frm = new MemberForm(this);
            //frm.ShowDialog();
            //this.Hide();
            //this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DashForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Details());


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Finance finance = new Finance();
            //finance.ShowDialog();
            DashForm.NavigateTo(this, new Finance());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateTo(this, new OurTeam());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Coaches coaches = new Coaches();
            //coaches.ShowDialog();
            //this.Close();
            NavigateTo(this, new Coaches());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
