using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_Personnel_System
{
    class EmployeeEntity : BaseEntity
    {

        private int empId { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int managerId { get; set; }
        private int roleId { get; set; }

        public EmployeeEntity(int eId, string firstNm, string lastNm, int mgrId, int rId) 
        {
            this.empId = eId;
            this.firstName = firstNm;
            this.lastName = lastNm;
            this.managerId = mgrId;
            this.roleId = rId;
        }

        public override void SaveData()
        {
            // Call DataHelper method to call stored procedure to add employee
            DataHelper dh = new DataHelper();
            dh.AddEmployee(this.empId, this.firstName, this.lastName, this.managerId, this.roleId);
        }

        public override void GetData()
        {
            // Call DataHelper method to get employee record
            DataHelper dh = new DataHelper();
            string sql = "select emp_id, first_name, last_name from employee where emp_id = " + this.empId;
            dh.runSqlCommand(sql);
        }
    }
}
