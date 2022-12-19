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
    public class DepartmentDAL
    {
        private MySqlConnection databaseConnection;

        private string connectionString = "datasource=localhost;username=root;password=;database=vakantieplanner;";

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "SELECT name, department.numberOfEmployees FROM department";
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        Department department = new Department(
                            mySqlDataReader.GetString("name"));

                        departments.Add(department);
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


            return departments;
        }
    }
}
