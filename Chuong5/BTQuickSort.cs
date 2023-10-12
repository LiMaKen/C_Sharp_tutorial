using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class BTQuickSort
    {
        #region Bai 1
        /*
        static void Main()
        {
            GetData(out int[] data);
            QuickSortHove.Quicksort(data, 0, data.Length - 1);
            PrintData(data);
        }

        private static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }

        static void GetData(out int[] data)
        {
            string[] element = Console.ReadLine().Split(' ');
            int[] datas = new int[element.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = int.Parse(element[i]);
            }
            data = datas;
        }
        */
        #endregion
        #region Bai 2
        /*
        static void Main()
        {
            GetData(out int[] data);
            QuickSortHove.QuicksortReverse(data, 0, data.Length -1);
            PrintData(data);
        }

        private static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }

        static void GetData(out int[] data)
        {
            string[] element = Console.ReadLine().Split(' ');
            int[] datas = new int[element.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = int.Parse(element[i]);
            }
            data = datas;
        }
        */
        #endregion
        #region Bai 3
        /*
        static void Main()
        {
            GetData(out string[] data);
            QuickSortHove.Quicksort(data, 0, data.Length - 1);
            PrintData(data);
        }

        private static void PrintData(string[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }
        static void GetData(out string[] data)
        {
            string[] element = Console.ReadLine().Split(' ');
            string[] datas = new string[element.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = element[i];
            }
            data = datas;
        }
        */
        #endregion
        #region Bai 4
        /*
        static void Main()
        {
            GetData(out string[] data);
            QuickSortHove.QuicksortReverse(data, 0, data.Length - 1);
            PrintData(data);
        }

        private static void PrintData(string[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }
        static void GetData(out string[] data)
        {
            string[] element = Console.ReadLine().Split(' ');
            string[] datas = new string[element.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = element[i];
            }
            data = datas;
        }
        */
        #endregion
        #region Bai 5
        /*
        static void Main()
        {
            GetData(out int[] data);
            SortArray(data);
            PrintData(data);
        }

        static void SortArray(int[] data)
        {
            int k = data.Length / 2;
            QuickSortHove.Quicksort(data, 0, k -1);
            QuickSortHove.QuicksortReverse(data, k , data.Length - 1);
        }

        private static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }

        static void GetData(out int[] data)
        {
            string[] element = Console.ReadLine().Split(' ');
            int[] datas = new int[element.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = int.Parse(element[i]);
            }
            data = datas;
        }
        */
      

        #endregion
    }
}
