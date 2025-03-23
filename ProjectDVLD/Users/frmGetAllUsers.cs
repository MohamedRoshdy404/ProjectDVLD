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

        private void _RefreshUserList()
        {
            DGVGetAllUsers.DataSource = clsUsersBuisnessLayer.GetInfoUsers();
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
            txtFilter.Visible = (cbFilterBy.Text != "None");
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

                    if (clsUsersBuisnessLayer.DeleteUser(UserID))
                    {
                        MessageBox.Show("The User has been successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("The User deletion process has failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


              }
              else
              {
                    MessageBox.Show("The User deletion process has been canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

            _RefreshUserList();




        }
    }
}
