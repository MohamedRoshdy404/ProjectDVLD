using DVLD_Buisness;
using ProjectDVLD.People;
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
    public partial class frmGetAllUsers : Form
    {
        public frmGetAllUsers()
        {
            InitializeComponent();

        }
        private static DataTable  _dtAllUsers = clsUsersBuisnessLayer.GetInfoUsers();

        private  DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false , "UserID", "PersonID", "FullName", "UserName", "IsActive");

        private void _RefreshUserList()
        {

            _dtAllUsers = clsUsersBuisnessLayer.GetInfoUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");

            DGVGetAllUsers.DataSource = _dtUsers;
            labRecordsCount.Text = DGVGetAllUsers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        private void GetAllUsers_Load(object sender, EventArgs e)
        {
            _RefreshUserList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            _RefreshUserList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddUpdateUser = new frmAddUpdateUser((int)DGVGetAllUsers.CurrentRow.Cells[0].Value);

            frmAddUpdateUser.ShowDialog();
            _RefreshUserList();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.Text == "Is Active")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilter.Visible = (cbFilterBy.Text != "None");
                txtFilter.Focus();
                cbIsActive.Visible = false;
            }



        }

        private void AddNewPersontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            _RefreshUserList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DGVGetAllUsers.CurrentRow.Cells[0].Value;
           
            
              if (MessageBox.Show($"Are you sure you want to delete this user? {UserID} ", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
              {


                    clsUsersBuisnessLayer User = clsUsersBuisnessLayer.Find(UserID);


                    if (User.UserName == "admin")
                    {
                        MessageBox.Show("TA user with full admin privileges cannot be deleted.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (clsUsersBuisnessLayer.DeleteUser(UserID))
                        {
                            MessageBox.Show("The User has been successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("The User deletion process has failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }




              }
              else
              {
                    MessageBox.Show("The User deletion process has been canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

            _RefreshUserList();




        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        { 
             string FilterColumn = "";

            switch (cbFilterBy.Text)
            {

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

            }



            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                labRecordsCount.Text = _dtUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);

            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", FilterColumn, txtFilter.Text);

                labRecordsCount.Text = DGVGetAllUsers.Rows.Count.ToString();


        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumnIsActive = "IsActive";
            switch (cbIsActive.Text)
            {
                case "Yes":
                    cbIsActive.Tag = 1;
                    break;

                case "No":
                    cbIsActive.Tag = 0;
                    break;

            }



            if (cbIsActive.Text.Trim() == "All")
            {
                _dtUsers.DefaultView.RowFilter = "";
                labRecordsCount.Text = _dtUsers.Rows.Count.ToString();
                return;
            }


            if (cbIsActive.Text == "Yes")

                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumnIsActive, cbIsActive.Tag);
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumnIsActive, cbIsActive.Tag);

            labRecordsCount.Text = DGVGetAllUsers.Rows.Count.ToString();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUserInfo = new frmUserInfo((int)DGVGetAllUsers.CurrentRow.Cells[0].Value);
            frmUserInfo.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now. It will be available later", "Note ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now. It will be available later", "Note ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmChangePassword((int)DGVGetAllUsers.CurrentRow.Cells[0].Value);
            frmChangePassword.ShowDialog();
        }
    }
}
