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

namespace ProjectDVLD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //dateTimePicker1.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }
    }
}
