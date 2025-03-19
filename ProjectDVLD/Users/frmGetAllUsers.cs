using DVLD_Buisness;
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

        private void GetAllUsers_Load(object sender, EventArgs e)
        {
            DGVGetAllUsers.DataSource = clsUsersBuisnessLayer.GetInfoUsers();
            labRecordsCount.Text = DGVGetAllUsers.Rows.Count.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
        }

    }
}
