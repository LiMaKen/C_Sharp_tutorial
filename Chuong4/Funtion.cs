using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4
{
    internal class Funtion
    {
        #region Bai 1
        /*static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            for (var i = 1; i <= t; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"test {i} : ");
                if (number >= 0)
                {
                    EvenNumber(number);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static void EvenNumber(int number)
        {
            for (var i = 0; i <= number; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }*/
        #endregion
        #region Bai 2
        /* public static void Main()
         {
             int t = int.Parse(Console.ReadLine());
             for (var i = 1; i <= t; i++)
             {
                 int number = int.Parse(Console.ReadLine());
                 Console.WriteLine($"test {i} : ");
                 if (number >= 0)
                 {
                     OddNumber(number);
                 }
                 else
                 {
                     Console.WriteLine("ERROR");
                 }
             }
         }
         public static bool IsOdd(int number)
         {
             return number % 2 == 1;
         }
         public static void OddNumber(int number)
         {
             for (var i = 0; i <= number; i++)
             {
                 if (IsOdd(i))
                 {
                     Console.WriteLine(i);
                 }
             }
         }*/
        #endregion
        #region Bai 3
        /*public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (var i = 1; i <= t; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"test {i} : ");
                if (number >= 0)
                {
                    int result = IsSum(number);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        public static int IsSum(int number)
        {
            int s = 0;
            for (var i = 0; i <= number; i++)
            {
                s += i;
            }
            return s;
        }*/
        #endregion
        #region Bai 4
        /*public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (var i = 1; i <= t; i++)
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"test {i} : ");
                if (number >= 0)
                {
                    double result = IsSum(number);
                    Msg(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        public static void Msg(double result)
        {
            Console.WriteLine($"\nTong cac chu so la: {Math.Round(result,3)}");
        }
        public static double IsSum(double number)
        {
            double s = 0;
            for (double i = 1; i <= number; i++)
            {                
                s += 1/i;
                if(i == 1)
                {
                    Console.Write($"{1 / i} ");
                }
                else
                {
                    Console.Write($"+ {1 / i}");
                }
               
            }
            return s;
        }*/
        #endregion
        #region Bai 5
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (var i = 1; i <= t; i++)
            {
                float number = float.Parse(Console.ReadLine());
                Console.WriteLine($"test {i} : ");
                if (number >= 0)
                {
                    float result = IsSum(number);
                    Msg(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        public static void Msg(float result)
        {
            Console.WriteLine($"\nTong cac chu so la: {Math.Round(result, 5)}");
        }
        public static float IsSum(float number)
        {
            float s = 0;
            for (int i = 1; i <= number; i++)
            {
                s += 1.0f / i*i;
                if (i == 1)
                {
                    Console.Write($"{1 / (i*i)} ");
                }
                else
                {
                    Console.Write($" + {1 / i*i}");
                }

            }
            return s;
        }
        #endregion

    }
}
