using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class MemberForm : Form
    {
        DashForm dashForm;
        public MemberForm(DashForm dashForm)
        {
            InitializeComponent();
            this.dashForm = dashForm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string strname =nameText.Text;
            string strage = ageText.Text;
            string strplan = planText.Text;
            string strheight = heightText.Text;
            string strweight = weightText.Text;
            string strdweight = dweightText.Text;
            string strhealthProm = healthProblemText.Text;
            string strStatus; 
            int monthsToAdd = 0;
            if (planText.Text == "Monthly") monthsToAdd = 1;
            else if (planText.Text == "Quarterly") monthsToAdd = 3;
            else if (planText.Text == "Annual") monthsToAdd = 12;

            DateTime expiryDate = DateTime.Now.AddMonths(monthsToAdd);
            if (expiryDate < DateTime.Now)
            {
                strStatus = "Expired";  
            }
            else { strStatus = "Active"; }
            object[] Data = { strname, strplan, expiryDate,strStatus };
            this.dashForm.dataGridViewDash.Rows.Add(Data);
            object[] privateData = {strname, strage, strplan, strheight, strweight,strdweight, strhealthProm};
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Date!");
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
