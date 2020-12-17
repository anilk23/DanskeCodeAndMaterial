using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObject
{
    //access modifers
    //private,public ,internal,protected and internal protected
   internal partial class Employee
    {

        public Employee()
        {
           // EmployeeID = 0;
            this.m_strName = "";
            s_intCounter++;
        }

        public Employee(int eid,string name) : this()
        {
            EmployeeID = eid;
            Name = name;
          //  Salary = 10000;
        }
     
        private static int s_intCounter;

        public static int Counter
        {
            get
            {
                return s_intCounter;
            }
        }
        private int m_intEmployeeID;

        public int EmployeeID
        {
            get
            {
                return m_intEmployeeID;
            }
           set
            {
                if (value > 0)
                    m_intEmployeeID = value;
                else
                    throw new Exception("Employeeid invalid");
            } 
        }

        private string m_strName;

        public string Name
        {
            get { return m_strName; }
            set {
                if (value.Length > 3)
                    m_strName = value;
                else
                    throw new Exception("Name should be atleast 3 chars");
            }
        }

        private Salary salary;

        public Salary Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public void Dispose()
        {
            sb = null;
            Console.WriteLine("Release both critical and non-critical resources here");
        }

        //Resources
        //Non-critical
        //Arrays,Collections,Objects

        //Critical
        //DB connection,FileHandle,Graphic handles,pointers,COM interop

        //Finalize()
        ~Employee()
        {
            Console.WriteLine("Destructors are in-deterministic in .net");
        }
    }
}
