using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodOverLoading
    {
        #region Bai 1
        /*static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 2));
            Console.WriteLine(Sum(2, 2, 2));
            Console.WriteLine(Sum(2, 2, 2, 2));
            Console.WriteLine(Sum(2.2f, 2.2f));
            Console.WriteLine(Sum(2.22, 2.22));
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        static float Sum(float a, float b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }*/
        #endregion
        #region Bai 2
        /*static void Main(string[] args)
        {
            Console.WriteLine(Min(2, 3));
            Console.WriteLine(Min(2, 3, 5));
            Console.WriteLine(Min(2, 8, 3, 6));
            Console.WriteLine(Min(2.2f, 2.8f));
            Console.WriteLine(Min(2.22, 3.44));
        }
        static int Min(int a, int b)
        {
            return Math.Min(a,b);
        }
        static int Min(int a, int b, int c)
        {
            
            return Math.Min(Math.Min(a,b),c);
        }
        static int Min(int a, int b, int c, int d)
        {
            return Math.Min(Math.Min(a, b), Math.Min(c, d));
        }
        static float Min(float a, float b)
        {
            return Math.Min(a, b);
        }
        static float Min(float a, float b, float c)
        {

            return Math.Min(Math.Min(a, b), c);
        }
        static float Min(float a, float b, float c, float d)
        {
            return Math.Min(Math.Min(a, b), Math.Min(c, d));
        }
        static double Min(double a, double b)
        {
            return Math.Min(a, b);
        }
        static double Min(double a, double b, double c)
        {

            return Math.Min(Math.Min(a, b), c);
        }
        static double Min(double a, double b, double c, double d)
        {
            return Math.Min(Math.Min(a, b), Math.Min(c, d));
        }*/
        #endregion
        #region Bai 3
        /*static void Main(string[] args)
        {
            GetData("Do", "Quang", "Tu");
            GetData("Do", "Quang", "Tu",23);
            GetData("Do", "Quang", "Tu",23,"Long Bien");
            GetData("Do", "Quang", "Tu",23,"Long Bien",8.4f);
        }
        static void GetData(string ho, string dem , string ten)
        {
            Console.WriteLine(ho);
            Console.WriteLine(dem);
            Console.WriteLine(ten);
        }
        static void GetData(string ho, string dem, string ten,int tuoi)
        {
            Console.WriteLine(ho);
            Console.WriteLine(dem);
            Console.WriteLine(ten);
            Console.WriteLine(tuoi);
        }
        static void GetData(string ho, string dem, string ten, int tuoi, string diaChi)
        {
            Console.WriteLine(ho);
            Console.WriteLine(dem);
            Console.WriteLine(ten);
            Console.WriteLine(tuoi);
            Console.WriteLine(diaChi);
        }
        static void GetData(string ho, string dem, string ten,int tuoi, string diaChi, float diemTrungBinh)
        {
            Console.WriteLine(ho);
            Console.WriteLine(dem);
            Console.WriteLine(ten);
            Console.WriteLine(tuoi);
            Console.WriteLine(diaChi);
            Console.WriteLine(diemTrungBinh);
        }*/
        #endregion
        #region Bai 4
        // bo qua
        #endregion
        #region Bai 5
        /*static void Main(string[] args)
        {
            GetData(out string ho, out string dem, out string ten, out int tuoi,out string diaChi, out float diemTrungBinh);
            MSG(ho,dem,ten,tuoi,diaChi,diemTrungBinh);
        }
        static void GetData(out string ho,out string dem,out string ten)
        {
           ho = Console.ReadLine();
          dem=  Console.ReadLine();
           ten= Console.ReadLine();
        }
        static void GetData(out string ho, out string dem, out string ten, out int tuoi)
        {
            ho = Console.ReadLine();
            dem = Console.ReadLine();
            ten = Console.ReadLine();
            tuoi = int.Parse(Console.ReadLine());
        }
        static void GetData(out string ho, out string dem, out string ten, out int tuoi, out string diaChi)
        {
            ho = Console.ReadLine();
            dem = Console.ReadLine();
            ten = Console.ReadLine();
            tuoi = int.Parse(Console.ReadLine());
            diaChi = Console.ReadLine();
        }
        static void GetData(out string ho, out string dem, out string ten, out int tuoi, out string diaChi, out float diemTrungBinh)
        {
            ho = Console.ReadLine();
            dem = Console.ReadLine();
            ten = Console.ReadLine();
            tuoi = int.Parse(Console.ReadLine());
            diaChi = Console.ReadLine();
            diemTrungBinh= float.Parse(Console.ReadLine());
        }
        static void MSG(in string ho, in string dem, in string ten, in int tuoi, in string diaChi, in float diemTrungBinh)
        {
            Console.WriteLine(ho);
            Console.WriteLine(dem);
            Console.WriteLine(ten);
            Console.WriteLine(tuoi);
            Console.WriteLine(diaChi);
            Console.WriteLine(diemTrungBinh);
        }*/
        #endregion
    }
}
