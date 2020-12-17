using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNewFeatures
{
    // delegate long MyDelegate(int n1, int n2);

   static class MyUtilities
    {
        public static string Greet(this string arg)
        {
            return "Welcome " + arg;
        }
    }
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student { StudentID = 1, Name = "Student1" };

            List<Student> students = new List<Student>()
            {
                new Student { StudentID = 1, Name = "Student1" },
                new Student { StudentID = 2, Name = "Student2" },
                new Student { StudentID = 3, Name = "Student3" },
                new Student { StudentID = 4, Name = "Student4" }
            };

            Dictionary<int, Student> dict = new Dictionary<int, Student>
            {
                {1,new Student { StudentID = 1, Name = "Student1" } },
                {2,new Student { StudentID = 2, Name = "Student2" } }
            };

            HashSet<string> hset = new HashSet<string>()
            {
                "Item1",
                "Item2",
                "Item3",
                "Item2"
            };
            Console.WriteLine(hset.Count());
            foreach (var item in hset)
            {
                Console.WriteLine(item);
            }

            //var i = 10;
            //var st = "Hello";
            //var sal = 333333.44;

           var emp = new { EmpId = 1, Name = "Name1", DOB = new DateTime(1999, 1, 20) };


            // MyDelegate del = new MyDelegate(Add);

            //MyDelegate del = delegate (int n1, int n2)
            // {
            //     return n1 + n2;
            // };



            // Console.WriteLine(del.Invoke(333,444));
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Action<Student> action = delegate (Student item)
            //  {
            //      Console.WriteLine(item.Name);
            //  };

            Func<int,int,long> del = (n1, n2) => n1 + n2;


            students.ForEach( ( item)=>  Console.WriteLine(item.Name));
           

            Console.WriteLine(del.Invoke(333,444));

            string st = "Danske";
            Console.WriteLine(st.Greet());
        }

        //static long Add(int n1,int n2)
        //{
        //    return n1 + n2;
        //}
    }
}
