using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chuong5
{
    internal class Array1
    {
        #region Bai 1
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    var result = SumArray(newArray);
                    MSG(result, newArray);

                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static int SumArray(int[] arrays)
        {
            int s = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                s += arrays[i];
            }
            return s;
        }
        static void MSG(int result, int[] newArray)
        {
            Console.WriteLine("Mang vua nhap la:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]);
            }
            Console.WriteLine($"Tong cac phan tu trong mang la: {result}");
        }*/
        #endregion
        #region Bai 2
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    var result = SumArray(newArray);
                    MSG(result, newArray);

                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static double SumArray(int[] arrays)
        {
            double s = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                s += arrays[i];
            }
            return (double)s/arrays.Length;
        }
        static void MSG(double result, int[] newArray)
        {
            Console.Write("Mang vua nhap la:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.WriteLine($"Trung binh cong cac phan tu trong mang la: {result}");
        }*/
        #endregion
        #region Bai 3
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string test = Console.ReadLine();
                if(int.TryParse(test,out int n)== false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    var result = SumArray(newArray);
                    MSG(result, newArray);

                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static double SumArray(int[] arrays)
        {
            int numberIndex = 0;
            int[] test = new int[arrays.Length];
            double s = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] % 2 == 0)
                {
                    test[i] = arrays[i];
                    Console.WriteLine($"--------{test[i]}");
                    numberIndex++;
                }            
            }           
            foreach (var item in test)
            {
                Console.WriteLine($"++++++++{item}");
                s += item;
            }
            return (double)s / numberIndex ;
        }
        static void MSG(double result, int[] newArray)
        {
            Console.Write("Mang vua nhap la:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.WriteLine($"Trung binh cong cac phan tu trong mang la: {result}");
        }*/
        #endregion
        #region Bai 4
        /* static void Main(string[] args)
         {
             while (true)
             {
                 Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                 string test = Console.ReadLine();
                 if (int.TryParse(test, out int n) == false)
                 {
                     Console.WriteLine("sai dinh dang");
                     continue;
                 }
                 if (n > 0)
                 {
                     int[] array = new int[n];
                     var newArray = GetArray(array);
                     //MSG(newArray);
                     Find(newArray);
                 }
                 continue;
             }
         }
         static int[] GetArray(int[] array)
         {
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                 array[i] = int.Parse(Console.ReadLine());
             }
             return array;
         }
         static bool IsPrimeNumber(int a)
         {
            if (a < 2)
             {
                 return false;
             }
             int bound = (int)Math.Sqrt(a);
             for (int i = 2; i < bound; i++)
             {
                 if(a%i == 0)
                 {
                     return false;
                 }
             }
             return true;
         }
         static void Find(int[] newArray)
         {

             for (int i = 0; i < newArray.Length; i++)
             {
                 if (IsPrimeNumber(newArray[i]))
                 {
                     Console.WriteLine($"({i},{newArray[i]})");
                 }
             }
         }*/

        #endregion
        #region Bai 5
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string test = Console.ReadLine();
                if (int.TryParse(test, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    //MSG(newArray);
                    Find(newArray);
                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static bool IsCP(int a)
        {
            double b = Math.Sqrt(a);
            if (b*b == a)
            {
                return true;
            }
            return false;
        }
        static void Find(int[] newArray)
        {

            for (int i = 0; i < newArray.Length; i++)
            {
                if (IsCP(newArray[i]))
                {
                    Console.WriteLine($"({i},{newArray[i]})");
                }
            }
        }*/
        #endregion
        #region Bai 6
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string test = Console.ReadLine();
                if (int.TryParse(test, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    Find(newArray);
                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static bool IsTN(int a)
        {
            if (a < 0)
            {
                a = -a;
            }
            if (a < 10)
            {
                return false;
            }
            int rev = 0;
            int m = a;
            while (m > 0)
            {
                rev = rev * 10 + m % 10;
                m /= 10;
            }
            return rev == a;
        }
        static void Find(int[] newArray)
        {

            for (int i = 0; i < newArray.Length; i++)
            {
                if (IsTN(newArray[i]))

                    Console.WriteLine($"{newArray[i]}");
            }
        }*/
        #endregion
        #region Bai 7
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string test = Console.ReadLine();
                if (int.TryParse(test, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckMaxMin(newArray,n);
                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void CheckMaxMin(int[] newArray, int n)
        {
           /* int checkNumber = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[i] == newArray[j])
                    {
                        checkNumber++;
                    }
                }
            }
            if (checkNumber == n - 1)
            {
                Console.WriteLine(" khong ton tai so lon nhat va nho nhat");
            }
            else
            {*/
        // Max(newArray, out int checkMax);
        //Min(newArray, out int checkMin);
        //MSG(checkMax, checkMin);
        //}
        /* }
         static void Max(int[] newArray, out int checkMax)
         {
             int max = newArray[0];
             for (int i = 0; i < newArray.Length; i++)
             {
                 if (max < newArray[i])
                 {
                     max = newArray[i];
                 }
             }
              checkMax = max;
         }
         static void Min(int[] newArray, out int checkMin)
         {
             int min = newArray[0];
             for (int i = 0; i < newArray.Length; i++)
             {
                 if (min > newArray[i])
                 {
                     min = newArray[i];
                 }
             }
             checkMin = min;
         }
         static void MSG(in int checkMax, in int checkMin)
         {
             Console.WriteLine($"{(checkMin==checkMax ? "Khong co gia tri" : checkMax +" "+ checkMin)}");
            // Console.WriteLine($"gia tri lon nhat trong mang la: {checkMax}");
            // Console.WriteLine($"gia tri nho nhat trong mang la: {checkMin}");
         }*/
        #endregion
        #region Bai 8
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string test = Console.ReadLine();
                if (int.TryParse(test, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    Max(newArray,out int checkMax);
                    Min(newArray,out int checkMin);
                    SecondMaxMin(newArray,checkMax,checkMin,out int secondMax, out int secondMin);
                    Console.WriteLine($"{(secondMax == secondMin ? "NOT" : secondMax +" " + secondMin)}");
                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void SecondMaxMin(int[] newArray,int checkMax,int checkMin,out int secondMax,out int secondMin)
        {
            secondMax = checkMin;
            secondMin = checkMax;
            foreach(var item in newArray)
            {
                if(item != checkMax && item > secondMax)
                {
                    secondMax = item;
                }
                if (item != checkMin && item < secondMin)
                {
                    secondMin= item;
                }
            }
        }
        static void Max(int[] newArray, out int checkMax)
        {
            int max = newArray[0];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (max < newArray[i])
                {
                    max = newArray[i];
                }
            }
            checkMax = max;
        }
        static void Min(int[] newArray, out int checkMin)
        {
            int min = newArray[0];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (min > newArray[i])
                {
                    min = newArray[i];
                }
            }
            checkMin = min;
        }*/
        #endregion
        #region Bai 9
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                Console.WriteLine("Moi ban nhap so x can check trong mang:");
                string checkX = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false || int.TryParse(checkX, out int x) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckX(x,newArray);
                   
                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void CheckX(int x, int[] newAraay)
        {
            int cout = 0;
            for (int i = 0; i < newAraay.Length; i++)
            {
                if(x == newAraay[i]) 
                { 
                    cout++;
                }
            }
            Console.WriteLine($"Co {cout} lan xuat hien so {x} ");
        }*/

        #endregion
        #region Bai 10
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                Console.WriteLine("Moi ban nhap so k can chia trong mang:");
                string checkK = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false || int.TryParse(checkK, out int k) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if(k == 0 || n <= 0)
                {
                    Console.WriteLine("ERROR");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckK(k, newArray);

                }
                continue;
            }
        }
        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void CheckK(int k, int[] newAraay)
        {
            int cout = 0;
            for (int i = 0; i < newAraay.Length; i++)
            {
                if (newAraay[i] % k == 0)
                {
                    cout++;
                }
            }
            Console.WriteLine($"Co {cout} so chia het cho {k} ");
        }*/

        #endregion
        #region Bai 11
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    bool check = CheckArray(newArray);
                    MSG(check);
                }
                continue;
            }
        }

        private static void MSG(bool check)
        {
            if(check)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static bool CheckArray(int[] newAraay)
        {
            int mid = newAraay.Length / 2;
            
            for (int i = 0; i <= mid; i++)
            {
                if (newAraay[i] != newAraay[newAraay.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }*/

        #endregion
        #region Bai 12
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    SortArray(newArray);
                  
                }
                continue;
            }
        }

        private static void MSG(bool check)
        {
            if (check)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void SortArray(int[] newAraay)
        {
            
            for (int i = 0; i < newAraay.Length; i++)
            {
                
                for (int j = i+1; j < newAraay.Length; j++)
                {
                    
                    if (newAraay[j] < newAraay[i])
                    {
                        int tmp = newAraay[i];
                        newAraay[i] = newAraay[j];
                        newAraay[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < newAraay.Length; i++)
            {
                Console.WriteLine(newAraay[i]);
            }
        }*/

        #endregion
        #region Bai 13
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    DecArray(newArray);

                }
                continue;
            }
        }

        private static void MSG(bool check)
        {
            if (check)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
       
        static void DecArray(int[] newAraay)
        {
            
            for (int i = 0; i < newAraay.Length; i++)
            {

                for (int j = i + 1; j < newAraay.Length; j++)
                {

                    if (newAraay[j] > newAraay[i])
                    {
                        int tmp = newAraay[i];
                        newAraay[i] = newAraay[j];
                        newAraay[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < newAraay.Length; i++)
            {
                Console.WriteLine(newAraay[i]);
            }
        }*/
        #endregion
        #region Bai 14
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckArray(newArray, ref n);

                }
                continue;
            }
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void DeleteArray(int[] array, int pos)
        {
            for (int i = pos + 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
        }
        static void CheckArray(int[] newAraay, ref int n)
        {
            int cout = 0;
            Console.WriteLine("////////////" + n);
            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {

                    if (newAraay[i] == newAraay[j])
                    {
                        DeleteArray(newAraay, j);
                        cout++;
                        n--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(newAraay[i]);
            }
            Console.WriteLine($"=========={cout}=========");
        }*/
        #endregion
        #region Bai 15
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckArray(newArray, ref n);

                }
                continue;
            }
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void DeleteArray(int[] array, int pos)
        {
            for (int i = pos + 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
        }
        static void CheckArray(int[] newAraay, ref int n)
        {
            int cout = 1;
            Console.WriteLine("////////////" + n);
            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {

                    if (newAraay[i] == newAraay[j])
                    {
                        DeleteArray(newAraay, j);
                        cout++;
                        n--;
                    }
                }
                Console.WriteLine($"{newAraay[i]} + {cout}");
                cout = 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(newAraay[i]);
            }
            Console.WriteLine($"=========={cout}=========");
        }*/
        #endregion
        #region Bai 16
        // khó vcl
        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang:");
                string checkN = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array = new int[n];
                    var newArray = GetArray(array);
                    CheckArray(newArray, ref n);

                }
                continue;
            }
        }

        static int[] GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Moi ban nhap phan tu thu {i} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void DeleteArray(int[] array, int pos)
        {
            for (int i = pos + 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
        }
        static void CheckArray(int[] newAraay, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < newAraay.Length; j++)
                {
                    if (newAraay[j] - newAraay[i] == 1)
                    {
                        n--; // khó vcl
                    }
                }
                        

            }
        }*/
        #endregion
        #region Bai 17
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Moi ban nhap n phan tu trong mang1:");
                string checkN = Console.ReadLine();
                Console.WriteLine("Moi ban nhap m phan tu trong mang2:");
                string checkM = Console.ReadLine();
                if (int.TryParse(checkN, out int n) == false || int.TryParse(checkM, out int m) == false)
                {
                    Console.WriteLine("sai dinh dang");
                    continue;
                }
                if (n > 0)
                {
                    int[] array1 = new int[n];
                    int[] array2 = new int[m];
                    for (int i = 0; i < array1.Length; i++)
                    {
                        Console.Write($"Moi ban nhap phan tu thu {i} cua mang Array1 : ");
                        array1[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < array2.Length; i++)
                    {
                        Console.Write($"Moi ban nhap phan tu thu {i} cua mang Array2 : ");
                        array2[i] = int.Parse(Console.ReadLine());
                    }

                    CoppyArray(array1, array2);
                }
                continue;
            }
        }

        static void CoppyArray(int[] array1, int[] array2)
        {
            int length = array1.Length + array2.Length;
            int index = 0;
            int[] result = new int[length];
            foreach(var item in array1)
            {
                result[index] = item;
                index++;
            }
            foreach(var item in array2)
            {
                result[index] = item;
                index++;
            }
            Console.WriteLine("-------" + result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }


        #endregion
    }
}
