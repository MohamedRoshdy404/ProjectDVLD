using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassDataAccess
    {





        public static DataTable GetAllLicenseClasses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString);

            string query = "SELECT * FROM LicenseClasses order by ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }




        public static bool FindLicenseClassesByClassName(string ClassName ,  ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select LicenseClassID , ClassName , ClassDescription , MinimumAllowedAge , DefaultValidityLength , ClassFees from LicenseClasses where ClassName = @ClassName ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", ClassName);


                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassDescription = reader["ClassDescription"].ToString();
                                MinimumAllowedAge = (byte) reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte) reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return isFound;
        }





        
        public static bool Find(int LicenseClassID, ref string ClassName,  ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select LicenseClassID , ClassName , ClassDescription , MinimumAllowedAge , DefaultValidityLength , ClassFees from LicenseClasses where LicenseClassID = @LicenseClassID ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassName = reader["ClassName"].ToString();
                                ClassDescription = reader["ClassDescription"].ToString();
                                MinimumAllowedAge = (byte) reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte) reader["DefaultValidityLength"];
                                ClassFees = Convert.ToDecimal(reader["ClassFees"]);


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return isFound;
        }












    }
}
