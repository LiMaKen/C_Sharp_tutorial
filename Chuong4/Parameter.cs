using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parameter
    {
        #region bài 1
        /*  static void Main(string[] args)
          {
          int a = 0;
          int b = 0;
          int c = 0;
          GetData(ref a , ref b, ref c);
              Sum(a, b, c);
              MSG(a, b, c, Sum(a, b, c));
          }
          static void GetData(ref int a , ref int b, ref int c)
          {
              Console.WriteLine("Moi ban nhap so a");
              a = int.Parse(Console.ReadLine());
              Console.WriteLine("Moi ban nhap so b");
              b = int.Parse(Console.ReadLine());
              Console.WriteLine("Moi ban nhap so c");
              c = int.Parse(Console.ReadLine());
          }
          static int Sum(int a, int b , int c)
          {
              return a + b + c;
          }
          static void MSG(in int a , in int b, in int c, int Sum)
          {
              Console.WriteLine($"{a} + {b} + {c} = {Sum}");
          }*/
        #endregion
        #region bài 2
        /*static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            GetData(ref a, ref b, ref c);
            IsTamGiac(a, b, c);
            MSG(a, b, c, IsTamGiac(a, b, c));
        }
        static void GetData(ref int a, ref int b, ref int c)
        {
            Console.WriteLine("Moi ban nhap so a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so c");
            c = int.Parse(Console.ReadLine());
        }
        static bool IsTamGiac(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            return false;
        }
        static void MSG(in int a, in int b, in int c, bool IsTamGiac)
        {
            Console.WriteLine($"3 canh  a = {a}   b = {b}  c = {c} \n {IsTamGiac}");
        }*/
        #endregion
        #region bài 3
        /*static void Main(string[] args)
        {
            GetData(out int n);
            Sum(n, out int sum);
            Tich(n, out int tichs);
            Find(n, out int findNumber);
            MSG(sum, tichs, findNumber);
        }
        static void GetData(out int n)
        {
            Console.WriteLine("Moi ban nhap so nguyen duong n");
            n = int.Parse(Console.ReadLine());
        }
        static void Sum(int n, out int sums)
        {
            int a = 0;
            while (n > 0)
            {
                a += n % 10;
                n /= 10;
            }
            sums = a;
        }
        static void Tich(int n, out int tichs)
        {
            int a = 1;
            while (n > 0)
            {
                a *= n % 10;
                n /= 10;
            }
            tichs = a;
        }
        static void Find(int n,out int findNumber)
        {
            while(n >= 10)
            {
                if (n < 10)
                {
                    break;
                }
                n/= 10;
            }
            findNumber = n;
        }
        static void MSG(int s, int tichs,int findNumber)
        {
            Console.WriteLine($"Tong cac chu so la:{s}");
            Console.WriteLine($"Tich cac chu so la:{tichs}");
            Console.WriteLine($"Chu so dau tien la:{findNumber}");
        }*/
        #endregion
        #region bài 4
        /* static void Main(string[] args)
         {
             GetData(out int a, out int b);
             Tong(a , b, out int sum);
             Tich(a, b, out int tichs);
             Thuong(a, b, out double thuongs);
             MSG(sum, tichs, thuongs);
         }
         static void GetData(out int a, out int b)
         {
             Console.WriteLine("Moi ban nhap so a");
             a = int.Parse(Console.ReadLine());
             Console.WriteLine("Moi ban nhap so b");
             b = int.Parse(Console.ReadLine());
         }
         static void Tong(int a, int b ,out int sums)
         {
             int c = a + b;
             sums = c;
         }
         static void Tich(int a,int b, out int tichs)
         {
             int c = a * b;
             tichs = c;
         }
         static void Thuong(int a, int b, out double thuongs)
         {
             double c = (double) a / b;

             thuongs = c;
         }
         static void MSG(int s, int tichs, double thuongs)
         {
             Console.WriteLine($"Tong cac chu so la:{s}");
             Console.WriteLine($"Tich cac chu so la:{tichs}");
             Console.WriteLine($"Chu so dau tien la:{thuongs}");
         }*/
        #endregion
        #region bai 5
        /* static void Main(string[] args)
         {
             GetData(out int a, out int b, out int c);
             Max(a, b, c, out int max);
             Min(a, b, c, out int min);
             Sum(a, b, c,out double sum);
             Find(a, b, c, out int find, max, min);
             MSG(a, b, c, max, min, sum, find);


         }
         static void GetData(out int a, out int b, out int c)
         {
             Console.WriteLine("Moi ban nhap so a");
             a = int.Parse(Console.ReadLine());
             Console.WriteLine("Moi ban nhap so b");
             b = int.Parse(Console.ReadLine());
             Console.WriteLine("Moi ban nhap so c");
             c = int.Parse(Console.ReadLine());
         }
         static void Max(int a, int b, int c, out int max)
         {
             max = a;
             if (max < b)
             {
                 max = b;
             }
             if (max < c)
             {
                 max = c;
             }
         }
         static void Min(int a, int b, int c, out int min)
         {
             min = a;
             if (min > b)
             {
                 min = b;
             }
             if (min > c)
             {
                 min = c;
             }
         }
         static void Sum(int a, int b, int c , out double sum)
         {
             sum = (double) (a + b + c)/3;
         }
         static void Find(int a, int b , int c , out int find , int max , int min)
         {
             find = 0;
             if ( max == a && min == c)
             {
                 find = b;
             }
             if (max == b && min == a)
             {
                 find = c;
             }
             if (max == c && min == b)
             {
                 find = a;
             }
         }
         static void MSG(in int a, in int b, in int c,in int max,in int min ,in double sum , in int find)
         {
             Console.WriteLine($"  a = {a}   b = {b}  c = {c} \n gia tri lon nhat la {max}");
             Console.WriteLine($"Gia tri nho nhat la {min}");
             Console.WriteLine($"Trung binh cong cua 3 so la {sum}");
             Console.WriteLine($"So nho thu 2 la {find}");
         }*/
        #endregion
        #region bai 6
        /*
        static void Main(string[] args)
        {
            while (true)
            {
                GetData(out int n, out int k);
                if (Checked(k))
                {
                    Max(out int x,k,n);
                    Min(out int y, k, n);
                    MSG(n, k , x,y);
                }
                continue;
            }
        }
        static void Max(out int x,int k , int n)
        {
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                if(i % k == 0)
                {
                    a = i;
                }
            }
            x = a;
        }
        static void Min(out int y, int k, int n)
        {
            int a = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % k == 0)
                {
                    a = i;
                    break;
                }
            }
            y = a;
        }
        static bool Checked(int k)
        {
            if (k == 0)
            {
                Console.WriteLine("So nguyen k sai");
                return false;
            }
            return true;
        }
        static void GetData(out int n, out int k)
        {
            Console.WriteLine("Moi ban nhap so nguyen duong n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so nguyen k");
            k = int.Parse(Console.ReadLine());
        }

        static void MSG(in int n, in int k,in int x,in int y)
        {
            Console.WriteLine($"So nguyen n la:{n}");
            Console.WriteLine($"So nguyen k la:{k}");
            Console.WriteLine($"So nguyen lon nhat chia het cho k la:{x}");
            Console.WriteLine($"So nguyen nho nhat chia het cho k la:{y}");
        }*/
        #endregion
        #region bai 7
        static void Main(string[] args)
        {
            while (true)
            {
                GetData(out int a, out int b);
               
                    Max(out int x,b,a);
                    Min(out int y, b, a);
                    MSG(a, b , x,y);
                
                continue;
            }
        }
        static void Max(out int x,int b , int a)
        {
            if (a == 0 && b == 0)
            {
                x = 0;
                return;
            }
            else if (a == 0 && b != 0 || a != 0 && b == 0)
            {
                x = a == 0 ? b : a;
                return;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            x = a;
        }
        static void Min(out int y, int b, int a)
        {
            if (a * b == 0)
            {
                y = 0;
            }
            else
            {
                Max(out int x, b, a);
                y = a * b / x;
            }
        }
        static void GetData(out int a, out int b)
        {
            Console.WriteLine("Moi ban nhap so nguyen duong a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so nguyen duong b");
            b = int.Parse(Console.ReadLine());
        }

        static void MSG(in int a, in int b,in int x,in int y)
        {
            Console.WriteLine($"So nguyen n la:{a}");
            Console.WriteLine($"So nguyen k la:{b}");
            Console.WriteLine($"Uoc chung lon nhat la:{x}");
            Console.WriteLine($"Boi chung nho nhat la:{y}");
        }
        #endregion
    }
}
