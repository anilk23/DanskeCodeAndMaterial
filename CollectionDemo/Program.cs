using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace CollectionDemo
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
           al.Add("Item1");
            al.Add("Item2");
            al.Add("Item3");
            al.Add("Item4");
            al.Insert(1,"------");

            string[] strs = { "Item5", "Item6", "Item7" };
            al.AddRange(strs);

            // al.RemoveAt(2);

            int i = 10;
            al.Add(i);//boxing is happneing and it is implicit
            i =(int) al[8];//un-boxing is explicit

            Student s = new Student { StudentId = 1, Name = "Student1" };

            al.Add(s);//up-casting
            s = al[9] as Student;

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count {al.Count} and Capacity {al.Capacity}");

            ArrayList alStudents = new ArrayList();
            alStudents.Add(new Student { StudentId = 1, Name = "Student1" });
            alStudents.Add(new Student { StudentId = 2, Name = "Student2" });
            alStudents.Add(new Student { StudentId = 3, Name = "Student3" });
            alStudents.Add(new Student { StudentId = 4, Name = "Student4" });

            foreach (Student item in alStudents)
            {
                Console.WriteLine(item.Name);
            }

            Hashtable ht = new Hashtable();
            ht.Add(1, new Student { StudentId = 1, Name = "Student1" });
            ht.Add(2, new Student { StudentId = 2, Name = "Student2" });
            ht.Add(3, new Student { StudentId = 3, Name = "Student3" });
            ht.Add(4, new Student { StudentId = 4, Name = "Student4" });

            s = ht[3] as Student;

            foreach (Student item in ht.Values)
            {
                Console.WriteLine(item.Name);
            }


            List<int> listint = new List<int>();
            listint.Add(10);
            i = listint[0];

            List<Student> stds = new List<Student>();
            stds.Add(new Student { StudentId = 1, Name = "Student1" });
            s = stds[0];

            Dictionary<int, Student> dictstds = new Dictionary<int, Student>();
            dictstds.Add(1, new Student { StudentId = 1, Name = "Std1" });

        }
    }
}
