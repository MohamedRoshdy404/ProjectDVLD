using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountriesDataAccess
    {





        public static DataTable GetAllCountries()
        {

            DataTable dtCountries = new DataTable();


            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = @"SELECT * FROM Countries ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dtCountries.Load(reader);
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }





                return dtCountries;
            }











        }















    }
}
