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
        }

        private void DGVGetAllPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frmUpdatePerson = new frmAddUpdatePerson((int)DGVGetAllPeople.CurrentRow.Cells[0].Value);
            frmUpdatePerson.ShowDialog();
        }
    }
}
