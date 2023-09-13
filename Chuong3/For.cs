using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    internal class For
    {
        static void Main(string[] args)
        {
            //bai 1
            /*int a = int.Parse(Console.ReadLine());
            bool isDung = false;
            if (a < 0 || a > 100)
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                        isDung = true;
                    }

                }
            }*/
            //bai 2
            /* int b = int.Parse(Console.ReadLine());
             int a = int.Parse(Console.ReadLine());
             bool isDung = false;
             if (a < 0 || a > 100)
             {
                 Console.WriteLine("NO RESULT");
             }
             else
             {
                 for (int i = b; i <= a; i++)
                 {
                     if (i % 2 == 1)
                     {
                         Console.WriteLine(i);
                         isDung = true;
                     }

                 }
             }*/
            //bai 3
            /* int  a = int.Parse(Console.ReadLine());
             int s = 0;
             if (a < 0 || a > 100)
             {
                 Console.WriteLine("NO RESULT");
             }
             else
             {
                 for (int i = 1; i <= a; i++)
                 {
                     s += i;

                 }
                 Console.WriteLine(s);
             }*/
            //bai 4 
            /* int a = int.Parse(Console.ReadLine());
             double s = 0;
             if (a < 0 || a > 100)
             {
                 Console.WriteLine("NO RESULT");
             }
             else
             {
                 for (int i = 1; i <= a; i++)
                 {
                     s += 1.0 / i;

                 }
                 Console.WriteLine(s);
             }*/
            /*int a = 5;
           // a += 5;
            a = a + 5;


            Console.WriteLine(a);*/
            int a = 65;

            Console.WriteLine(a.ToString());  


        }
    }
}
