using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NamingArgument
    {
        #region Bai 1
        /*static void Main()
        {
            int MSV = 18190102;
            string name = "Tu";
            string addRess = "Long Bien";
            int age = 23;
            double gpa = 8.4;
            string speciaLized = "CNTT";
            Data(MSV, fullName: name, addRess,age,gpa);
            Data(MSV,fullName: name);
        }
        static void Data(int MSV, string fullName,string addRess = "Viet Nam", int age = 18, double gpa =5.5,string speciaLized = "CNTT" )
        {
            Console.WriteLine(MSV);
            Console.WriteLine(fullName);
            Console.WriteLine(addRess);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(speciaLized);
        }*/
        #endregion
        #region Bai 2
        /*static void Main()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            Sum();
            Sum(a);
            Sum(a, b);
            Sum(a, b, c);
            
        }
        static void Sum(int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }*/
        #endregion
        #region bai 3
        /*static void Main()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 8;
            Max();
            Max(a);
            Max(a, b);
            Max(a, b, c);
            Max(a, b, c,d);

        }
        static void Max(int a = int.MinValue, int b = int.MinValue, int c = int.MinValue , int d = int.MinValue)
        {
            Console.WriteLine($"Gia tri lon nhat la: {Math.Max(Math.Max(a,b),Math.Max(c,d))}");
        }*/
        #endregion
        #region bai 4
        /*static void Main()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 8;
            Min();
            Min(a);
            Min(a, b);
            Min(a, b, c);
            Min(a, b, c, d);

        }
        static void Min(int a = int.MaxValue, int b = int.MaxValue, int c = int.MaxValue, int d = int.MaxValue)
        {
            Console.WriteLine($"Gia tri lon nhat la: {Math.Min(Math.Min(a, b), Math.Min(c, d))}");
        }*/
        #endregion
    }
}
