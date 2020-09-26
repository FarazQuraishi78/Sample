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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            PopulateManagerList();
            PopulateRoleNames();
        }

        private void cmbManagerNm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedManagerId = Int32.Parse(this.cmbManagerNm.SelectedValue.ToString());
            int selectedRoleId = Int32.Parse(this.lsbRoleNm.SelectedValue.ToString());

            // Create employee entity and save the record to the database
            EmployeeEntity emp = new EmployeeEntity(Int32.Parse(txtEmployeeId.Text), txtFirstNm.Text, txtLastNm.Text, selectedManagerId, selectedRoleId);
            emp.SaveData();

            // clear out the values from the UI
            ClearValues();
        }

        private void PopulateManagerList()
        {
            // Define a t-SQL query to get list of employees that can be selected as a manager
            const string sql = "SELECT emp_id, first_name + ' ' + last_name AS name from employee";
            DataTable results = new DataTable();
            DataHelper dh = new DataHelper();
            results = dh.runSqlCommand(sql);

            // bind to the ManagerNm control
            this.cmbManagerNm.DataSource = results;
            this.cmbManagerNm.DisplayMember = "name";
            this.cmbManagerNm.ValueMember = "emp_id";
        }

        private void PopulateRoleNames()
        {
            // Define a t-SQL query to get list of roles from database table
            const string sql = "SELECT id, role_name from role";
            DataTable results = new DataTable();
            DataHelper dh = new DataHelper();
            results = dh.runSqlCommand(sql);

            // bind the results to the RoleNm control
            this.lsbRoleNm.DataSource = results;
            this.lsbRoleNm.DisplayMember = "role_name";
            this.lsbRoleNm.ValueMember = "id";
        }

        private void ClearValues()
        {
            // Clear out the values from the input fields
            this.txtEmployeeId.Text = null;
            this.txtFirstNm = null;
            this.txtLastNm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
