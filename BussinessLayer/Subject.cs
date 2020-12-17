using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Subject : IID<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Theory : Subject
    {
        public int Marks { get; set; }
    }

    public class Lab : Subject
    {
        public int Internals { get; set; }
    }
}
