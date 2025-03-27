using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDVLD.Global_Classes
{
    public class  clsUserInfo
    {

         public static int PersonID { get; set; }
         public static int UserID { get; set; }
         
         public static string FirstName { get; set; }
         public static string SecondName { get; set; }
         public static string ThirdName { get; set; }
         public static string LastName { get; set; }
         public static string FullName
         {
             get
             {
                 return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
             }
         }
         public static string UserName { get; set; }
         public static string Password { get; set; }
         public static byte IsActive { get; set; }









    }
}
