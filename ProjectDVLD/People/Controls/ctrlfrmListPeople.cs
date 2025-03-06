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

            DGVGetAllPeople.DataSource = clsPersonBuisnessLayer.GetAllPeople();

        }

        private void picBoxAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.ShowDialog();
        }
    }
}
