using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    class QuickSortHove
    {
        public static void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(arr, left, right); 
                Quicksort(arr, left, p - 1); 
                Quicksort(arr, p + 1, right);
            }
        }
        public static void Quicksort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = PartitionString(arr, left, right);
                Quicksort(arr, left, p - 1);
                Quicksort(arr, p + 1, right);
            }
        }
        public static void QuicksortReverse(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = PartitionReverse(arr, left, right);
                QuicksortReverse(arr, left, p - 1);
                QuicksortReverse(arr, p + 1, right);
            }
        }
        public static void QuicksortReverse(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = PartitionStringReverse(arr, left, right);
                QuicksortReverse(arr, left, p - 1);
                QuicksortReverse(arr, p + 1, right);
            }
        }
        static int Partition(int[] arr, int left, int right)
        {
            int poiv = arr[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < poiv)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[right]);
            return i;
        }
        static int PartitionReverse(int[] arr, int left, int right)
        {
            int poiv = arr[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (arr[j] > poiv)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[right]);
            return i;
        }
        static int PartitionString(string[] arr, int left, int right)
        {
            string poiv = arr[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j].ToLower().CompareTo(poiv.ToLower()) < 0)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[right]);
            return i;
        }
        static int PartitionStringReverse(string[] arr, int left, int right)
        {
            string poiv = arr[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j].ToLower().CompareTo(poiv.ToLower()) > 0)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[right]);
            return i;
        }
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
    }
}
