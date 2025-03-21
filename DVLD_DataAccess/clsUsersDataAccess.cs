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
            string query = "SELECT Users.UserID,  People.PersonID,  People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName as FullName,Users.UserName, Users.IsActive FROM   People INNER JOIN  Users ON People.PersonID = Users.PersonID";

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


        public static int AddNewUser(int PersonID , string UserName , string Password , short IsActive)
        {

            int UserID = -1;



            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = "INSERT INTO Users (PersonID , UserName , Password , IsActive) values (@PersonID , @UserName , @Password , @IsActive ) SELECT SCOPE_IDENTITY()";

               using (SqlCommand command = new SqlCommand(query, connection))
                {


                    command.Parameters.AddWithValue("PersonID" , PersonID);
                    command.Parameters.AddWithValue("UserName", UserName);
                    command.Parameters.AddWithValue("Password", Password);
                    command.Parameters.AddWithValue("IsActive", IsActive);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }
                    }
                    catch (SqlException ex) 
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close ();
                    }

                }



            }

            return UserID;

        }


               
        public static int UpdateUser(int PersonID , string UserName , string Password , short IsActive)
        {

            int UserID = -1;



            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = "UPDATE Users SET UserName = @UserName, Password = @Password, IsActive = @IsActive WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("UserName", UserName);
                    command.Parameters.AddWithValue("Password", Password);
                    command.Parameters.AddWithValue("IsActive", IsActive);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }
                    }
                    catch (SqlException ex) 
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close ();
                    }

                }



            }

            return UserID;

        }




                       
        public static bool FindUser(int UserID, ref int PersonID ,ref string UserName , ref string Password ,ref byte IsActive)
        {

            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = "select PersonID , UserName , Password , IsActive  from Users WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("UserID", UserID);


                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                UserName = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                IsActive = Convert.ToByte(reader["IsActive"]);


                            }
                            else
                            {
                               // Console.WriteLine("No data found for the given UserID.");
                            }


                        }

                    }
                    catch (SqlException ex) 
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close ();
                    }

                }



            }

            return IsFound;

        }






    }
}
