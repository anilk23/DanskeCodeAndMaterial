using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DelegateDemo
{
    public delegate long MathDelegate(int n1, int n2);
    delegate void MCDelegate();
    class MathClass
    {
        public long Add(int n1,int n2)
        {
            Thread.Sleep(5000);
            return n1 + n2;
        }
        public static long Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        public void M1()
        {
            Console.WriteLine("M1 called");
        }
        public static void M2()
        {
            Console.WriteLine("M2 called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathClass math = new MathClass();

            MCDelegate del = new MCDelegate(math.M1);
            del += new MCDelegate(MathClass.M2);

            del += new MCDelegate(math.M1);

            del();
            del -= new MCDelegate(math.M1);
            del();

            MathDelegate del1, del2;

            del1 = new MathDelegate(math.Add);

            del2 = new MathDelegate(MathClass.Multiply);

            //MyInovoke(del1);

            AsyncCallback mycallback = delegate (IAsyncResult ir)
            {
                
                long result = del1.EndInvoke(ir);

                Console.WriteLine($"The add result done async is {result}");
            };

            IAsyncResult iar = del1.BeginInvoke(111, 333, mycallback, null);

            Console.WriteLine(del2.Invoke(333,455));

            
            Console.ReadLine();
                
         }

        //static void CallbackHandler(IAsyncResult ir)
        //{
        //    MathDelegate del = ir.AsyncState as MathDelegate;
        //    long result = del.EndInvoke(ir);

        //    Console.WriteLine($"The add result done async is {result}");
        //}

        static void MyInovoke(MathDelegate del)
        {
            Console.WriteLine(del.Invoke(111,222));
        }
    }
}
