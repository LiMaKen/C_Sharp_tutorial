using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class BTStruct
    {
        #region Bai 1
        
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
        }
        struct AB
        {
            public AB(Point a, Point b)
            {
                A = a;
                B = b;
            }
            public Point A { get; set; }
            public Point B { get; set; }
            public static double Sum(Point a, Point b)
            {
                double m = Math.Pow(a.X - b.X, 2);
                double n = Math.Pow(a.Y - b.Y, 2);
                double MN = (double)Math.Sqrt(m + n);
                return MN;
            }
        }
        static void Main()
        {
            GetData(out Point pointpoint1, out Point pointpoint2);
            double result = AB.Sum(pointpoint1, pointpoint2);
            Console.WriteLine(result);
        }
        private static void GetData(out Point pointpoint1, out Point pointpoint2)
        {

            Point point1 = new Point();
            Point point2 = point1;
            Console.Write("Moi ban nhap diem A: ");
            var element1 = Console.ReadLine().Split(' ');
            point1.X = int.Parse(element1[0]);
            point1.Y = int.Parse(element1[1]);
            Console.Write("Moi ban nhap diem B: ");
            var element2 = Console.ReadLine().Split(' ');
            point2.X = int.Parse(element2[0]);
            point2.Y = int.Parse(element2[1]);
            pointpoint1 = point1;
            pointpoint2 = point2;
        }
        
        #endregion
    }
}
