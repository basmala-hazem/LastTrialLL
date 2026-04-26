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
    public partial class Coaches : Form

    {
        DashForm dashForm;
        public Coaches()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Fill all fields!");
                return;
            }
            string strname = textBox1.Text;
            string strphone = textBox2.Text;
            int strage = int.Parse(textBox3.Text);
            int exp_years=int.Parse(textBox4.Text); 
            string strgender= cmbGenderCoach.Text;
            if (Global.CurrentCountC < Global.alltrainers.Length)
            {
                Trainers newT = new Trainers(exp_years, strname, strage, strphone, strgender);
                newT.Exp_years = exp_years;
                newT.Name = strname;
                newT.Phone = strphone;
                newT.Gender = strgender;
                newT.Age = strage;
                Global.CurrentCountC++;
                Global.alltrainers[Global.CurrentCountC] = newT;
                MessageBox.Show("Coach was added succesfully!"); 

            }
            else 
            {
                MessageBox.Show("number of coaches is completed!");

            }
                //salary 
                object[]Data = { strname, strage, strphone, exp_years,strgender };
            dataGridView1.Rows.Add(Data);
            //GlobalVar.AddMember();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["ColName"].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells["ColAge"].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells["colPhone"].Value = textBox3.Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select the Row!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Details());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Coaches_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Finance());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new OurTeam());
        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new MemberForm(this.dashForm));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new DashForm());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
