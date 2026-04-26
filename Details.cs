using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Details : Form

    {
        DashForm dashForm;
        public Details(object[] privateData)
        {
            InitializeComponent();
            this.dataGridViewDetails.Rows.Add(privateData);
        }
        public Details()
        {
            InitializeComponent();
            
        }
        File_mangement fileManager = new File_mangement();
        List<Members> members;
        int selectedIndex = -1;
        void LoadData()
        {
            members = fileManager.LoadMembers();
            dataGridViewDetails.DataSource = null;
            dataGridViewDetails.DataSource = members;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = txtName.Text.ToLower();

            //foreach (DataGridViewRow row in dataGridViewDetails.Rows)
            //{
            //    if (row.Cells["colName"].Value != null)
            //    {
            //        if (row.Cells["colName"].Value.ToString().ToLower().Contains(searchValue))
            //            row.Visible = true;
            //        else
            //            row.Visible = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Enter Name!");
            //    }
            //}
        }

        private void dataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;

                var m = members[selectedIndex];

                txtName.Text = m.Name;
                txtAge.Text = m.Age.ToString();
                //txt.Text = m.Phone.ToString();
                //cmbPlan.Text = m.Plan;
                //txtWeight.Text = m.Weight.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetails.CurrentRow != null)
            {
                dataGridViewDetails.Rows.Remove(dataGridViewDetails.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete!");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEdit.Text = dataGridViewDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEdit.Text = dataGridViewDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEdit.Text = dataGridViewDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (selectedIndex != -1)
            //{
            //    members[selectedIndex] = new Members(
            //        cmbPlan.Text,
            //        int.Parse(txtWeight.Text),
            //        0, 0, "", "", "",
            //        txtName.Text,
            //        int.Parse(txtAge.Text),
            //        int.Parse(txtPhone.Text),
            //        "Male"
            //    );

            //    fileManager.SaveMembers(members);

            //    RefreshData();

            //    MessageBox.Show("Updated!"); //Do not REMOVE!!
            //}
            if (selectedIndex == -1)
            {
                MessageBox.Show("Select member first!");
                return;
            }

            members = fileManager.LoadMembers();

            //members[selectedIndex] = new Members(
            //         strplan: cmbPlan.Text, strweight: int.Parse(txtWeight.Text), strdweight:,strheight:,strhealthprom:,traintype:, txtName.Text,
            //        int.Parse(txtWeight.Text),
            //        int.Parse(txtDWeight.Text),
            //        int.Parse(txtHeight.Text),
            //        txtHealthProb.Text,
            //        cmbTraintype.Text,
            //        txtName.Text,

            //        int.Parse(txtAge.Text),
            //        txtPhone.Text,
            //        cmbGenderMmeber.Text
                    

            //);

            fileManager.SaveMembers(members);

            LoadData();

            MessageBox.Show("Updated!");
            if (dataGridViewDetails.CurrentRow == null)
            {
                MessageBox.Show("Choose row first");
                return;
            }

            
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("choose column first");
                return;
            }

            
            string columnName = comboBox1.SelectedItem.ToString();

            
            int columnIndex = comboBox1.SelectedIndex;

            dataGridViewDetails.CurrentRow.Cells[columnIndex].Value = txtEdit.Text;

            
            MessageBox.Show("Changed succesfully");
            if (dataGridViewDetails.CurrentRow != null)
            {
                int index = dataGridViewDetails.CurrentRow.Index;

                //Members [index] = new Members(
                //    cmbPlan.Text,
                //    int.Parse(txtWeight.Text),
                //    0, 0, "", "", "",
                //    txtName.Text,
                //    int.Parse(txtAge.Text),
                //    int.Parse(txtPhone.Text),
                //    cmbGender.Text
                //);

                //File_mangement.SaveMembers(Members);//Do not Remove!!

                //RefreshData();

                MessageBox.Show("Updated!");
            }
        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new MemberForm(this.dashForm));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string searchValue = txtName.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewDetails.Rows)
            {
                if (row.Cells["colName"].Value != null)
                {
                    if (row.Cells["colName"].Value.ToString().ToLower().Contains(searchValue))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                {
                    MessageBox.Show("Enter Name!");
                }
            }

            string searchAge = txtAge.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewDetails.Rows)
            {
                if (row.Cells["colName"].Value != null)
                {
                    if (row.Cells["colName"].Value.ToString().ToLower().Contains(searchAge))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                {
                    MessageBox.Show("Enter Name!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new Coaches());
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            DashForm.NavigateTo(this, new DashForm());
        }
    }
}
