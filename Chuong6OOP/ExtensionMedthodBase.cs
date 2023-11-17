using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP.ExtensionMethodBase
{
    public static class ExtensionMedthodBase
    {
        public static int DemSoLanXuatHien(this string input)
        {
            var result = Split(input);
            return result.Length;
        }

        public static string[] Split(this string input)
        {
            var result = input.Split(new char[] { '\n', ' ', '\t', '.', '?', ';', ':', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }
        private static string StringToChar(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }
            char[] letters = word.ToCharArray();
            if (char.IsLower(letters[0]))
            {
                letters[0] = char.ToUpper(letters[0]);
            }
            return new string(letters);
        }
        public static string VietHoaChuCaiDauTien(this string intput)
        {
            var result = Split(intput);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = StringToChar(result[i]);
            }
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public static string SapXepTuADenZ(this string input)
        {
            var result = Split(input);
            Array.Sort(result, 0, result.Length);
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public static string SapXepTheoDoDai(this string input)
        {
            var result = Split(input);
            Array.Sort(result, (p1, p2) => p1.ToCharArray().Length - p2.ToCharArray().Length);
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public static string TimChuCaiBatDauTuK(this string input, char k)
        {
            var result = Split(input);
            var word = new string[result.Length];
            int size = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].ToCharArray()[0] == k)
                {
                    word[size++] = result[i];
                }
            }
            var finalResult = new string[size];
            Array.Copy(word, finalResult, size);
            return string.Join(" ", finalResult);
        }

        public static string TimDoDaiLonNhat(this string input)
        {
            var result = Split(input);
            var word = new string[result.Length];
            int size = 0;
            Array.Sort(result, (p1, p2) => p2.ToCharArray().Length - p1.ToCharArray().Length);
            for (int i = 0; i < result.Length; i++)
            {
                if (result[0].ToCharArray().Length == result[i].ToCharArray().Length)
                {
                    word[size++] = result[i];
                }
            }
            var finalResult = new string[size];
            Array.Copy(word, finalResult, size);
            return string.Join(" ", finalResult);
        }
        public static string TimDoDaiNhoNhat(this string input)
        {
            var result = Split(input);
            var word = new string[result.Length];
            int size = 0;
            Array.Sort(result, (p1, p2) => p2.ToCharArray().Length - p1.ToCharArray().Length);
            Array.Reverse(result);
            for (int i = 0; i < result.Length; i++)
            {
                if (result[0].ToCharArray().Length == result[i].ToCharArray().Length)
                {
                    word[size++] = result[i];
                }
            }
            var finalResult = new string[size];
            Array.Copy(word, finalResult, size);
            return string.Join(" ", finalResult);
        }

        public static string DaoNguoc(this string input)
        {
            var result = Split(input);
            Array.Reverse(result);
            return string.Join(" ", result);
        }
        public static string SoSangNhiPhan(this int number)
        {
            return Convert.ToString(number, 2);
        }

        public static string SoSangHexa(this int number)
        {
            return Convert.ToString(number, 16);
        }

        public static int NhiPhanSangInt(this string number)
        {
            return Convert.ToInt32(number, 2);
        }

        public static int HexaSangInt(this string number)
        {
            return Convert.ToInt32(number, 16);
        }
        public static int TimMax(this int[] input)
        {
            int max = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (max < input[i] )
                {
                    max = input[i];
                }
            }
            return max;
        }
    }
}
