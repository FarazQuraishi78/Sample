using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSE_Personnel_System
{
    public partial class Manager : Form
    {

        public Manager()
        {
            InitializeComponent();
            PopulateManagerList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Form frm = new AddEmployee();
            frm.Show();
        }

        private void cmbManagerNm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = DataHelper.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Define a t-SQL query to get direct reports for the selected manager 
                const string sql = "SELECT emp_id, first_name, last_name " +
                    "FROM employee WHERE emp_id in (SELECT employee_id FROM employee_relationship where manager_id = @managerID)";

                // Create a SqlCommand object.
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    // Define the @orderID parameter and set its value.
                    sqlCommand.Parameters.Add(new SqlParameter("@managerID", SqlDbType.Int));
                    if (this.cmbManagerNm.ValueMember != "")
                        sqlCommand.Parameters["@managerID"].Value = Int32.Parse(this.cmbManagerNm.SelectedValue.ToString());
                    else
                        sqlCommand.Parameters["@managerID"].Value = 1001;

                    try
                    {
                        connection.Open();

                        // Run the query by calling ExecuteReader().
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            // Create a data table to hold the retrieved data.
                            DataTable dataTable = new DataTable();
                            dataTable.Load(dataReader);

                            // Display the data from the data table in the data grid view.
                            this.dgvEmployeeList.DataSource = dataTable;

                            dataReader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The data for the selected manager could not be found");
                    }
                    finally
                    {
                        // Close the connection.
                        connection.Close();
                    }
                }
            }
        }

        private void PopulateManagerList()
        {
            // Define a t-SQL query to get list of managers
            const string sql = "SELECT emp_id, first_name + ' ' + last_name AS name from employee where emp_id in (select manager_id from employee_relationship)";
            DataTable results = new DataTable();
            DataHelper dh = new DataHelper();
            results = dh.runSqlCommand(sql);

            // set the list for the manager name control
            this.cmbManagerNm.DataSource = results;
            this.cmbManagerNm.DisplayMember = "name";
            this.cmbManagerNm.ValueMember = "emp_id";
        }

    }
}
