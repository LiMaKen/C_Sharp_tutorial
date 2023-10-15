using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    class TimKiemNhiPhanHove
    {
        public static bool SeachXWhile(int[] arr, int x, int left, int right)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return true;
                }
                if (arr[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
        public static bool SeachX(int[] arr , int x , int left , int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                {
                    return true;
                }
                if (arr[mid] < x)
                {
                    return SeachX(arr, x, mid + 1, right);
                }
                else
                {
                    return SeachX(arr, x, left, mid - 1);
                }
            }
            return false;
        }
    }
}
