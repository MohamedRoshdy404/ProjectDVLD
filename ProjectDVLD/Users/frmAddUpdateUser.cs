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

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;
        private int _UserID = -1;
        clsUsersBuisnessLayer _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
                
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _UserID = UserID;

                 //ctrlPersonCardWithFilter card = new ctrlPersonCardWithFilter();
          
            
                // card.LoadPersonInfo(PersonID);

            
        }


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

        private void _ResetDefualtValues()
        {
            if (Mode == enMode.AddNew)
            {
                _User = new clsUsersBuisnessLayer();
                lblTitle.Text = "Add New User";

            }
            else
            {
                lblTitle.Text = "Update User";
            }
        }
        private void _LoadData()
        {

            _User = clsUsersBuisnessLayer.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = Convert.ToBoolean( _User.IsActive);
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            _User.PersonID = PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;

            if (chkIsActive.Checked)
                _User.IsActive = 1;
            else
                _User.IsActive = 0;

            if (clsUsersBuisnessLayer.isExist(PersonID))
            {
                MessageBox.Show("The operation could not be completed. This person is linked to another user account, and only one user can be assigned to a single person.", "Data NOT Saved.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_User.Save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUserID.Text = _User.UserID.ToString();
                }
                else
                {
                    MessageBox.Show("Data NOT Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
    }
}
