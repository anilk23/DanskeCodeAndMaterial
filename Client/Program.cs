using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessLayer;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Subjects subjects = new Subjects();

            try
            {
                Theory t1 = new Theory();
                t1.ID=1;
                t1.Name = "Theory subject1";
                t1.Marks = 150;

                Lab l1 = new Lab();
                Console.WriteLine("Enter subject id");
                l1.ID = Convert.ToInt32(Console.ReadLine());
                l1.Name = "Lab1";
                l1.Internals = 30;

                subjects.Add(t1);
                subjects.Add(l1);

                foreach (Subject item in subjects.GetAllSubjets())
                {
                    Console.WriteLine(item.Name);
                }

                MyGenericClass<int, Subject> myGenericClass = new MyGenericClass<int, Subject>();
            }
            catch(DuplicateKeyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }finally
            {
                Console.WriteLine("Always executed");
                Console.ReadLine();
            }
        }
    }
}
