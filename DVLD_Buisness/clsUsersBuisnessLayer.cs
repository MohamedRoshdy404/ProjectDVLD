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


        int PersonID {  get; set; }
        int UserID {  get; set; }

        string FirstName { get; set; }
        string SecondName { get; set; }
        string ThirdName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        short IsActive { get; set; }




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

        }

             
        private clsUsersBuisnessLayer(int PersonID , int UserID, string FirstName, string SecondName, string ThirdName, string LastName, string UserName, string Password, short IsActive)
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


        }




        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
                
        public static DataTable GetInfoUsers()
        {
            return clsUsersDataAccess.GetInfoUsers();
        }






    }
}
