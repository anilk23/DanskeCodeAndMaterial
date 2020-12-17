using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
namespace ReflectionDemo
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property,AllowMultiple =true)]
    class MetadataAttribute : System.Attribute
    {

        public MetadataAttribute(string author,string comment)
        {
            Author = author;
            Comment = comment;
        }

        public string Author { get; set; }
        public string Comment { get; set; }
        public string CreateDate { get; set; }
    }

    [Metadata("Author1","This is a class to do math operations",CreateDate ="12/16/2020")]
    class MathClass
    {
        public MathClass()
        {

        }
        public MathClass(int n1,int n2)
        {

        }
        private void PrivateM()
        {

        }

        [Metadata("Author1", "This is property to accept number1", CreateDate = "12/17/2020")]
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        [Metadata("Author2", "This is method which adds two numbers", CreateDate = "12/17/2020")]
        public long Add()
        {
            return Num1 + Num2;
        }
        public long Multiply()
        {
            return Num1 * Num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            //   Console.WriteLine(assembly.FullName);
            //AssemblyName asmname = assembly.GetName();
            //Version ver = asmname.Version;
            //Console.WriteLine(ver.Major + " " + ver.Minor);

            //AssemblyName[] asms = assembly.GetReferencedAssemblies();

            //foreach (var item in asms)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //Type[] types = assembly.GetTypes();
            //foreach (var item in types)
            //{
            //    Console.WriteLine(item.FullName);
            //    if(item.Name.ToLower() == "mathclass")
            //    {
            //        MemberInfo[] members = item.GetMembers();
            //        foreach (var item1 in members)
            //        {
            //            Console.WriteLine($"Name {item1.Name}, Type {item1.MemberType}");
            //        }
            //    }
            //}

            //execute add method using reflection

            Type mathtype = assembly.GetType("reflectiondemo.mathclass", false, true);

            object[] classattr = assembly.GetType("reflectiondemo.mathclass", false, true).GetCustomAttributes(false);

            MetadataAttribute attr = (MetadataAttribute)classattr[0];

            Console.WriteLine($"{attr.Author} and {attr.CreateDate}");

            Console.WriteLine(mathtype.FullName);

            object mc = System.Activator.CreateInstance(mathtype) ;

            PropertyInfo pinum1 = mathtype.GetProperty("Num1");
            PropertyInfo pinum2 = mathtype.GetProperty("Num2");

            pinum1.SetValue(mc, 10);
            pinum2.SetValue(mc, 30);

            MethodInfo miadd = mathtype.GetMethod("Add");
            long result = (long)miadd.Invoke(mc, null);

            Console.WriteLine(result);
        }
    }
}
