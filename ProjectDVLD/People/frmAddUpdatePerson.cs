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
        clsPersonBuisnessLayer Person = new clsPersonBuisnessLayer();
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears( -18);
            _FillCountriesIncomboBox();

        }

        private void _FillCountriesIncomboBox()
        {
            DataTable dtCountries = clsCountriesBuisnessLayer.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
            cbCountry.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // clsPeopleBuisnessLayer Person = new clsPeopleBuisnessLayer();

            Person.NationalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                Person.Gender = 0;
            else
                Person.Gender = 1;

            Person.Address = txtAddress.Text;
            Person.Phone = txtPhone.Text;
            Person.Email = txtEmail.Text;
           // Person.NationalityCountryID = Convert.ToInt32(cbCountry.Text);
            Person.NationalityCountryID = 0;
            //Person.ImagePath = pbPersonImage.Text;

            if (Person.Save())
            {
                MessageBox.Show($"Done {Person.PersonID}");
                lblPersonID.Text = Person.PersonID.ToString();
                lblTitle.Text = "Update Person";
            }
            else
            {
                MessageBox.Show("Error");
            }



        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                Person.Gender = 0;
                pbPersonImage.Image = Resources.Male_512;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                Person.Gender = 1;
                pbPersonImage.Image = Resources.Female_512;
            }
        }
    }
}
