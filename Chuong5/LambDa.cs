using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y : ");
            int y = int.Parse(Console.ReadLine());
            var checkArr = (int[] arr, int x, int y) =>
            {
                int cout = 0;
                foreach (var item in arr)
                {
                    if (item >= x && item <= y )
                    {
                        cout++;
                    }
                }
                return cout;
            };
            Print(checkArr(arr,x,y));
        }
        private static void Print(int cout)
        {
            Console.WriteLine(cout);
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
        #region Bai 3
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            var checkArr = (int[] arr, int x) =>
            {
                int cout = 0;
                foreach (var item in arr)
                {
                    if (item == x)
                    {
                        cout++;
                    }
                }
                return cout;
            };
            Print(checkArr(arr, x));
        }
        private static void Print(int cout)
        {
            Console.WriteLine(cout);
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
        #region Bai 4
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            int x = int.Parse(Console.ReadLine());
            var findArr = (int[] arr,int x) =>
            {
                for (int i = arr.Length -1; i >= 0; i--)
                {
                    if (x == arr[i])
                    {
                        return i;
                    }
                }
                return -1;
            };
            Print(findArr(arr,x));
        }
        private static void Print(int cout)
        {
            Console.WriteLine(cout);
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
        #region Bai 5
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            int x = int.Parse(Console.ReadLine());
            var findArr1 = (int[] arr, int x) =>
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (x == arr[i])
                    {
                        return i;
                    }
                }
                return -1;
            };
            var findArr2 = (int[] arr, int x) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (x == arr[i])
                    {
                        return i;
                    }
                }
                return -1;
            };
            Print(findArr1(arr, x), findArr2(arr, x));
        }
        private static void Print(int cout, int cout2)
        {
            Console.WriteLine(cout + " " + cout2);
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
        #region Bai 6
        /*
        static void Main()
        {
            Getdata(out string element);
            var findString = (string element) =>
            {
                char[] arr = element.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Check(arr, arr[i], i))
                    {
                        Console.WriteLine($"{arr[i]}, {Cout(arr, arr[i])}");
                    }
                }
            };
            findString(element);
        }

        private static int Cout(char[] arr, char x)
        {
            int cout = 0;
            foreach (var item in arr)
            {
                if (item == x)
                {
                    cout++;
                }
            }
            return cout;
        }

        private static bool Check(char[] arr, char x, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if (arr[i] == x)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Getdata(out string element)
        {
            var a = Console.ReadLine();
            element = a;
        }
        */
        #endregion
        #region Bai 9
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            var findString = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (IsNumber(arr[i]))
                    {
                        Console.WriteLine($"({i},{arr[i]})");
                    }
                }
            };
            findString(arr);
        }

        private static bool IsNumber(int x)
        {
            if (x < 2)
            {
                return false;
            }
            int bou = (int)Math.Sqrt(x);
            for (int i = 2; i <= bou; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
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
        #region Bai 10
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            IsNumber(arr);
        }

        private static void IsNumber(int[] arr)
        {
            var checkNumber = (int x) =>
            {
                double a = Math.Sqrt(x);
                if (a * a == x)
                {
                    return true;
                }
                return false;
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkNumber(arr[i]))
                {
                    Console.WriteLine($"({i},{arr[i]})");
                }
            }
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
        #region Bai 11
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            IsNumber(arr);
        }

        private static void IsNumber(int[] arr)
        {
            Func<int, bool> checkNumber = (int x) =>
            {
                if (x < 0)
                {
                    x = -x;
                }
                if (x < 10)
                {
                    return false;
                }
                int m = x;
                int rev = 0;
                while (m > 0)
                {
                    rev = rev * 10 + m % 10;
                    m /= 10;
                }
                return rev == x;
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkNumber(arr[i]))
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }
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
        #region Bai 12
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            MaxMin(arr);
        }

        private static void MaxMin(int[] arr)
        {
            Func<int[], int> Max = (arr) =>
            {
                int max = arr[0];
                foreach (var item in arr)
                {
                    if (max < item)
                    {
                        max = item;
                    }
                }
                return max;
            };
            Func<int[], int> Min = (arr) =>
            {
                int min = arr[0];
                foreach (var item in arr)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(Max(arr) == Min(arr) ? "Khong co MAX MIN" : Max(arr) + " " + Min(arr));
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
        #region Bai 13
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            MaxMin(arr);
        }

        private static void MaxMin(int[] arr)
        {
            Func<int[], int> max = (arr) =>
            {
                int max = arr[0];
                foreach (var item in arr)
                {
                    if (max < item)
                    {
                        max = item;
                    }
                }
                return max;
            };
            Func<int[], int> min = (arr) =>
            {
                int min = arr[0];
                foreach (var item in arr)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                return min;
            };
            var secondMaxMin = (int[] arr, int max, int min,out int secondMax, out int secondMin) =>
            {
                secondMax = min;
                secondMin = max;
                foreach (var item in arr)
                {
                    if (item != max && item > secondMax)
                    {
                        secondMax = item;
                    }
                    if (item != min && item < secondMin)
                    {
                        secondMin = item;
                    }
                }
            };
            secondMaxMin(arr,max(arr), min(arr), out int secondMax, out int secondMin);
            Console.WriteLine(max(arr) == min(arr) ? "Khong co MAX MIN" : secondMax + " " + secondMin);
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
        #region Bai 14
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            CheckArray(arr);
        }
        private static void CheckArray(int[] arr)
        {
           Func< int, int, bool> check = (x, pos) =>
            {
                for (int i = 0; i < pos; i++)
                {
                    if (arr[i] == x)
                    {
                        return false;
                    }
                }
                return true;
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (check(arr[i], i))
                {
                    Console.Write(arr[i] + " ");
                }
            }
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
        #region Bai 15
        /*
        static void Main()
        {
            Getdata(out int[] arr1, out int[] arr2);
            SortArray(arr1, arr2);
        }
        private static void SortArray(int[] arr1, int[] arr2)
        {
            int[] sumArr = new int[arr1.Length + arr2.Length];
            var add = (int[] sumArr) =>
            {
                arr1.CopyTo(sumArr, 0);
                arr2.CopyTo(sumArr, arr1.Length); 
            };
            add(sumArr);
            Array.Sort(sumArr);
            ShowArray(sumArr);
        }

        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Getdata(out int[] arr1, out int[] arr2)
        {
            var element1 = Console.ReadLine().Split(' ');
            arr1 = new int[element1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(element1[i]);
            }
            var element2 = Console.ReadLine().Split(' ');
            arr2 = new int[element2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(element2[i]);
            }
        }
        */
        #endregion
        #region Bai 16
        /*
        static void Main()
        {
            Getdata(out string[] arr1, out string[] arr2);
            CheckArray(arr1, arr2);
        }
        private static void CheckArray(string[] arr1, string[] arr2)
        {
            var check = () =>
            {
                foreach (var item in arr1)
                {
                    if (CheckArray(arr2,item))
                    {
                        Console.Write(item + " ");
                    }
                }
            };
            check();
        }

        private static bool CheckArray(string[] arr2, string x)
        {
            foreach (var item in arr2)
            {
                if (item.ToLower() == x.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private static void Getdata(out string[] arr1, out string[] arr2)
        {
            var element1 = Console.ReadLine().Split(' ');
            arr1 = new string[element1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = element1[i];
            }
            var element2 = Console.ReadLine().Split(' ');
            arr2 = new string[element2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = element2[i];
            }
        }
        */
        #endregion
        #region Bai Them
        /*
        static void Main()
        {
            Getdata(out string[] arr1, out string[] arr2);
            CheckArray(arr1, arr2);
        }
        private static void CheckArray(string[] arr1, string[] arr2)
        {
            Func<string[], string, bool> checkArr = (arr, x) =>
            {
                foreach (var item in arr)
                {
                    if (item.ToLower().CompareTo(x.ToLower()) == 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            var check = () =>
            {
                foreach (var item in arr1)
                {
                    if (checkArr(arr2,item))
                    {
                        Console.Write(item + " ");
                    }
                }
                foreach (var item in arr2)
                {
                    if (checkArr(arr1, item))
                    {
                        Console.Write(item + " ");
                    }
                }
            };
            check();
        }

        private static void Getdata(out string[] arr1, out string[] arr2)
        {
            var element1 = Console.ReadLine().Split(' ');
            arr1 = new string[element1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = element1[i];
            }
            var element2 = Console.ReadLine().Split(' ');
            arr2 = new string[element2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = element2[i];
            }
        }
        */
        #endregion

    }
}
