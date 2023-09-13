using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4
{
    internal class Funtion
    {
        static void Main(string[] args)
        {
            string msg = "Hello world";
            string test = IsNoob(msg);
            Console.WriteLine(test);

        }
        public static string IsNoob(string msg)
        {
            string a = $"{msg} test";
            return a;
        }
    }
}
