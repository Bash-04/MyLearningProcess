using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using VakantiePlannerModules;

namespace VakantiePlannerDAL
{
    public class OfficeDAL
    {
        private MySqlConnection databaseConnection;
        
        private string connectionString = "datasource=localhost;username=root;password=;database=vakantieplanner;";

        public List<Office> GetAllOffices()
        {
            List<Office> offices = new List<Office>();

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "SELECT location, numberOfEmployees, solicitor, solicitor2 FROM office";
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        Office office = new Office(
                            mySqlDataReader.GetString("location"),
                            mySqlDataReader.GetInt32("numberOfEmployees"),
                            mySqlDataReader.GetString("solicitor"),
                            mySqlDataReader.GetString("solicitor2"));

                        offices.Add(office);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }


            return offices;
        }

        public bool AddNewOffice(string location, string solicitor)
        {
            bool result = false;
            Office newOffice = new Office(location, solicitor);

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "INSERT INTO office (id, location, numberOfEmployees, solicitor, solicitor2) VALUES (NULL, @Location, '', @Solicitor, '');";

                    mySqlCommand.Parameters.AddWithValue("@Location", newOffice.Location);
                    mySqlCommand.Parameters.AddWithValue("@Solicitor", newOffice.Solicitor);

                    int nrOfRowsAffected = mySqlCommand.ExecuteNonQuery();
                    result = nrOfRowsAffected == 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

            return result;
        }
    }
}
