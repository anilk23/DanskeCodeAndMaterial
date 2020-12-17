using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    
    class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public double Salary { get; set; }
        public int DeptId { get; set; }
    }
    class Program
    {
        static List<Dept> depts=new List<Dept>();
        static List<Emp> emps = new List<Emp>();
        static void Main(string[] args)
        {
            LoadData();

            var allemps = from Dept dep in depts
                                       join Emp em in emps
                                       on dep.Id equals em.DeptId
                                       //where em.Salary > 20000 && em.DOB > new DateTime(2001, 1, 1)
                                       orderby em.DOB descending
                                       select new
                                       {
                                           Name=em.Name,
                                           DOB=em.DOB,
                                           Salary=em.Salary,
                                           DeptName=dep.Name
                                       };

            //Func<Emp, DateTime> sortondob = (emp) => emp.DOB;
            //IEnumerable<Emp> allemps = emps
            //                               .Where((emp)=> emp.Salary >20000 && emp.DOB > new DateTime(2001, 1, 1))
            //                            .OrderByDescending(sortondob);

            double maxsal = emps.Max((emp) => emp.Salary);

            Console.WriteLine(maxsal);

            foreach (var item in allemps)
            {
                Console.WriteLine($"{item.Name}     {item.DOB.ToShortDateString()}     {item.DeptName}     {item.Salary}");
            }

        }

        static void LoadData()
        {
            depts.Add(new Dept { Id = 10, Name = "Accounts" });
            depts.Add(new Dept { Id = 20, Name = "Production" });
            depts.Add(new Dept { Id = 30, Name = "Sales" });


            emps.Add(new Emp { Id = 1, Name = "Name1", DOB = new DateTime(1999, 1, 10), DeptId = 10, Salary = 10000 });
            emps.Add(new Emp { Id = 2, Name = "Name2", DOB = new DateTime(2002, 7, 30), DeptId = 20, Salary = 20000 });
            emps.Add(new Emp { Id = 3, Name = "Name3", DOB = new DateTime(1995, 4, 29), DeptId = 30, Salary = 30000 });
            emps.Add(new Emp { Id = 4, Name = "Name4", DOB = new DateTime(1999, 8, 23), DeptId = 10, Salary = 40000 });
            emps.Add(new Emp { Id = 5, Name = "Name5", DOB = new DateTime(2005, 1, 10), DeptId = 20, Salary = 50000 });
        }
    }
}
