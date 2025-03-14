using DVLD_Buisness;
using ProjectDVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDVLD.UserControls
{
    public partial class ctrlfrmListPeople : UserControl
    {
        public ctrlfrmListPeople()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;

           

        }

        private void _RefreshPeoplList()
        {
            DGVGetAllPeople.DataSource = clsPersonBuisnessLayer.GetAllPeople();
            labRecordsCount.Text = DGVGetAllPeople.Rows.Count.ToString();
        }
        private void picBoxAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmShowPersonInfo = new frmShowPersonInfo( (int)DGVGetAllPeople.CurrentRow.Cells[0].Value);
            frmShowPersonInfo.ShowDialog();
            _RefreshPeoplList();
        }

        private void ctrlfrmListPeople_Load(object sender, EventArgs e)
        {
            _RefreshPeoplList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUpdatePerson = new frmAddUpdatePerson((int)DGVGetAllPeople.CurrentRow.Cells[0].Value);
            frmUpdatePerson.ShowDialog();
            _RefreshPeoplList();
        }

        private void AddNewPersontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
            _RefreshPeoplList();
        }

        private void DGVGetAllPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frmUpdatePerson = new frmAddUpdatePerson((int)DGVGetAllPeople.CurrentRow.Cells[0].Value);
            frmUpdatePerson.ShowDialog();
            _RefreshPeoplList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + DGVGetAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPersonBuisnessLayer.DeletePerson((int)DGVGetAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now. It will be available later" , "Note " , MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now. It will be available later", "Note ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
