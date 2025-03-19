using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsUsersBuisnessLayer
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID {  get; set; }
        public int UserID {  get; set; }
         
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        private string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short IsActive { get; set; }




        public clsUsersBuisnessLayer()
        {
            this.PersonID = -1;
            this.UserID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.UserName = "";
            this.Password = "";
            this.IsActive = 0;

            Mode = enMode.AddNew;

        }

             
        public clsUsersBuisnessLayer(int PersonID , int UserID, string FirstName, string SecondName, string ThirdName, string LastName, string UserName, string Password, short IsActive)
        {
            this.PersonID   = PersonID;
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName  ; 
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;


            Mode = enMode.Update;

        }




        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
                
        public static DataTable GetInfoUsers()
        {
            return clsUsersDataAccess.GetInfoUsers();
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID , this.UserName , this.Password , this.IsActive);

            return (this.UserID != -1);
        }




        public bool Save()
        {

            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   



                default:

                    return false;
            }





        }



    }
}
