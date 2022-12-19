using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VakantiePlannerModules;

namespace VakantiePlannerDAL
{
    public class EmployeeDAL
    {
        private MySqlConnection databaseConnection;

        private string connectionString = "datasource=localhost;username=root;password=;database=vakantieplanner;";

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "SELECT employee.name, employee.email, department.id AS departmentId, office.id AS officeId FROM employee JOIN office ON (employee.officeId=office.id) JOIN department ON (employee.departmentId=department.id)";
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        Employee employee = new Employee(
                            mySqlDataReader.GetString("name"),
                            mySqlDataReader.GetString("email"),
                            mySqlDataReader.GetInt32("departmentId"),
                            mySqlDataReader.GetInt32("officeId"));

                        employees.Add(employee);
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


            return employees;
        }

        public bool AddNewEmployee(string name, string email, int departmentId, int officeId)
        {
            bool result = false;
            Employee newEmployee = new Employee(name, email, departmentId, officeId);

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "INSERT INTO employee (id, name, email, departmentId, officeId, holidayId) VALUES (NULL, @name, @email, @departmentId, @officeId, '');";

                    mySqlCommand.Parameters.AddWithValue("@name", newEmployee.Name);
                    mySqlCommand.Parameters.AddWithValue("@email", newEmployee.Email);
                    mySqlCommand.Parameters.AddWithValue("@departmentId", newEmployee.DepartmentId);
                    mySqlCommand.Parameters.AddWithValue("@officeId", newEmployee.OfficeId);

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

        public int UpdateNumberOfEmployees(int currentOffice)
        {
            int employeeCount = 0;

            databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                if (databaseConnection.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
                    mySqlCommand.CommandText = "SELECT employee.officeId, COUNT(employee.officeId) as employeeCount FROM employee WHERE employee.officeId = @currentOffice;";
                    mySqlCommand.Parameters.AddWithValue("@currentOffice", currentOffice);

                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        employeeCount = mySqlDataReader.GetInt32("employeeCount");
                    }

                    mySqlCommand.CommandText = "UPDATE office SET numberOfEmployees = @employeeCount WHERE office.id = @currentOffice;";
                    mySqlCommand.Parameters.AddWithValue("@employeeCount", employeeCount);
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

            return employeeCount;
        }
    }
}
