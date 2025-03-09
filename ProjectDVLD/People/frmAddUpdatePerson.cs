using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;
using ProjectDVLD.Properties;

namespace ProjectDVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;
        private int _PersonID = -1;
        clsPersonBuisnessLayer _Person;
        


        //clsPersonBuisnessLayer Person = new clsPersonBuisnessLayer();
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }



        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            _FillCountriesIncomboBox();
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPersonBuisnessLayer();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked)        
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);


            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";




        }


        private void _LoadData()
        {
            _Person = clsPersonBuisnessLayer.FindByPersonID( _PersonID);


            if (_Person == null)
            {
                MessageBox.Show($"No Person With ID =  {_PersonID} " , "Person NOT Found" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            txtNationalNo.Text = _Person.NationalNo.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;

            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

            llRemoveImage.Visible = (_Person.ImagePath != "");

        }


        private void _FillCountriesIncomboBox()
        {
            DataTable dtCountries = clsCountriesBuisnessLayer.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gender = 0;
            else
                _Person.Gender = 1;

           _Person.Address = txtAddress.Text;
           _Person.Phone =   txtPhone.Text;
            _Person.Email =   txtEmail.Text;
            // Person.NationalityCountryID = Convert.ToInt32(cbCountry.Text);
            _Person.NationalityCountryID = 1;
            //Person.ImagePath = pbPersonImage.Text;

            if (_Person.Save())
            {
                MessageBox.Show($"Data Seved Successfully {_Person.PersonID}" , "Done Seved" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                lblPersonID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Update Person";
            }
            else
            {
                MessageBox.Show("Data NOT Seved" , "Error" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
            }



        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                _Person.Gender = 0;
                pbPersonImage.Image = Resources.Male_512;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                _Person.Gender = 1;
                pbPersonImage.Image = Resources.Female_512;
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (Mode == enMode.Update)
                _LoadData();





        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp ";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }


        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
