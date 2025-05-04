using DVLD_Buisness;
using ProjectDVLD.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDVLD.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        public frmAddUpdateLocalDrivingLicesnseApplication()
        {
            InitializeComponent();
        }


        private void _FillLicenseClassIncomboBox()
        {
            DataTable LicenseClass = clsLicenseClassBuisnessLayer.GetAllLicenseClasses();

            foreach (DataRow Class in LicenseClass.Rows)
            {
                cbLicenseClass.Items.Add(Class["ClassName"]);
            }
            cbLicenseClass.SelectedIndex = 0;

        }

        private void btnApplicationInfoNext_Click(object sender, EventArgs e)
        {
            clsPersonBuisnessLayer Person = clsPersonBuisnessLayer.FindByPersonID(ctrlPersonCardWithFilter1.PersonID);

            if (Person != null)
            {
                lblLocalDrivingLicebseApplicationID.Text = Person.PersonID.ToString();
                lblCreatedByUser.Text = clsUserInfo.UserName;
                tcApplicationInfo.SelectedTab = tpApplicationInfo;
                tcApplicationInfo.TabPages["tpApplicationInfo"].Enabled = true;
                lblApplicationDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                _FillLicenseClassIncomboBox();
            }

        }
    }
}
