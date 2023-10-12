using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class Array2
    {
        #region Nhập xuất mảng ziczac
        /*
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so hang mang ziczac: ");
            int row = int.Parse(Console.ReadLine());
            int[][] zicZac = new int[row][];
            for (int i = 0; i < zicZac.Length; i++)
            {
                Console.Write($"Moi ban nhap so luong phan tu cua hang {i} : ");
                zicZac[i] = new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < zicZac.Length; i++)
            {
                for (int j = 0; j < zicZac[i].Length; j++)
                {
                    Console.Write($"Moi ban nhap phan tu cua hang {i} cot {j}: ");
                    zicZac[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Mang ziczac la:");
            for (int i = 0; i < zicZac.Length; i++)
            {
                for (int j = 0; j < zicZac[i].Length; j++)
                {
                    Console.Write(zicZac[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        */
        #endregion
        #region Bai 1
        /*
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Nhap vi tri ({i},{j}): ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }     
        }
    }
    */
        #endregion
        #region Bai 2
        /*
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Nhap vi tri ({i},{j}): ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            TranferArray(arr);
        }
        static void TranferArray(int[,] arr)
        {
            int m = arr.GetLength(1);
            int n = arr.GetLength(0);
            float[,] result = new float[m, n];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i,j] = arr[j,i]} ");
                }
                Console.WriteLine();
            }
        }
    }
    */
        #endregion
        #region Bai 3
        /*
        static void Main()
        {
            while (true)
            {
                Console.Write("Nhap hang va cot cua mang 1: ");
                var data1 = Console.ReadLine().Split(' ');
                int m = int.Parse(data1[0]);
                int n = int.Parse(data1[1]);
                Console.Write("Nhap hang va cot cua mang 2: ");
                var data2 = Console.ReadLine().Split(' ');
                int a = int.Parse(data2[0]);
                int b = int.Parse(data2[1]);
                if (n!=m || a!=b)
                {
                    Console.WriteLine("So luong hang va cot phai khop nhau");
                    continue;
                }
                int[,] arr1 = new int[m, n];
                int[,] arr2 = new int[a, b];
                // nhap phan tu trong mang 1 va 2
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        Console.Write($"Nhap vi tri ({i},{j}) Mang 1: ");
                        arr1[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        Console.Write($"Nhap vi tri ({i},{j}) Mang 2: ");
                        arr2[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Mang 1:");
                // in ra mang 1 va 2 
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        Console.Write(arr1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Mang 2:");
                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        Console.Write(arr2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
                {
                    Console.WriteLine("Sai so luong hang va cot");
                    continue;
                }
                else
                {
                    Console.WriteLine("Mang 1 + Mang 2:");
                    SumArray(arr1, arr2);
                }
                continue;
            }
        }
        static void SumArray(int[,] arr1, int[,] arr2)
        {
            int m = arr1.GetLength(0);
            int n = arr1.GetLength(1);
            int[,] sumArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumArray[i, j] = arr1[i, j] + arr2[i, j];
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        */
        #endregion
        #region Bai 4
        /*
        static void Main()
        {
            int[,] arr = new int[9, 13];    
            CrossArray(arr);
        }
        static void CrossArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == 0 || i == 8) && (j >= 4 && j <= 8) || (i == 1 || i == 2 || i == 6 || i == 7) && (j == 4 || j == 8) ||
                        (i==3||i==5) && (j<=4 || j >=8) || i==4 && (j==0||j==12))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                      
                }
                Console.WriteLine();
            }
        }
        */
        #endregion
        #region Bai 5
        /*
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            HCN(arr);
        }
        static void HCN(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {                   
                        Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        */
        #endregion
        #region Bai 6
        /*
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            HCN(arr);
        }
        static void HCN(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == arr.GetLength(0) -1   || j == arr.GetLength(1) -1  )
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
        */
        #endregion
        #region Bai 7
          /*
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string[][] arr = new string[m][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[i + 1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = "*";
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }  
        */
        #endregion
        #region Bai 8
        /*
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            string[,] arr = new string[h, 2 * h];
            TG(arr, h);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void TG(string[,] arr, int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= 2 * h - 1; j++)
                {
                    if (j >= (h - i + 1) && j <= (h + i - 1))
                    {
                        arr[i - 1, j - 1] = " * ";
                    }
                    else
                    {
                        arr[i - 1, j - 1] = "   ";
                    }
                }
            }
        }
        */
        #endregion
        #region Bai 9

        /*static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            string[,] arr = new string[h, 2 * h];
            TG(arr, h);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void TG(string[,] arr, int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= 2 * h - 1; j++)
                {
                    if (j >= (h - i + 1) && j <= (h + i - 1))
                    {
                        arr[i - 1, j - 1] = $" {i - Math.Abs(h - j)} ";
                    }
                    else
                    {
                        arr[i - 1, j - 1] = "   ";
                    }
                }
            }
        }
        */
        #endregion


    }
}
