using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public  double Area()
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
}
class Uilt : IUiltBase
{
    public string[] Split(string input)
    {
        var result = input.Split(new char[] { '\n', ' ', '\t', '.', '?', ';', ':', '!', ',' },
                  StringSplitOptions.RemoveEmptyEntries);
        return result;
    }
}
class Run
{
    static void Main()
    {
        string input = "xin chao cac ban ! minh ten la Tu";
        Uilt stringUilt = new Uilt();
    }
}
#endregion
