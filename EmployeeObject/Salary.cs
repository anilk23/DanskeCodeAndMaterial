using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObject
{
    struct Salary
    {
        public double Basic;
        public short Ta, Da;

        public Salary(double bas,short ta,short da)
        {
            Basic = bas;
            Ta = ta;
            Da = da;
        }

        public double GetNetSalary()
        {
            return Basic + (Basic * (Convert.ToDouble(Ta) / 100)) + (Basic * (Convert.ToDouble(Da) / 100));
        }
    }
}
