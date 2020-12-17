using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObject
{
   internal partial  class Employee
    {

        private Gender gender;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        StringBuilder sb = null;
        public string Display()
        {
            sb = new StringBuilder();
            sb.Append("Employee id " + this.EmployeeID + "\n");
            sb.Append("Employee name " + this.Name + "\n");
            sb.AppendFormat("Employee salary {0}", this.Salary.GetNetSalary());
            if (gender == Gender.Male)
                sb.Append("Gender Male");
            else
                sb.Append("Gender Female");
            return sb.ToString();
        }
    }
}
