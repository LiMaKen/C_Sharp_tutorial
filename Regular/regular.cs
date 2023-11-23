using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

interface IControler
{
    bool IsStudentId(string studentId);
    bool IsBirth(string birth);
    bool IsName(string name);
    bool IsEmail(string email);
    bool IsPhone(string phone);
    bool IsSubjectId(string idSubject);
    bool IsCourseId(string idCourse);
    bool IsTranScriptId(string idTranScript);
}
class Controler : IControler
{
    public bool IsBirth(string birth)
    {
        // thang 01-09, 10 11 12
        // ngay 01-09, 10-19, 20-29, 30-31
        var pattern = @"^(0[0-9]|1[0-9]|2[0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$";
        var result = new Regex(pattern);
        return result.IsMatch(birth);
    }

    public bool IsCourseId(string idCourse)
    {
        throw new NotImplementedException();
    }

    public bool IsEmail(string email)
    {
        var pattern = @"^[a-z0-9.-_]+\@[a-z0-9]+\.[a-z]{2,4}$";
        var result = new Regex(pattern, RegexOptions.IgnoreCase);
        return result.IsMatch(email);
    }

    public bool IsName(string fullName)
    {
        var pattern = @"^[a-z ]{1,40}$";
        var result = new Regex(pattern, RegexOptions.IgnoreCase);
        return result.IsMatch(fullName);
    }

    public bool IsPhone(string phone)
    {
        var pattern = @"^(03|08|09)\d{8}$";
        var result = new Regex(pattern);
        return result.IsMatch(phone);
    }

    public bool IsStudentId(string studentId)
    {
        var pattern = @"^B\d{2}[A-Z]{4}\d{3}$";
        var result = new Regex(pattern);
        return result.IsMatch(studentId);
    }

    public bool IsSubjectId(string idSubject)
    {
        var pattern = @"^1[0-9]{4}$";
        var result = new Regex(pattern);
        return result.IsMatch(idSubject);
    }

    public bool IsTranScriptId(string idTranScript)
    {
        throw new NotImplementedException();
    }
}
#region Bai 1
interface IStaff
{
    void CheckIn(string time);
    void CheckOut(string time);
    long SumSalary(long profit = 0);
}
abstract class BaseStaff : IStaff
{
    private static int amount = 1000;
    public string Id { get; set; }
    public FullName FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public long Salary { get; set; }
    public int WorkingDay { get; set; }
    public long RealSalary { get; set; }
    public BaseStaff()
    {
        Id = "EMP" + amount++;
    }
    public BaseStaff(string id, string name, string email, string phone, long salary, int workingDay)
    {
        Id = string.IsNullOrEmpty(id) ? "EMP" + amount++ : id;
        FullName = new FullName(name);
        Email = email;
        Phone = phone;
        Salary = salary;
        WorkingDay = workingDay;
    }
    public abstract void CheckIn(string time);
    public abstract void CheckOut(string time);
    public abstract long SumSalary(long profit = 0);
}
class Staff : BaseStaff
{
    public Staff() : base()
    {
    }
    public Staff(string id, string name, string email, string phone, long salary, int workingDay) : base(id, name, email, phone, salary, workingDay)
    {

    }
    public override void CheckIn(string time)
    {
        Console.WriteLine($"Nhan vien {FullName} check in luc {time}");
    }
    public override void CheckOut(string time)
    {
        Console.WriteLine($"Nhan vien {FullName} check out luc {time}");
    }
    public override long SumSalary(long profit = 0)
    {
        var bonus = (WorkingDay >= 22) ? Salary * 0.2f : 0;
        RealSalary = (long)(Salary * WorkingDay / 22 + bonus);
        return RealSalary;
    }
}
class Manager : Staff
{
    public string Role { get; set; }
    public float Bonus { get; set; }
    public Manager() : base()
    {

    }
    public Manager(string id, string name, string email, string phone, long salary, int workingDay, string role, float bomus) : base(id, name, email, phone, salary, workingDay)
    {
        Role = role;
        Bonus = bomus;
    }
    public override long SumSalary(long profit = 0)
    {
        var resultSalary = base.SumSalary(profit);
        RealSalary = resultSalary + (long)(resultSalary * Bonus);
        return RealSalary;
    }

}
class Director : Staff
{
    public string Role { get; set; }
    public string Time { get; set; }
    public float Bonus { get; set; }
    public Director() : base()
    {

    }
    public Director(string id, string name, string email, string phone, long salary, int workingDay, string role, string time, float bonus) : base(id, name, email, phone, salary, workingDay)
    {
        Role = role;
        Time = time;
        Bonus = bonus;
    }
    public override long SumSalary(long profit = 0)
    {
        var resultSalary = base.SumSalary(profit);
        RealSalary = resultSalary + (long)(resultSalary * 0.15f) + (long)(profit * Bonus);
        return RealSalary;
    }
}
class FullName
{
    public string FirstName { get; set; }
    public string MidName { get; set; }
    public string Lastname { get; set; }
    public FullName(string name)
    {
        SetFullName(name);
    }

    private void SetFullName(string name)
    {
        var data = name.Split(' ');
        FirstName = data[0];
        Lastname = data[data.Length - 1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.TrimEnd();
    }
    public override string ToString() => $"{FirstName} {MidName} {Lastname}";
}
#endregion
class Run
{
    static void Main()
    {
        int[] invalidMenTop = { 4, 16, 24, 25, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 63, 74, 75, 76, 77, 78, 79, 80, 95, 96, 97, 98, 102, 115, 116, 117, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135 };

        int[] fullRange = Enumerable.Range(0, 164).ToArray();

        int[] newArray = fullRange.Except(invalidMenTop).ToArray();
        var data = "";
        foreach (int num in newArray)
        {
           data += num + ", ";
        }
        Console.WriteLine(data);
    }
}