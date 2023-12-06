using Database.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BTStaff;

internal class Staff
{
    public string StaffId { get; set; }
    public FullName FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public long Salary { get; set; }
    public int WorkingDay { get; set; }
    public long RealSalary { get; set; }
    public Staff()
    {
    }
    public Staff(string staffId, string fullName, string email, string phone, string role, long salary, int workingDay, long realsalary = 0)
    {
        StaffId = staffId;
        FullName = new FullName(fullName);
        Email = email;
        Phone = phone;
        Role = role;
        Salary = salary;
        WorkingDay = workingDay;
        RealSalary = realsalary;
        
    }
    public void CheckIn()
    {
        var conmmand = DatabaseConnect.Connection.CreateCommand();
        conmmand.CommandText = "UPDATE staff SET checkin=@checkin WHERE staffid=@staffid LIMIT 1";
        conmmand.Parameters.AddWithValue("id",StaffId);
        conmmand.Parameters.AddWithValue("checkin", DateTime.Now);
        conmmand.ExecuteNonQuery();
    }
    public void CheckOut()
    {
        var conmmand = DatabaseConnect.Connection.CreateCommand();
        conmmand.CommandText = "UPDATE staff SET checkout=@checkout WHERE staffid=@staffid LIMIT 1";
        conmmand.Parameters.AddWithValue("id", StaffId);
        conmmand.Parameters.AddWithValue("checkout", DateTime.Now);
        conmmand.ExecuteNonQuery();
    }
    public virtual long SumSalary(long profit = 0)
    {
        var salary = Salary * WorkingDay / 22;
        var bonus = WorkingDay >= 22 ? Salary * 0.2 : 0;
        RealSalary = (long)(salary + bonus);
        return RealSalary;
    }
    public override string ToString() => GetType().Name;
}
class Manager : Staff
{
    public float Bonus { get; set; }
    public Manager() : base() { }
    public Manager(string staffId, string fullName, string email, string phone, string role, long salary, int workingDay, long realsalary,float bonus) 
        : base(staffId, fullName,email,phone,role,salary,workingDay,realsalary)
    {
        Bonus = bonus;
    }
    public override long SumSalary(long profit = 0)
    {
        var salary = base.SumSalary();
        RealSalary = (long)(salary + Bonus * salary);
        return RealSalary;
    }
    public override string ToString() => GetType().Name;
}
class Director : Staff
{
    public float Bonus { get; set; }
    public string Time { get; set; }
    public Director() : base() { }
    public Director(string staffId, string fullName, string email, string phone, string role, long salary, int workingDay, long realsalary, float bonus, string time)
        : base(staffId, fullName, email, phone, role, salary, workingDay, realsalary)
    {
        Bonus = bonus;
        Time = time;
    }
    public override long SumSalary(long profit = 0)
    {
        var salary = base.SumSalary();
        RealSalary = (long)(salary + (salary * 0.15 + Bonus * profit));
        return RealSalary;
    }
    public override string ToString() => GetType().Name;
}
class FullName
{
    public string FirstName { get; set; }
    public string MidName { get; set; }
    public string LastName { get; set; }
    public FullName(string fullName)
    {
        SetFullName(fullName);
    }

    private void SetFullName(string fullName)
    {
        var data = fullName.Split(' ');
        FirstName = data[0];
        LastName = data[data.Length - 1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.TrimEnd();
    }
    public override string ToString() => $"{FirstName} {MidName} {LastName}";
}

