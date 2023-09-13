using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    internal class Ifelse
    {
        static void Main(string[] args)
        {
            //bai 1 
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
            */
            //bai 2
            /*
            int a = int.Parse(Console.ReadLine());
            if (a < 0) 
            {
                Console.WriteLine("NEGATIVE");
            }
            else if (a == 0) 
            {
                Console.WriteLine("UNSIGNED");
            }
            else
            {
                Console.WriteLine("POSITIVE");
            }
            */
            //bai 3
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                int c = a - b;
                Console.WriteLine("DIFFERENT" + Math.Abs(c));
            }
            */
            //bai 4
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            if (a == b && a== c) 
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                 d = Math.Min(a, b);
                 Console.WriteLine(Math.Min(d,c));
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                if (max < c)
                {
                    max = c;
                }
                Console.WriteLine(max);
            }
            */
            //bai5
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            if (a == b && a == c)
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                int min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                Console.WriteLine(min);
            }
            */
            //bai 6
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0) 
            {
                Console.WriteLine(-b/a + " 1 nghiem");
            }
            else if(a == 0 && b == 0)
            {
                Console.WriteLine("NO SOLUTION")
            }
            else { Console.WriteLine("COUNTERLESS"); }
            */
            // bai 8
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            */
            //bai 9
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
             
            if ((a * a + b * b) == c * c || (a*a + c*c) == b*b||(b*b + c*c) == a*a )
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            */
            //bai 10
            float a = float.Parse(Console.ReadLine());
            if (a > 9 && a <= 10)
            {
                Console.WriteLine("A");
            }
            else if (a <= 9 && a > 7)
            {
                Console.WriteLine("B");
            }
            else if (a <= 7 && a > 5)
            {
                Console.WriteLine("C");
            }
            else if (a <= 5 && a > 4)
            {
                Console.WriteLine("D");
            }
            else if (a <= 4 && a >= 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
    }
}
