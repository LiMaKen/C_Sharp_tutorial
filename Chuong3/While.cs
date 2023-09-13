using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    internal class While
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int sumDigits = 0;
            while (n > 0)
            {
                sumDigits += n % 10;
                n /= 10;
            }
            Console.WriteLine($"Tong cac chu so cua {m}: {sumDigits}");
           /* int n = int.Parse(Console.ReadLine());
            int m = n;
            int sumDigits = 0;
            do
            {
                sumDigits += n % 10;
                n /= 10;
            } while (n > 0);
            Console.WriteLine($"Tong cac chu so cua {m}: {sumDigits}");*/
        }
    }
}
