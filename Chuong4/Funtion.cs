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
            
            while(true)
            {
                Console.WriteLine("Moi ban nhap chu so:");
                int number;
                string numberTry = Console.ReadLine();
                if (int.TryParse(numberTry, out number) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
               
                if (number >= 0)
                {
                    EvenNumber(number);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
        continue;
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
             while(true)
            {
                Console.WriteLine("Moi ban nhap chu so:");
                int number;
                string numberTry = Console.ReadLine();
                if (int.TryParse(numberTry, out number) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
                
                 if (number >= 0)
                 {
                     OddNumber(number);
                 }
                 else
                 {
                     Console.WriteLine("ERROR");
                 }
        continue;
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
        /* public static void Main()
         {
             while(true)
             {
                 Console.WriteLine("Moi ban nhap chu so:");
                 int number;
                 string numberTry = Console.ReadLine();
                 if (int.TryParse(numberTry, out number) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }
                 
                 if (number >= 0)
                 {
                     int result = IsSum(number);
                     Console.WriteLine(result);
                 }
                 else
                 {
                     Console.WriteLine("ERROR");
                 }
        continue;
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
            while(true)
            {
                Console.WriteLine("Moi ban nhap chu so:");
                double number; 
                string numberTry = Console.ReadLine();
                if(double.TryParse(numberTry,out number) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
                
                if (number >= 0)
                {
                    double result = IsSum(number);
                    Msg(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
        continue;
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
        /*public static void Main()
        {
           while(true)
            {
               Console.WriteLine("Moi ban nhap chu so:");
               float number;
               string numberTry = Console.ReadLine();
               if(float.TryParse(numberTry,out number) == false)
               {
                   Console.WriteLine("Ban da nhap sai dinh dang");
                   continue;
               }
               
                if (number >= 0)
                {
                    float result = IsSum(number);
                    Msg(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
        continue;
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
        }*/
        #endregion
        #region Bai 6
        /* public static void Main()
         {
             while(true)
             {
                 Console.WriteLine("Moi ban nhap so:");
                 float number;
                 string numberTry = Console.ReadLine();
                 if(float.TryParse(numberTry,out number) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }
                
                 if (number >= 0)
                 {
                     float result = IsSum(number);
                     Msg(result);
                 }
                 else
                 {
                     Console.WriteLine("ERROR");
                 }
        continue;
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
                 s += i+(i-1);
                 if (i == 1)
                 {
                     Console.Write($"{i + (i - 1)} ");
                 }
                 else
                 {
                     Console.Write($" + {i + (i - 1)}");
                 }

             }
             return s;
         }*/
        #endregion
        #region Bai 7
        /*public static void Main()
        {
            while(true)
            {
                int number;
                int divisor;
                Console.WriteLine("Moi ban nhap cac chu so:");
                string numberTry = Console.ReadLine();
                string divisorTry = Console.ReadLine();
                if (int.TryParse(numberTry, out number) == false || int.TryParse(divisorTry, out divisor) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
                
                if (number > 0 && divisor > 0 && divisor < Math.Pow(10, 9))
                {
                    Total(number, divisor);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
        continue;
            }
        }
        public static void Msg(float result)
        {
            Console.WriteLine($"\nTong cac chu so la: {Math.Round(result, 5)}");
        }
        public static void Total(int number, int divisor)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write($" {i} ");
                }
            }

        }*/
        #endregion
        #region bai 8
        /* public static void Main()
         {
             while(true)
             {
                 int number;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string numberTry = Console.ReadLine();
                 if (int.TryParse(numberTry, out number) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }
                 Console.WriteLine($" {(IsPrime(number)? "YES" : "NO")}");
        continue;
             }
         }
         public static bool IsPrime(int number)
         {
             if(number < 2)
             {
                 return false;
             }
             int bound = (int)Math.Sqrt(number);
             for (int i = 2; i <= bound; i++)
             {
                 if (number % i == 0)
                 {
                     return false;
                 }
             }
             return true;

         }*/
        #endregion
        #region bai 9
        /*public static void Main()
        {
            while(true)
            {
                int number;
                Console.WriteLine("Moi ban nhap cac chu so:");
                string numberTry = Console.ReadLine();
                if (int.TryParse(numberTry, out number) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
                Console.WriteLine($" {(IsSymmetry(number) ? "YES" : "NO")}");
        continue;
            }
        }
        static bool IsSymmetry(int n)
        {
            if (n < 0)
            {
                n = -n;
            }
            int reverse = 0;
            int m = n;
            while (m > 0)
            {
                reverse = reverse * 10 + m % 10;
                m /= 10;
            }
            return reverse == n;
        }*/
        #endregion
        #region bai 10
        /* public static void Main()
         {
             while(true)
             {
                 int number;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string numberTry = Console.ReadLine();
                 if (int.TryParse(numberTry, out number) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }
                 
                 if (number < 0)
                 {
                     Console.WriteLine("ERROR");
                 }
                 else
                 {
                     Console.WriteLine(Sum(number));
                 }
        continue;
             }
         }
         static int Sum(int n)
         {
             int sum = 0;
             while (n > 0)
             {
                 sum += n % 10;
                 n /= 10;
             }
             return sum;
         }*/
        #endregion
        #region bai 11
        /* public static void Main()
         {
             while(true)
             {
                 int number;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string numberTry = Console.ReadLine();
                 if (int.TryParse(numberTry, out number) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }
                 
                 if (number < 0)
                 {
                     Console.WriteLine("ERROR");
                 }
                 else
                 {
                     Console.WriteLine(Multi(number));
                 }
        continue;
             }
         }
         static int Multi(int n)
         {
             int mul = 1;
             while (n > 0)
             {
                 mul *= n % 10;
                 n /= 10;
             }
             return mul;
         }*/
        #endregion
        #region bai 16
        /*public static void Main()
        {
            while(true)
            {
                int Width;
                int Height;
                Console.WriteLine("Moi ban nhap cac chu so:");
                string WidthTry = Console.ReadLine();
                string HeightTry = Console.ReadLine();
                if (int.TryParse(WidthTry, out Width) == false || int.TryParse(HeightTry, out Height) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }
                
                if (Height < 0 && Width < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    HCN(Width, Height);
                }
        continue;
            }
        }
        public static void HCN(int W, int H)
        {
            for (int i = 1; i <= W; i++)
            {
                for (int j = 1; j <= H; j++)
                {
                    Console.Write($" {j} ");
                }
                Console.WriteLine();
            }
        }*/

        #endregion
        #region bai 17
        /* public static void Main()
         {
             while(true)
             {
                 int Width;
                 int Height;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string WidthTry = Console.ReadLine();
                 string HeightTry = Console.ReadLine();
                 if (int.TryParse(WidthTry, out Width) == false || int.TryParse(HeightTry, out Height) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }

                 if (Height < 0 && Width < 0)
                 {
                     Console.WriteLine("ERROR");
                 }
                 else
                 {
                     HCN(Width, Height);
                 }
        continue;
             }
         }
         public static void HCN(int W, int H)
         {
             for (int i = 1; i <= W; i++)
             {
                 for (int j = 1; j <= H; j++)
                 {
                     Console.Write($" * ");
                 }
                 Console.WriteLine();
             }
         }*/

        #endregion
        #region bai 18
        /* public static void Main()
         {
             while (true)
             {
                 int Width;
                 int Height;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string WidthTry = Console.ReadLine();
                 string HeightTry = Console.ReadLine();
                 if (int.TryParse(WidthTry, out Width) == false || int.TryParse(HeightTry, out Height) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }

                 if (Height < 0 && Width < 0)
                 {
                     Console.WriteLine("ERROR");
                 }
                 else
                 {
                     HCN(Width, Height);
                 }
                 continue;
             }

         }
         public static void HCN(int W, int H)
         {
             for (int i = 1; i <= H; i++)
             {
                 for (int j = 1; j <= W; j++)
                 {
                     if (i == 1 || j ==1 || i == H || j == W)
                     {
                         Console.Write(" * ");
                     }
                     else
                     {
                         Console.Write("   ");
                     }

                 }
                 Console.WriteLine();
             }
         }*/

        #endregion
        #region bai 19
        /* public static void Main()
         {
             while (true)
             {
                 int Side;
                 Console.WriteLine("Moi ban nhap cac chu so:");
                 string SideTry = Console.ReadLine();
                 if (int.TryParse(SideTry, out Side) == false)
                 {
                     Console.WriteLine("Ban da nhap sai dinh dang");
                     continue;
                 }

                 if (Side < 0 )
                 {
                     Console.WriteLine("ERROR");
                 }
                 else
                 {
                     HCN(Side);
                 }
                 continue;
             }

         }
         public static void HCN(int S)
         {
             for (int i = 1; i <= S; i++)
             {
                 for (int j = 1; j <= S; j++)
                 {
                     if (i == 1 || j == 1 || i == S || j == S || i == j || i + j == S + 1)
                     {
                         Console.Write(" * ");
                     }
                     else
                     {
                         Console.Write("   ");
                     }

                 }
                 Console.WriteLine();
             }
         }*/

        #endregion
        #region bai 20
        /*public static void Main()
        {
            while (true)
            {
                int Side;
                Console.WriteLine("Moi ban nhap cac chu so:");
                string SideTry = Console.ReadLine();
                if (int.TryParse(SideTry, out Side) == false)
                {
                    Console.WriteLine("Ban da nhap sai dinh dang");
                    continue;
                }

                if (Side < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    TG(Side);
                }
                continue;
            }

        }
        public static void TG(int S)
        {
            for (int i = 1; i <= S; i++)
            {
                for (int j = 1; j <= i ; j++)
                {              
                        Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        */
        #endregion
    }
}
