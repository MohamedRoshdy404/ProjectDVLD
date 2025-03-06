using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsPersonBuisnessLayer
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }





        public clsPersonBuisnessLayer()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 0;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

               
        public clsPersonBuisnessLayer(string NationalNo , string FirstName , string SecondName , string ThirdName , string LastName , DateTime DateOfBirth, byte Gender, string Address , string Phone , string Email , int NationalityCountryID , string ImagePath)
        {
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }








        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.NationalNo,this.FirstName , this.SecondName , this.ThirdName , this.LastName , this.DateOfBirth , this.Gender , this.Address , this.Phone , this.Email , this.NationalityCountryID , this.ImagePath );
            return (this.PersonID != -1);
        }




        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }





        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                //case enMode.Update:

                //    return _UpdateClientByID();

                default:
                    return false;

            }



        }







    }
}
