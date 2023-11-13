using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP;
#region Bai 1
/*
abstract class StaffBase
{
    protected int amount = 1000;
    protected string _id;
    public string Id
    {
        get => _id;
        set
        {
            if ((value == null))
            {
                _id = "EMP" + amount++;
            }
            else
            {
                _id = value;
            }
        }
    }
    public FullName fullName { get; set; }
    public int Phone { get; set; }
    public long Salary { get; set; }
    public int WorkingDay { get; set; }
    public long RealSalary { get; set; }
    public abstract string CheckIn(string time);
    public abstract string CheckOut(string time);
    public abstract string DoWork(string work);
    public abstract long SumRealSalary(long profit = 0);
}

class Staff : StaffBase
{
    public Staff()
    {
        Id = "EMP" + amount++;
    }
    public Staff(string id)
    {
        Id = id;
    }
    public Staff(string id, string name, int phone, long salary, int workingDay) : this(id)
    {
        fullName = new FullName(name);
        Phone = phone;
        Salary = salary;
        WorkingDay = workingDay;
    }

    public override string CheckIn(string time)
    {
        return $"Nhan vien {fullName} checkin luc {time}";
    }

    public override string CheckOut(string time)
    {
        return $"Nhan vien {fullName} checkout luc {time}";
    }

    public override string DoWork(string work)
    {
        return $"Nhan vien {fullName} dang lam {work}";
    }

    public override long SumRealSalary(long profit = 0)
    {
        float bonus = Salary * 0.2f;
        RealSalary = (long)((WorkingDay >= 22) ? Salary * WorkingDay / 22 + bonus : Salary * WorkingDay / 22);
        return RealSalary;
    }
}

class Manager : Staff
{
    public float BonusCoe { get; set; }
    public string Role { get; set; }
    public Manager()
    {
        Id = "EMP" + amount++;
    }
    public Manager(string id, string name, int phone, long salary, int workingDay, float bonusCoe, string role) : base(id, name, phone, salary, workingDay)
    {
        BonusCoe = bonusCoe;
        Role = role;
    }

    public override string CheckIn(string time)
    {
        return $"Nhan vien {fullName} checkin luc {time}";
    }

    public override string CheckOut(string time)
    {
        return $"Nhan vien {fullName} checkout luc {time}";
    }

    public override string DoWork(string work)
    {
        return $"Nhan vien {fullName} dang lam {work}";
    }

    public override long SumRealSalary(long profit = 0)
    {
        long baseSalary = base.SumRealSalary();
        RealSalary = (long)(baseSalary + baseSalary * BonusCoe);
        return RealSalary;
    }
}
class Director : Staff
{
    public DateTime Time { get; set; }
    public string Role { get; set; }
    public float Bonus { get; set; }
    public Director()
    {
        Id = "EMP" + amount++;
    }
    public Director(string id, string name, int phone, long salary, int workingDay, float bonus, DateTime time, string role) : base(id, name, phone, salary, workingDay)
    {
        Time = time;
        Bonus = bonus;
        Role = role;

    }

    public override string CheckIn(string time)
    {
        return $"Nhan vien {fullName} checkin luc {time}";
    }

    public override string CheckOut(string time)
    {
        return $"Nhan vien {fullName} checkout luc {time}";
    }

    public override string DoWork(string work)
    {
        return $"Nhan vien {fullName} dang lam {work}";
    }

    public override long SumRealSalary(long profit = 0)
    {
        long baseSalary = base.SumRealSalary();
        RealSalary = (long)(baseSalary + (baseSalary * 0.15f + Bonus * profit));
        return RealSalary;
    }
}
*/
#endregion
#region Bai 2

abstract class BankAccount
{
    private static int autoId = 1000;
    public string BankId { get; set; }
    public string Owner { get; set; }
    public string BankName { get; set; }
    public DateTime Time { get; set; }
    public long Monney { get; set; }
    public float InterestRate { get; set; }
    public long Interest { get; set; } // tiền lãi

