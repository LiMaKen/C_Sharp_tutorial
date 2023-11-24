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
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        var newObj = obj as Staff;
        return newObj.Id.Equals(this.Id);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
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
class StaffUitl
{
    public static Staff Create() 
    {
        Console.WriteLine("Nhap vao lua chon: ");
        int x = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            return CreateStaff();
        }
        else if (x ==2)
        {
            return CreateManager();
        }
        else if(x ==3)
        {
            return CreateDirector();
        }
        return null;
    }

    private static Director CreateDirector()
    {
        var staff = CreateStaff();
        Console.WriteLine("Nhap vao chuc vu: ");
        string role = Console.ReadLine();
        Console.WriteLine("Nhap vao thoi gian nhan viec: ");
        string time = Console.ReadLine();
        Console.WriteLine("Nhap vao he so tien thuong: ");
        float bonus = float.Parse(Console.ReadLine());
        return new Director(staff.Id, staff.FullName.ToString(), staff.Email, staff.Phone, staff.Salary, staff.WorkingDay, role, time, bonus);
    }

    private static Manager CreateManager()
    {
        var staff = CreateStaff();
        Console.WriteLine("Nhap vao chuc vu: ");
        string role = Console.ReadLine();
        Console.WriteLine("Nhap vao he so tien thuong: ");
        float bonus = float.Parse(Console.ReadLine());
        return new Manager(staff.Id, staff.FullName.ToString(), staff.Email, staff.Phone, staff.Salary, staff.WorkingDay, role, bonus);
    }

    private static Staff CreateStaff()
    {
        Controler controler = new Controler();
        while (true)
        {
            Console.WriteLine("Nhap vao ho ten: ");
            string name = Console.ReadLine();
            if (!controler.IsName(name)) continue;
            Console.WriteLine("Nhap vao email: ");
            string email = Console.ReadLine();
            if (!controler.IsEmail(email)) continue;
            Console.WriteLine("Nhap vao so dien thoai: ");
            string phone = Console.ReadLine();
            if (!controler.IsPhone(phone)) continue;
            Console.WriteLine("Nhap vao muc luong: ");
            long salary = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so ngay lam viec: ");
            int wokingDay = int.Parse(Console.ReadLine());
            return new Staff(null, name, email, phone, salary, wokingDay);
        }
    }
    static void RealSalary(Staff[] staff)
    {
        foreach (var item in staff)
        {
            item.SumSalary(100000);
        }
    }
    static void SortStaffBySalary(Staff[] staff)
    {
        int comparer(BaseStaff a, BaseStaff b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            else if (a == null && b != null)
            {
                return -1;
            }
            else if (a != null && b == null)
            {
                return 1;
            }
            return (int)(b.Salary - a.Salary);
        };
        Array.Sort(staff, comparer);
    }
    static void SortStaffByDay(Staff[] staff)
    {
        int comparer(BaseStaff a, BaseStaff b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            else if (a == null && b != null)
            {
                return -1;
            }
            else if (a != null && b == null)
            {
                return 1;
            }
            return (b.WorkingDay > a.WorkingDay) ? 1 : (b.WorkingDay == a.WorkingDay) ? 0 : -1;
        };
        Array.Sort(staff, comparer);
    }
    static void SeachStaff(Staff[] staffs)
    {
        Console.WriteLine("Nhap vao ma nhan vien: ");
        string id = Console.ReadLine();
        var staff = GetStaff(staffs , id);
        if (staff == null) return;
    }

    private static Staff GetStaff(Staff[] staffs, string id)
    {
        foreach (var item in staffs)
        {
            if (item != null && item.Id.CompareTo(id) == 0)
            {
                return item;
            }
        }
        return null;
    }
    public static void EditSalary(Staff[] staffs)
    {
        Console.WriteLine("Nhap vao ma nhan vien: ");
        string id = Console.ReadLine();
        var staff = GetStaff(staffs, id);
        if (staff == null) return;
        Console.WriteLine("Nhap vao muc luong can sua: ");
        long newSalary = long.Parse(Console.ReadLine());
        staff.Salary = newSalary;
    }
    public static void DeleteStaff(Staff[] staffs)
    {
        Console.WriteLine("Nhap vao ma nhan vien: ");
        string id = Console.ReadLine();
        var staff = GetStaff(staffs, id);
        if (staff == null) return;
        for (int i = 0; i < staffs.Length; i++)
        {
            if (staff.Equals(staffs[i]))
            {
                staffs[i] = null;
            }
        }
    }
}
class Run
{
    static void Main()
    {
       
    }
}