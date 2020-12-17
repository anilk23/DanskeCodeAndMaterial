using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndArrays
{
  abstract  class Shape
    {
        protected int NoOfPoints;

        public abstract void Draw();
        
    }
    class Square : Shape
    {
        public Square()
        {
            NoOfPoints = 4;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {NoOfPoints} sided square" );
        }
    }
    class Pentagon : Shape
    {
        public Pentagon()
        {
            NoOfPoints = 5;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {NoOfPoints} sided pentagon");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Pentagon();
            s.Draw();


            string[] mystrings = { "Mon", "Tue", "Wed", "Thru", "Fri" };
            
            Console.WriteLine($"Length {mystrings.Length} , Rank {mystrings.Rank}, {mystrings[2]}");

            int[] myints = new int[10];
            for (int i = 0; i < myints.Length; i++)
            {
                myints[i] = (i + 1);
            }
            int n;
            Print(mystrings.GetEnumerator());

            string s1 = "1234";
            int n1;
           if( int.TryParse(s1,out n1))
            {
                n1 += 100;
            }

            Print(myints.GetEnumerator());

            Square[] squares = new Square[2];
            squares[0] = new Square();
            squares[1] = new Square();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Square();
            shapes[1] = new Pentagon();

            Print(shapes.GetEnumerator());

            string[,] twod = new string[2, 2];
            twod[0, 0] = "item111";
            twod[0, 1] = "item222";


            string[][] jagged = new string[2][];
            jagged[0] = new string[2] { "ITem11", "Item33" };
            jagged[1]= new string[4] { "ITem11", "Item33","Item44","Item55" };

        }

        static void Print(System.Collections.IEnumerator ie)
        {
            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //}
           while( ie.MoveNext())
            {
                if(ie.Current is Shape)
                {
                    Shape s = ie.Current as Shape;
                    s.Draw();
                }else
                Console.WriteLine(ie.Current);
            }
        }
    }
}
