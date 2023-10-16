using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class LambDa
    {
        #region Bai 1
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            int x = int.Parse(Console.ReadLine());
            Func<int[], int, bool> check = (arr, x) => Array.IndexOf(arr, x) > 0;
            Console.WriteLine(check(arr, x) ? "YES" : "NO");
        }

        private static void Getdata(out int[] arr) 
        {
            var element = Console.ReadLine().Split(' ');
            arr = new int[element.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(element[i]);
            }
        }
        */
        #endregion
        #region Bai 2
        /*
        static void Main()
        {
            Getdata(out int[] arr);
        }

        private static void Getdata(out int[] arr) 
        {
            var element = Console.ReadLine().Split(' ');
            arr = new int[element.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(element[i]);
            }
        }
        */
        #endregion
    }
}
