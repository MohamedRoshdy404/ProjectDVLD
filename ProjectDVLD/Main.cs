using ProjectDVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ProjectDVLD.Users;
using ProjectDVLD.Global_Classes;
using ProjectDVLD.Login;
using ProjectDVLD.Applications.Application_Types;

namespace ProjectDVLD
{
    public partial class Main : Form
    {
        frmLogin _frmLogin;
        public Main(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtxtUserName.Text =  clsUserInfo.UserName.ToUpper();
        }

        private void peopalToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            Form frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }

        private void ssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frmShowPersonInfo = new frmFindPerson();
            //frmShowPersonInfo.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGetAllUsers = new frmGetAllUsers();
            frmGetAllUsers.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUserInfo.CurrentUser = null;
            _frmLogin.ShowDialog();
            this.Dispose();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUserInfo = new frmUserInfo(clsUserInfo.UserID);
            frmUserInfo.ShowDialog();    
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmChangePassword(clsUserInfo.UserID);
            frmChangePassword.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmListApplicationTypes = new frmListApplicationTypes();
            frmListApplicationTypes.ShowDialog();
        }
    }
}
