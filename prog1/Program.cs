using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            int EmployeeID = 0;
            string Name = "";
            System.DateTime DOB = DateTime.Now;
            double Salary = 0.0;

            Console.WriteLine("Enter employee id");
            EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name");
            Name = Console.ReadLine();


            Console.WriteLine("Enter employee salary");
            Salary = Convert.ToDouble(Console.ReadLine());

            string msg = "Employee ID " + EmployeeID + "\n";
            msg += "Name " + Name + "\n";
            msg += "Salary " + Salary + "\n";

            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