    // phương thức kiểm tra số dư
    public abstract void CheckMonney();
    // phương thức rút tiền
    public abstract void TakeMonney(long monney, string bankName);
    // phương thức nạp tiền
    public abstract void AddMonney(long monney, string bankName);
    // chuyển tiền
    public abstract void SendMonney(BankAccount orther, long monney, string bankName);
    // thanh toán hóa đơn, dịch vụ
    public abstract long Pay(BankAccount target, long amount, string bankName);
    // tính tiền lãi cuối kỳ
    public abstract long CalculateInterest();
    public BankAccount() { }

    public BankAccount(string accNum)
    {
        if (accNum == null)
        {
            BankId = $"002100043{autoId++}";
        }
        else
        {
            BankId = accNum;
        }
    }
    public BankAccount(string accNum, string owner, string bankName, DateTime time, long monney, float interestRate) : this(accNum)
    {
        Owner = owner;
        BankName = bankName;
        Time = time;
        Monney = monney;
        InterestRate = interestRate;
        Interest = 0;
    }
   
}
class PaymentAccount : BankAccount
{
    public long DailyPaymentLimit { get; set; } // Hạn mức thanh toán trong ngày
    public long TotalPayment { get; set; }
    public PaymentAccount()
    {
        
    }
    public PaymentAccount(string bankAcc) : base(bankAcc)
    {

    }
    public PaymentAccount(string accNum, string owner, string bankName, DateTime time, long monney,long dailyPayment) : base(accNum, owner, bankName, time, monney , 1)
    {
        DailyPaymentLimit = dailyPayment;
        Interest = 0;
        TotalPayment = 0;
    }
    public override void AddMonney(long monney, string bankName)
    {
        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney > 0)
            {
                Monney += monney;
                Console.WriteLine("Nap tien thanh cong !");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }
        else
        {
            if (monney > 0 || monney < Monney - 35000)
            {
                Monney += monney;
                Monney -= 35000;
                Console.WriteLine("Nap tien thanh cong !");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }
    }
    public override void CheckMonney()
    {
        Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
        Console.WriteLine($"Số tài khoản: {BankId}");
        Console.WriteLine($"Chủ tài khoản: {Owner}");
        Console.WriteLine($"Số dư: {Monney}đ");
        Console.WriteLine($"Loai tai khoan: Thanh Toan)");
        var formatter = "HH:mm:ss dd/MM/yyyy";
        Console.WriteLine($"Thời gian: {DateTime.Now.ToString(formatter)}");
        Console.WriteLine("=============================================");
    }
    public override void SendMonney(BankAccount orther, long monney, string bankName)
    {
        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney < 0 || monney > Monney - 51000)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else if (TotalPayment + monney > DailyPaymentLimit)
            {
                Console.WriteLine("Vuot qua han muc trong ngay !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    orther.Monney += monney;
                    Console.WriteLine("Chuyen tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Chuyen tien that bai !");
                }
                Monney -= 1100;
                TotalPayment += monney;
            }
        }
        else
        {
            if (monney < 0 || monney > Monney - 53300)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else if (TotalPayment + monney > DailyPaymentLimit)
            {
                Console.WriteLine("Vuot qua han muc trong ngay !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    orther.Monney += monney;
                    Console.WriteLine("Chuyen tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Chuyen tien that bai !");
                }
                Monney -= 3300;
                TotalPayment += monney;
            }
        }
    }

    public override void TakeMonney(long monney, string bankName)
    {
        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney < 0 || monney > Monney - 51000)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else if (TotalPayment + monney > DailyPaymentLimit)
            {
                Console.WriteLine("Vuot qua han muc trong ngay !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    Console.WriteLine("Rut tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Rut tien that bai !");
                }
                Monney -= 1100;
                TotalPayment += monney;
            }
        }
        else
        {
            if (monney < 0 || monney > Monney - 51000)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else if (TotalPayment + monney > DailyPaymentLimit)
            {
                Console.WriteLine("Vuot qua han muc trong ngay !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    Console.WriteLine("Rut tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Rut tien that bai !");
                }
                Monney -= 3300;
                TotalPayment += monney;
            }
        }
    }

    public override long Pay(BankAccount target, long amount, string bankName)
    {
        throw new NotImplementedException();
    }

    public override long CalculateInterest()
    {
        Interest = (long)(Monney * InterestRate);
        return Interest;
    }
}
class SavingAccount : BankAccount
{
    public int SendingTerm { get; set; } // kỳ hạn gửi
    public DateTime DispatchDate { get; set; } // ngày gửi 
    public DateTime ExpirationDate { get; set; } // ngày hết hạn
    public SavingAccount()
    {

    }
    public SavingAccount(string accNum, string owner, string bankName, DateTime time, long monney, DateTime dispatchDate, DateTime expirationDate, float interestRate , int sendingTerm) 
        : base(accNum, owner, bankName, time, monney,0)
    {
        SendingTerm = sendingTerm;
        DispatchDate = dispatchDate;
        ExpirationDate = expirationDate;
        SetInterestRate();
        Interest = 0;
    }

