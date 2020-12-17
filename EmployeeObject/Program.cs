using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObject
{
    class Program
    {
        //UI layer
        static void Main(string[] args)
        {
            Employee emp1, emp2;
            DateTime dt;
            emp1 = new Employee();
            emp1.EmployeeID = 3434;
            emp1.Name = "Name1";
            emp1.Gender = Gender.Male;
            Salary sal;

            sal = new Salary(10000, 30, 22);
            
            emp1.Salary = sal;

            emp2 = new Employee(1234, "Name2");
            //emp2.EmployeeID = 1234;
            //emp2.Name = "Name2";
              emp2.Salary = sal;
            emp2.Gender = Gender.Female;

            if (true)
            {
                //Employee emp3 = new Employee();
            }

            Console.WriteLine(emp1.Display());
            Console.WriteLine(emp2.Display());
           
            Console.WriteLine("Employee count is {0}",Employee.Counter);

            emp1.Dispose();
            emp2.Dispose();

           emp1 = null;
            emp2 = null;

            //  GC.Collect();

           
            Console.ReadLine();
        }
    }
}
