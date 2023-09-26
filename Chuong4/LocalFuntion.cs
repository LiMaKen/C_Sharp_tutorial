using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LocalFuntion
    {
        #region Bai 1
        /*static void Main(string[] args)
        {
            while (true)
            {
                GetData(out int a, out int b);
                Data(a, b);
                continue;
            }
        }
        static void GetData(out int a, out int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        static void Data(int a, int b)
        {
            int result = 0;
            bool Check(int n)
            {
                return n % 2 == 0;
            }
            for (int i = a; i < b; i++)
            {
                if (Check(i))
                {
                    Console.WriteLine(i);
                    result++;
                }
            }
            Console.WriteLine(result == 0 ? "ERROR" : "");

        }*/
        #endregion
        #region Bai 2
        /*static void Main(string[] args)
        {
            while (true)
            {
                GetData(out int a, out int b);
                Data(a, b);
                continue;
            }
        }
        static void GetData(out int a, out int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        static void Data(int a, int b)
        {
            int result = 0;
            bool Check(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(n);
                for (int i = 2; i <= bound; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            for (int i = a; i <= b; i++)
            {
                if (Check(i))
                {
                    Console.WriteLine(i);
                    result++;
                }
            }
            Console.WriteLine(result == 0 ? "ERROR" : "");

        }*/
        #endregion
    }
}