    private void SetInterestRate()
    {
        switch (SendingTerm)
        {
            case -1:
                InterestRate = 3.0f;
                break;
            case 1:
                InterestRate = 3.5f;
                break;
            case 3:
                InterestRate = 4.5f;
                break;
            case 6:
                InterestRate = 5;
                break;
            case 12:
                InterestRate = 5.5f;
                break;
            case 18:
                InterestRate = 6;
                break;
            case 24:
                InterestRate = 6.5f;
                break;
            default:
                InterestRate = 0;
                break;
        }
    }

    public override void CheckMonney()
    {
        Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
        Console.WriteLine($"Số tài khoản: {BankId}");
        Console.WriteLine($"Chủ tài khoản: {Owner}");
        Console.WriteLine($"Số dư: {Monney}đ");
        Console.WriteLine($"Loai tai khoan: Tiet Kiem)");
        var formatter = "HH:mm:ss dd/MM/yyyy";
        Console.WriteLine($"Thời gian: {DateTime.Now.ToString(formatter)}");
        Console.WriteLine("=============================================");
    }
    public override void AddMonney(long monney, string bankName)
    {
        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney > 0)
            {
                Monney += monney;
                Console.WriteLine("Nap tien thanh cong !");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }
        else
        {
            if (monney > 0 || monney < Monney - 35000)
            {
                Monney += monney;
                Monney -= 35000;
                Console.WriteLine("Nap tien thanh cong !");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }
    }
    public override void SendMonney(BankAccount orther, long monney, string bankName)
    {

        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney < 0 || monney > Monney - 51000 - monney * 0.3)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    orther.Monney += monney;
                    Console.WriteLine("Chuyen tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Chuyen tien that bai !");
                }
                Monney -= 1100;
                Monney -= (long) (monney * 0.3);
            }
        }
        else
        {
            if (monney < 0 || monney > Monney - 53300 - monney * 0.3)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    orther.Monney += monney;
                    Console.WriteLine("Chuyen tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Chuyen tien that bai !");
                }
                Monney -= 3300;
                Monney -= (long)(monney * 0.3);
            }
        }
    }

    public override void TakeMonney(long monney,string bankName)
    {
        if (BankName.CompareTo(bankName) == 0)
        {
            if (monney < 0 || monney > Monney - 51000 - monney * 0.3)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    Console.WriteLine("Rut tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Rut tien that bai !");
                }
                Monney -= 1100;
                Monney -= (long)(monney * 0.3);
            }
        }
        else
        {
            if (monney < 0 || monney > Monney - 51000 - monney * 0.3)
            {
                Console.WriteLine("Chuyen tien that bai !");
            }
            else
            {
                if (monney > 0 && monney < Monney - 50000)
                {
                    Monney -= monney;
                    Console.WriteLine("Rut tien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Rut tien that bai !");
                }
                Monney -= 3300;
                Monney -= (long)(monney * 0.3);
            }
        }
    }

    public override long Pay(BankAccount target, long amount, string bankName)
    {
        throw new NotImplementedException();
    }

    public override long CalculateInterest()
    {
        Interest = (long)(Monney * InterestRate);
        return Interest;
    }
}
#endregion