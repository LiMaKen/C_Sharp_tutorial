using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class Array1
    {
        #region Bai 1
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            int s = Sum(arr);
            Print(s);
        }

        private static void Print(int s)
        {
            Console.WriteLine($"Tong cac phan tu trong mang la: {s}");
        }

        static int Sum(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s;
        }

        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;

        }
        */
        #endregion
        #region Bai 2
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            int s = Sum(arr);
            Print(s);
        }

        private static void Print(int s)
        {
            Console.WriteLine($"Trung binh cong cac phan tu trong mang la: {s}");
        }

        static int Sum(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s/arr.Length;
        }

        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;

        }
        */
        #endregion
        #region Bai 3
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            int s = Sum(arr);
            Print(s);
        }

        private static void Print(int s)
        {
            Console.WriteLine($"Tong cac phan tu o vi tri chan trong mang la: {s}");
        }

        static int Sum(int[] arr)
        {
            int s = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s += arr[i];
                    index++;
                }
            }
            return s/index;
        }

        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;

        }
        */
        #endregion
        #region Bai 4
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            Integer(arr);
        }
        static bool IsInteger(int x)
        {
            if (x < 2) return false;
            int check = (int)Math.Sqrt(x);
            for (int i = 2; i < check; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Integer(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsInteger(arr[i]))
                {
                    Console.WriteLine($"({i}, {arr[i]})");
                }
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 5
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            SquareNumber(arr);
        }
        static bool ISSquareNumber(int x)
        {
            int check = (int)Math.Sqrt(x);
            if (check * check == x)
            {
                return true;
            }
            return false;
        }
        static void SquareNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (ISSquareNumber(arr[i]))
                {
                    Console.WriteLine($"({i}, {arr[i]})");
                }
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 6
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            ReversibleNumber(arr);
        }
        static bool ISReversibleNumber(int x)
        {
            if (x < 10) return false;
            if (x < 0) x = -x;
            int a = x;
            int rev = 0;
            while (a > 0)
            {
                rev = rev * 10 + a % 10;
                a /= 10;
            }
            return rev == x;
        }
        static void ReversibleNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (ISReversibleNumber(arr[i]))
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 7
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            Max(arr, out int max);
            Min(arr, out int min);
            Console.WriteLine(max == min ? "NO RESULT" : max + " " + min);
        }
        static void Min(int[] arr, out int min)
        {
            int checkMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkMin > arr[i])
                {
                    checkMin = arr[i];
                }
            }
            min = checkMin;
        }
        static void Max(int[] arr, out int max)
        {
            int checkMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkMax < arr[i])
                {
                    checkMax = arr[i];
                }
            }
            max = checkMax;
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 8
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            Max(arr, out int max);
            Min(arr, out int min);
            SecondMaxMin(arr,max, min, out int secondMax, out int secondMin);
            Console.WriteLine(max == min ? "NO RESULT" : secondMax + " " + secondMin);
        }

        private static void SecondMaxMin(int[] arr , int max, int min, out int secondMax, out int secondMin)
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
        static void Min(int[] arr, out int min)
        {
            int checkMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkMin > arr[i])
                {
                    checkMin = arr[i];
                }
            }
            min = checkMin;
        }
        static void Max(int[] arr, out int max)
        {
            int checkMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkMax < arr[i])
                {
                    checkMax = arr[i];
                }
            }
            max = checkMax;
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 9
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            CheckX(arr);
        }
        static void CheckX(int[] arr)
        {
            int cout = 0;
            Console.Write("Moi ban nhap so x can tim kiem: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    cout++;
                }
            }
            Console.WriteLine($"Co {cout} lan xuat hien so {x}");
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 10
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            CheckK(arr);
        }
        static void CheckK(int[] arr)
        {
            int cout = 0;
            Console.Write("Moi ban nhap so k : ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k == 0)
                {
                    cout++;
                }
            }
            Console.WriteLine($"Co {cout} so chia het cho {k}");
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 11
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            CheckArray(arr);
        }
        static void CheckArray(int[] arr)
        {
            int halflength = arr.Length / 2;
            bool Check()
            {
                for (int i = 0; i < halflength; i++)
                {
                    if (arr[i] != arr[arr.Length - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (Check())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 12
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            SortArray(arr);
        }
        static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 13
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            SortArray(arr);
        }
        static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 14
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            CutArray(arr);
        }
        static void DeleteArray(int[] arr, int pos)
        {
            for (int i = pos + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
        }
        static void CutArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        DeleteArray(arr, j);
                        n--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 15
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap cac phan tu trong mang: ");
            Getdata(out int[] arr);
            CheckArray(arr);
        }
        static void CheckArray(int[] arr)
        {
            int cout = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cout++;
                    }
                }
                Console.WriteLine($"So {arr[i]} co {cout} lan xuat hien");
                cout = 1;
            }
        }
        static void Getdata(out int[] arr)
        {
            var element = Console.ReadLine().Split(' ');
            int[] array = new int[element.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(element[i]);
            }
            arr = array;
        }
        */
        #endregion
        #region Bai 17
        /*
        static void Main(string[] args)
        {
            Getdata(out int[] arr1, out int[] arr2);
            AddArray(arr1, arr2);
        }
        static void AddArray(int[] arr1, int[] arr2)
        {
            int index = 0;
            int Sumlength = arr1.Length + arr2.Length;
            int[] sumArray = new int[Sumlength];
            foreach (var item in arr1)
            {
                sumArray[index++] = item;
            }
            foreach (var item in arr2)
            {
                sumArray[index++] = item;
            }
            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
        }
        static void Getdata(out int[] arr1, out int[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            int[] array1 = new int[element1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(element1[i]);
            }
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            int[] array2 = new int[element2.Length];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(element2[i]);
            }
            arr1 = array1;
            arr2 = array2;
        }
        */
        #endregion
        #region Bai 18
        /*
        static void Main(string[] args)
        {
            Getdata(out int[] arr1, out int[] arr2);
            AddArray(arr1, arr2);
        }
        static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
        static void AddArray(int[] arr1, int[] arr2)
        {
            int index = 0;
            int Sumlength = arr1.Length + arr2.Length;
            int[] sumArray = new int[Sumlength];
            foreach (var item in arr1)
            {
                sumArray[index++] = item;
            }
            foreach (var item in arr2)
            {
                sumArray[index++] = item;
            }
            SortArray(sumArray);
            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
        }
        static void Getdata(out int[] arr1, out int[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            int[] array1 = new int[element1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(element1[i]);
            }
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            int[] array2 = new int[element2.Length];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(element2[i]);
            }
            arr1 = array1;
            arr2 = array2;
        }
        */
        #endregion
        #region Bai 19
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1, out string[] arr2);
            AddArray(arr1, arr2);
        }
        static string[] SortArray(string[] arr)
        {
            Array.Sort(arr,StringComparer.Ordinal);
            Array.Reverse(arr);
            return arr;
        }
        static void AddArray(string[] arr1, string[] arr2)
        {
            int index = 0;
            int Sumlength = arr1.Length + arr2.Length;
            string[] sumArray = new string[Sumlength];
            foreach (var item in arr1)
            {
                sumArray[index++] = item;
            }
            foreach (var item in arr2)
            {
                sumArray[index++] = item;
            }
            SortArray(sumArray);
            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
        }
        static void Getdata(out string[] arr1, out string[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr1 = element1;
            arr2 = element2;
        }
        */
        #endregion
        #region Bai 20
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            AddArray(arr1);
        }
        static void AddArray(string[] arr)
        {
            Console.WriteLine("Moi ban nhap chuoi can them: ");
            string addString = Console.ReadLine();
            Console.WriteLine("Moi ban nhap vi tri can them: ");
            int w = int.Parse(Console.ReadLine());
            int index = 0;
            int newlength = arr.Length + 1;
            string[] newArray = new string[newlength];
            foreach (var item in arr)
            {
                newArray[index++] = item;
            }
            if (w < 0)
            {
                for (int i = newArray.Length - 1; i > 0; i--)
                {
                    newArray[i] = newArray[i - 1];
                }
                newArray[0] = addString;
            }
            else if (w > arr.Length)
            {
                foreach (var item in arr)
                {
                    newArray[newlength - 1] = addString;
                }
            }
            else
            {
                for (int i = newArray.Length - 1; i >= w; i--)
                {
                    if (i == w)
                    {
                        newArray[i] = addString;
                        break;
                    }
                    newArray[i] = newArray[i - 1];
                }
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 21
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1, out string[] arr2);
            AddArray(arr1, arr2);
        }
        static string[] Add(string[] sumArray, string[] arr1, string[] arr2, int k)
        {
            int index = 0;
            if (k > arr1.Length)
            {
                foreach (var item in arr1)
                {
                    sumArray[index++] = item;
                }
                foreach (var item in arr2)
                {
                    sumArray[index++] = item;
                }
            }
            else if (k < 0)
            {
                foreach (var item in arr2)
                {
                    sumArray[index++] = item;
                }
                foreach (var item in arr1)
                {
                    sumArray[index++] = item;
                }
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    sumArray[index++] = arr1[i];
                    if (i == k)
                    {
                        foreach (var item in arr2)
                        {
                            sumArray[index++] = item;
                        }
                    }
                }
            }
            return sumArray;
        }
        static void AddArray(string[] arr1, string[] arr2)
        {
            Console.WriteLine("Moi ban nhap vi tri can chen mang 2: ");
            int k = int.Parse(Console.ReadLine());
            int Sumlength = arr1.Length + arr2.Length;
            string[] sumArray = new string[Sumlength];
            Add(sumArray, arr1, arr2, k);
            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
        }
        static void Getdata(out string[] arr1, out string[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr1 = element1;
            arr2 = element2;
        }
        */
        #endregion
        #region Bai 22
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            SortArray(arr1);
        }
        static void SortArray(string[] arr1)
        {
            Array.Sort(arr1);
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 23
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            SortArray(arr1);
        }
        static string[] Sort(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    char[] n = arr[i].ToCharArray();
                    char[] m = arr[j].ToCharArray();
                    if (n.Length > m.Length)
                    {
                        string tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
        static void SortArray(string[] arr1)
        {
            Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 24
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            SortArray(arr1);
        }
        static string[] Sort(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    char[] n = arr[i].ToCharArray();
                    char[] m = arr[j].ToCharArray();
                    if (n.Length < m.Length)
                    {
                        string tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
        static void SortArray(string[] arr1)
        {
            Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 25
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            CheckArray(arr1);
        }
        static void CheckArray(string[] arr1)
        {
            int cout = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
               cout++;
            }
            Console.WriteLine(cout);
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 26
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1);
            CheckArray(arr1);
        }
        static bool Check(string[] arr,string stringCheck)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == stringCheck)
                {
                    return true;
                }    
            }
            return false;
        }
        static void CheckArray(string[] arr1)
        {
            string stringCheck = Console.ReadLine();
            if (Check(arr1, stringCheck))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        static void Getdata(out string[] arr1)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            arr1 = element1;
        }
        */
        #endregion
        #region Bai 27
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1, out string[] arr2);
            CheckArray(arr1, arr2);
        }
        static void CheckArray(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i].ToLower() == arr2[j].ToLower())
                    {
                        Console.WriteLine(arr1[i]);
                    }
                }
            }
        }
        static void Getdata(out string[] arr1, out string[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr1 = element1;
            arr2 = element2;
        }
        */
        #endregion
        #region Bai 28
        /*
        static void Main(string[] args)
        {
            Getdata(out string[] arr1, out string[] arr2);
            CheckArray(arr1, arr2);
        }
        static bool Check(string[] data, string i)
        {
            foreach (var item in data)
            {
                if (item.ToLower().CompareTo(i.ToLower()) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void CheckArray(string[] arr1, string[] arr2)
        {
            int index = 0;
            string[] arr = new string[arr1.Length + arr2.Length];
            foreach (var item in arr1)
            {
                if (Check(arr2, item))
                {
                    arr[index++] = item;
                }
            }
            foreach (var item in arr2)
            {
                if (Check(arr1, item))
                {
                    arr[index++] = item;
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Getdata(out string[] arr1, out string[] arr2)
        {
            Console.Write("Moi ban nhap Array1: ");
            var element1 = Console.ReadLine().Split(' ');
            Console.Write("Moi ban nhap Array2: ");
            var element2 = Console.ReadLine().Split(' ');
            arr1 = element1;
            arr2 = element2;
        }
        */
        #endregion

    }
}
