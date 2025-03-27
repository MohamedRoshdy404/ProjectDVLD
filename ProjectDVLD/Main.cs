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

namespace ProjectDVLD
{
    public partial class Main : Form
    {


        private string path = "data.txt";
        private string spr = "#//#";
        public Main()
        {
            InitializeComponent();

            //dateTimePicker1.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtxtUserName.Text = clsUserInfo.UserName;
        }

        private void peopalToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            Form frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }

        private void ssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmShowPersonInfo = new frmFindPerson();
            frmShowPersonInfo.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGetAllUsers = new frmGetAllUsers();
            frmGetAllUsers.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.Hide();

            Form formLogin = new frmLogin();
            formLogin.ShowDialog();

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
    }
}
