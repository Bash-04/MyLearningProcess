using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VakantiePlannerModules;

namespace VakantiePlannerDAL
{
    public class HolidayDAL
    {
        private MySqlConnection databaseConnection;

        private string connectionString = "datasource=localhost;username=root;password=;database=vakantieplanner;";

        public List<Holiday> GetAllHolidays()
        {
            List<Holiday> holidays = new List<Holiday>();

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "SELECT employeeId, startDate, endDate, description FROM holiday;";
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        //Holiday holiday = new Holiday(
                        //    mySqlDataReader.GetInt32("employeeId"),
                        //    mySqlDataReader.GetDateTime("startDate"),
                        //    mySqlDataReader.GetDateTime("endDate"),
                        //    mySqlDataReader.GetTimeSpan("duration"));
                        Holiday holiday = new Holiday(
                            mySqlDataReader.GetInt32("employeeId"),
                            mySqlDataReader.GetDateTime("startDate"),
                            mySqlDataReader.GetDateTime("endDate"),
                            mySqlDataReader.GetString("description"));

                        holidays.Add(holiday);
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


            return holidays;
        }
    }
}
