using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Chuong6OOP.Interface;
#region Bai 3
interface Geometry
{
    double Perimeter();
    double Area();
}
class Circle : Geometry
{
    public int Radius { get; set; }
    public Circle()
    {

    }

    public double Perimeter()
    {
        return 2 * Radius * Math.PI;
    }

    public double Area()
    {
        return Math.Pow(Perimeter(), 2) / (4 * Math.PI * Radius);
    }
}
class Rectangle : Geometry
{
    public int Length { get; set; }
    public int Width { get; set; }

    public double Area()
    {
        return Length * Width;
    }

    public double Perimeter()
    {
        return (Length + Width) * 2;
    }
}
class Triangle : Geometry
{
    public int AB { get; set; }
    public int AC { get; set; }
    public int BC { get; set; }

    public double Area()
    {
        var p = Perimeter();
        return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
    }

    public double Perimeter()
    {
        return AB + AC + BC;
    }
}
class Trapezium : Geometry
{
    public int BigBottom { get; set; }
    public int SmallBottom { get; set; }
    public int Height { get; set; }

    public double Area()
    {
        return 0.5 * (BigBottom + SmallBottom) * Height;
    }

    public double Perimeter()
    {
        return BigBottom + SmallBottom + 2 * Math.Sqrt(Math.Pow((BigBottom - SmallBottom) / 2, 2) + Height * Height);
    }
}
class Rhombus : Geometry
{
    public int LengthDiagonalLine { get; set; }

    public double Area()
    {
        return (LengthDiagonalLine * LengthDiagonalLine) / 2.0;
    }

    public double Perimeter()
    {
        return 4 * Math.Sqrt((LengthDiagonalLine * LengthDiagonalLine) / 4.0);
    }
}
#endregion
#region Bai 5
interface IUiltBase
{
    string[] Split(string input);
    int Cout(string input);
    string Up(string input);
    string Sort(string input);
    string SortByLength(string input);
    string SeachByK(char k,string input);
    string SeachMaxLength(string input);
    string SeachMinLength(string input);
    string Revers(string input);
}
class Uilt : IUiltBase
{
    public int Cout(string input)
    {
        var result = Split(input);
        return result.Length;
    }

    public string[] Split(string input)
    {
        var result = input.Split(new char[] { '\n', ' ', '\t', '.', '?', ';', ':', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);
        return result;
    }
    static string StringToChar(string word)
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
    public string Up(string intput)
    {
        var result = Split(intput);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = StringToChar(result[i]);
        }
        var data = string.Join(" ", result);
        return data.TrimEnd();
    }

    public string Sort(string input)
    {
        var result = Split(input);
        Array.Sort(result, 0, result.Length);
        var data = string.Join(" ", result);
        return data.TrimEnd();
    }

    public string SortByLength(string input)
    {
        var result = Split(input);
        Array.Sort(result,(p1,p2) => p2.ToCharArray().Length - p1.ToCharArray().Length);
        var data = string.Join(" ", result);
        return data.TrimEnd();
    }

    public string SeachByK(char k, string input)
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
        return string.Join(" ",finalResult);
    }

    public string SeachMaxLength(string input)
    {
        var result = Split(input);
        var word = new string[result.Length];
        int size = 0;
        Array.Sort(result, (p1, p2) => p2.ToCharArray().Length - p1.ToCharArray().Length);
        for (int i = 0; i < result.Length; i++)
        {
            if (result[0].ToCharArray().Length == result[i].ToCharArray().Length )
            {
                word[size++] = result[i];
            }
        }
        var finalResult = new string[size];
        Array.Copy(word, finalResult, size);
        return string.Join(" ", finalResult);
    }
    public string SeachMinLength(string input)
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

    public string Revers(string input)
    {
        var result = Split(input);
        Array.Reverse(result);
        return string.Join(" ", result);
    }
}
class Run
{
    static void Main()
    {
        string input = "He xin chao cac ban ! minh ten la Tuuu";
        Uilt stringUilt = new Uilt();
        Console.WriteLine($"Chuoi string co {stringUilt.Cout(input)} tu");
        Console.WriteLine($"Viet Hoa Chu Cai Dau: {stringUilt.Up(input)}");
        Console.WriteLine($"Sap xep : {stringUilt.Sort(input)}");
        Console.WriteLine($"Sap xep do dai cua tu: {stringUilt.SortByLength(input)}");
        Console.WriteLine($"Tim tai ki tu k: {stringUilt.SeachByK('c',input)}");
        Console.WriteLine($"Tim tu dai nhat: {stringUilt.SeachMaxLength(input)}");
        Console.WriteLine($"Tim tu ngan nhat: {stringUilt.SeachMinLength(input)}");
        Console.WriteLine($"Dao nguoc: {stringUilt.Revers(input)}");
    }
}
#endregion
