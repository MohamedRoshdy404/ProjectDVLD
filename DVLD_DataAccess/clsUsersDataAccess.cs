using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsUsersDataAccess
    {




        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();



            SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString);
            string query = "select * from Users";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                 Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }





            return dtUsers;
        }


        
        public static DataTable GetInfoUsers()
        {
            DataTable dtUsers = new DataTable();



            SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString);
            string query = "SELECT Users.UserID,  People.PersonID,  People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName as FullName,Users.UserName, Users.Password, Users.IsActive FROM   People INNER JOIN  Users ON People.PersonID = Users.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                 Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }





            return dtUsers;
        }






    }
}
