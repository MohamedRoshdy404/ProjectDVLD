using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsPersonDataAccess
    {


        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = @"SELECT * FROM People ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dataTable.Load(reader);
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }


            }

            return dataTable;

        }



        public static int AddNewPerson(string NationalNo , string FirstName , string SecondName , string ThirdName  , string LastName , DateTime DateOfBirth , byte Gender , string Address , string Phone , string Email , int NationalityCountryID , string ImagePath)
        {

            int PersonID = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @"   
                        INSERT INTO People (NationalNo , FirstName , SecondName , ThirdName , LastName , DateOfBirth , Gender , Address , Phone , Email , NationalityCountryID , ImagePath)
			                        VALUES (@NationalNo , @FirstName , @SecondName , @ThirdName , @LastName , @DateOfBirth ,@Gender ,@Address , @Phone , @Email , @NationalityCountryID , @ImagePath   ) 
                                    SELECT SCOPE_IDENTITY();
                                    ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (Email != null)
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", System.DBNull.Value);


                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    
                    if (ImagePath != null)
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }


            }

            return PersonID;

        }









    }
}
