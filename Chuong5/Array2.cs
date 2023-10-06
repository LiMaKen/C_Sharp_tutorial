using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    internal class Array2
    {
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
        static void Main()
        {
            Console.Write("Nhap hang cua mang 1: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap cot cua mang 1:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang cua mang 2:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap cot cua mang 2:");
            int b = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Mang 1 + Mang 2:");
            SumArray(arr1,arr2);
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
            }
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    Console.Write(sumArray[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    #endregion
}
