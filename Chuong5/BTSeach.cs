using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class BTSeach
    {
        #region Bai 1
        /*
        public static void Main()
        {
            Getdata(out int[] arr);
            FindData(arr, out bool check);
            Print(check);
        }

        private static void FindData(int[] arr, out bool check)
        {
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            check = TimKiemNhiPhanHove.SeachX(arr, x, 0, arr.Length - 1);
        }

        private static void Print(in bool check)
        {
            if (check)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
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
        #region Bai 2
        /*
        public static void Main()
        {
            Getdata(out int[] arr);
            FindData(arr, out int check);
            Print(check);
        }
        private static void FindData(int[] arr, out int check)
        {
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y : ");
            int y = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int cout = 0;
            if (x > y)
            {
                check = 0;
            }
            else
            {
                foreach (var item in arr)
                {
                    if (item >= x && item <= y)
                    {
                        cout++;
                    }
                }
            }
            check = cout;
        }
        private static void Print(in int check)
        {
            Console.WriteLine(check);
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
        public static void Main()
        {
            Getdata(out int[] arr);
            FindData(arr, out int check);
            Print(check);
        }
        private static void FindData(int[] arr, out int check)
        {
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int cout = 0;
            foreach (var item in arr)
            {
                if (item == x)
                {
                    cout++;
                }
            }
            check = cout;
        }
        private static void Print(in int check)
        {
            Console.WriteLine(check);
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
        public static void Main()
        {
            Getdata(out int[] arr);
            int check = FindData(arr);
            Print(check);
        }
        private static int FindData(int[] arr)
        {
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            for (int i = arr.Length -1 ; i >= 0 ; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            
            return -1;
        }
        private static void Print(in int check)
        {
            Console.WriteLine(check);
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
        public static void Main()
        {
            Getdata(out int[] arr);
            Console.Write("Nhap X : ");
            int x = int.Parse(Console.ReadLine());
            int check1 = FindData1(arr,x);
            int check2 = FindData2(arr,x);
            Print(check1,check2);
        }
        private static int FindData2(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        private static int FindData1(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
        private static void Print(in int check1 , in int check2)
        {
            Console.Write(check1 + " " + check2);
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
        public static void Main()
        {
            Getdata(out string input);
            FindData(input);
        }
        static int CoutX(char[] arr , int x)
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
        static bool Check(char[] arr , int x , int pos)
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
        private static void FindData(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check(arr, arr[i], i))
                {
                    Console.WriteLine($"{arr[i]} + {CoutX(arr, arr[i])}");
                }    
            }
        }

        private static void Getdata(out string input)
        {
            var inputString = Console.ReadLine();
            input = inputString;
        }
        */
        #endregion

    }
}
