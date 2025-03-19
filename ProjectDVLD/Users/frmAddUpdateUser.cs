using DVLD_Buisness;
using ProjectDVLD.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDVLD.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        private clsPersonBuisnessLayer _Perosn;


        public int PersonID
        {
            get { return ctrlPersonCardWithFilter1.PersonID; }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUsersBuisnessLayer User = new clsUsersBuisnessLayer();

            User.PersonID = PersonID;
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            if (chkIsActive.Checked)
                User.IsActive = 1;
            else
                User.IsActive = 0;


            if (User.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = User.UserID.ToString();
            }
            else
            {
                MessageBox.Show("Data NOT Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
