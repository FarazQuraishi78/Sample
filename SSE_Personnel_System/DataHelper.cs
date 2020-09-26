using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SSE_Personnel_System
{
    class DataHelper
    {
        public DataHelper() { }

        public DataTable runSqlCommand(string sql)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                // Create a SqlCommand object.
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        // Run the query by calling ExecuteReader().
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            // Load data table to hold the retrieved data.
                            dataTable.Load(dataReader);
                            dataReader.Close();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("There was a problem with the query");
                    }
                    finally
                    {
                        // Close the connection.
                        connection.Close();
                    }
                }
            }
            return dataTable;
        }

        public void runStoredProcedure(string name, Dictionary<string, string> parameters)
        {
            // Generic function to run stored procedure
            // Takes a Dictionary list of parameter names and values
        }

        // Funtion to call the stored procedure to add an employee
        public void AddEmployee(int empId, string firstnm, string lastnm, int managerId, int roleId)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                // Create a SqlCommand, and identify it as a stored procedure.
                using (SqlCommand sqlCommand = new SqlCommand("spAddNewEmployee", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for the stored procedure and specify what to use as its value.
                    sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int));
                    sqlCommand.Parameters["@EmployeeID"].Value = empId;

                    sqlCommand.Parameters.Add(new SqlParameter("@Firstname", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@Firstname"].Value = firstnm;

                    sqlCommand.Parameters.Add(new SqlParameter("@Lastname", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@Lastname"].Value = lastnm;

                    sqlCommand.Parameters.Add(new SqlParameter("@ManagerId", SqlDbType.Int));
                    sqlCommand.Parameters["@ManagerId"].Value = managerId;

                    sqlCommand.Parameters.Add(new SqlParameter("@RoleId", SqlDbType.Int));
                    sqlCommand.Parameters["@RoleId"].Value = roleId;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("The new employee has been added to the system");
                    }
                    catch
                    {
                        MessageBox.Show("Employee Account could not be created, must use a new Employee Id");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        static public string GetConnectionString()
        {
            // use ConfigurationManager to read the database connection setting from the App.config file

            string connString = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SSquaredEnterprises"];

            // If found, return the connection string.
            if (settings != null)
                connString = settings.ConnectionString;

            return connString;
        }
    }
}
