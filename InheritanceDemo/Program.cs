using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("ctor of base called");
        }

        public void Name()
        {
            Console.WriteLine("Name of base called");
        }
        public  void DOB()
        {
            Console.WriteLine("DOB of base called");
        }

        private void PrivateM()
        {

        }

        protected void ProtectedM()
        {
            Console.WriteLine("ProtectedM()");
        }

        protected internal void PI()
        {
            Console.WriteLine("PI()");
        }
    }
    class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("ctor of derived called");
        }
        public void EmpId()
        {
            Console.WriteLine("EmpID called");
        }
        public new void DOB()
        {
            Console.WriteLine("DOB of derived called");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();//early binding
            obj.DOB();

            Employee obj1 = new Employee();//early binding
            obj1.DOB();
            
            //late bound polymorphisum
            Person obj3 = new Employee();//up-casting it is implicit
            obj3.DOB();

            //Employee obj5 =(Employee) obj3;//down-casting it is explicit
            Employee obj5 = obj3 as Employee;//dynamic casting in c#

            if(obj5 !=null)
                obj5.EmpId();

            Object obj4 = new Employee();//up-casting it is implicit
            Employee obj6 = (Employee)obj4;
           

        }
    }
}
