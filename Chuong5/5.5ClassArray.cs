using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Chuong5
{
    internal class ClassArray
    {
        #region Bai 1
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            FindMaxMin(arr, out int max, out int min);
            Print(max, min);
        }

        private static void Print(in int max, in int min)
        {
            Console.WriteLine(max == min ? "Khong Max k Min" : max + " " + min);
        }

        private static void FindMaxMin(int[] arr, out int max, out int min)
        {
            Array.Sort(arr);
            min = arr[0];
            max = arr[arr.Length - 1];
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
            FindMaxMin(arr, out int max, out int min);
            SecondMaxMin(arr, max, min, out int secondMax, out int secondMin);
            Console.WriteLine(secondMax + " " + secondMin);
            //Print(max, min);
        }

        private static void SecondMaxMin(int[] arr, int max, int min, out int secondMax, out int secondMin)
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
        }

        private static void Print(in int max, in int min)
        {
            Console.WriteLine(max == min ? "Khong Max k Min" : max + " " + min);
        }

        private static void FindMaxMin(int[] arr, out int max, out int min)
        {
            Array.Sort(arr);
            min = arr[0];
            max = arr[arr.Length - 1];
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
            Print(CoutX(arr));
        }
        private static int CoutX(int[] arr)
        {
            Console.Write("Nhap so X: ");
            int x = int.Parse(Console.ReadLine());
            int cout = 0;
            int index = Array.IndexOf(arr, x);
            if (index < 0)
            {
                return 0;
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    if (arr[i] == x)
                    {
                        cout++;
                    }
                }
                return cout;
            }
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
            Array.Sort(arr);
            Print(arr);
        }
        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
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
        #region Bai 5
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            Array.Sort(arr);
            Array.Reverse(arr);
            Print(arr);
        }
        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
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
        #region Bai 6
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            CheckArr(arr);
        }

        static void CheckArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check(arr, arr[i], i))
                {
                    Console.Write(arr[i]);
                }
            }
        }

        private static bool Check(int[] arr, int x, int pos)
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
        #region Bai 7
        /*
        static void Main()
        {
            Getdata(out int[] arr);
            CheckArr(arr);
        }

        static void CheckArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check(arr, arr[i], i))
                {
                    Console.WriteLine($"{arr[i]} : {Cout(arr, arr[i])}");
                }
            }
        }
        private static int Cout(int[] arr, int x)
        {
            int cout = 0;
            foreach (var item in arr)
            {
                if (x == item)
                {
                    cout++;
                }
            }
            return cout;
        }
        private static bool Check(int[] arr, int x, int pos)
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
        #region Bai 8
        /*
        static void Main()
        {
            Getdata(out int[] arr1, out int[] arr2);
            AddArr(arr1, arr2);
        }
        static void AddArr(int[] arr1, int[] arr2)
        {
            int sumLength = arr1.Length + arr2.Length;
            int[] sumArr = new int[sumLength];
            arr1.CopyTo(sumArr, 0);
            arr2.CopyTo(sumArr, arr1.Length);
            foreach (var item in sumArr)
            {
                Console.Write(item+ " ");
            }
        }
        private static void Getdata(out int[] arr1,out int[] arr2)
        {
            Console.Write("Nhap Arr 1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = new int[element1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(element1[i]); 
            }
            Console.Write("Nhap Arr 2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr2 = new int[element2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(element2[i]);
            }
        }
        */
        #endregion
        #region Bai 9   
        /*
        static void Main()
        {
            Getdata(out int[] arr1, out int[] arr2);
            SortArr(arr1, arr2);
        }
        static void SortArr(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1, arr2);
            int sumLength = arr1.Length + arr2.Length;
            int[] sumArr = new int[sumLength];
            arr1.CopyTo(sumArr, 0);
            arr2.CopyTo(sumArr, arr1.Length);
            Array.Sort(sumArr);
            foreach (var item in sumArr)
            {
                Console.Write(item + " ");
            }
        }
        private static void Getdata(out int[] arr1, out int[] arr2)
        {
            Console.Write("Nhap Arr 1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = new int[element1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(element1[i]);
            }
            Console.Write("Nhap Arr 2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr2 = new int[element2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(element2[i]);
            }
        }
        */
        #endregion
        #region Bai 10
        /*
        static void Main()
        {
            Getdata(out string[] arr);
            SortArr(arr);
        }

        static void SortArr(string[] arr)
        {
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        private static void Getdata(out string[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            arr = new string[element.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element[i];
            }
        }
        */
        #endregion
        #region Bai 11
        /*
        static void Main()
        {
            Getdata(out string[] arr);
            SortArr(arr);
        }
        static void Swap(ref string a ,ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
        static void SortArr(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    char[] a = arr[i].ToCharArray();
                    char[] b = arr[j].ToCharArray();
                    if (a.Length > b.Length)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        private static void Getdata(out string[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            arr = new string[element.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element[i];
            }
        }
        */
        #endregion
    }
}
