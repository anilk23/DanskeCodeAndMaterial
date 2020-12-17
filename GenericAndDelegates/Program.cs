using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;
            Swap<int>(ref n1, ref n2);
            Console.WriteLine($"Value of n1 {n1} and n2 {n2}");

            string s1 = "Hello", s2 = "world";
            Swap<string>(ref s1, ref s2);

            Console.WriteLine(Max<int>(10, 20));

        }

        static void Swap<T>(ref T item1,ref T item2) //where T : class
        {
            T temp;
            temp = item2;
            item2 = item1;
            item1 = temp;
            Console.WriteLine($"Value of item1 {item1} and item2 {item2}");
        }

        static T Max<T>(T n1,T n2) where T : IComparable<T>
        {
            if (n1.Equals(default(T)) || n2.Equals(default(T)))
                throw new Exception("cannot find the max");

            if (n1.CompareTo(n2) > 0)
                return n1;
            else
                return n2;
        }
    }
}
