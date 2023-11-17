using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6;
#region Bai 1
/*
class Staff
{
    private static int _amount = 1000;

    public string ID { get; set; }
    public string FullName { get; set; }
    public int Phone { get; set; }
    public long Salary { get; set; }
    public int WorkingDay { get; set; }
    public long RealSalary { get; set; } 

    public Staff()
    {
        ID = "EMP" + _amount++;
    }

    public Staff(string id, string name, int phone, long salary, int workingDay = 0)
    {
        ID = string.IsNullOrEmpty(id) ? "EMP" + _amount++ : id;
        FullName = name;
        Phone = phone;
        Salary = salary;
        WorkingDay = workingDay;
    }

    public string CheckIn(string timne)
    {
        return $"Nhan vien {FullName} checkin luc: {timne}";

    }

    public string CheckOut(string timne)
    {
        return $"Nhan vien {FullName} checkout luc: {timne}";
    }

    public string DoWork(string work)
    {
        return $"Nhan vien {FullName} dang lam : {work}";
    }

    public virtual long SumSalary(long profit = 0)
    {
        var salary = Salary * WorkingDay / 22;
        var bonus = WorkingDay >= 22 ? Salary * 0.2 : 0;
        RealSalary = (long)(salary + bonus);
        return RealSalary;
    }
}
class Manager : Staff
{
    public string Role { get; set; }
    public double Bonus { get; set; }
    public Manager(string id, string name, int phone, long salary, int workingDay, string role, double bonus) : base(id, name, phone, salary, workingDay)
    {
        Role = role;
        Bonus = bonus;
    }

    public override long SumSalary(long profit = 0)
    {
        var salary = base.SumSalary();
        RealSalary = (long)(salary + Bonus * salary);
        return RealSalary;
    }
}
class Director : Staff
{
    public string Role { get; set; }
    public string Time { get; set; }
    public double Bonus { get; set; }

    public Director(string id, string name, int phone, long salary, int workingDay, string role, string time, double bonus) : base(id, name, phone, salary, workingDay)
    {
        Role = role;
        Time = time;
        Bonus = bonus;
    }

    public override long SumSalary(long profit = 0)
    {
        var salary = base.SumSalary();
        RealSalary = (long)(salary + (salary * 0.15 + Bonus * profit));
        return RealSalary;
    }
}
class StaffUtil
{
    internal static Staff InforCreate()
    {
        Console.WriteLine("1) Tao nhan vien");
        Console.WriteLine("2) tao quan ly");
        Console.WriteLine("3) tao giam doc");
        Console.Write("Nhap lua chon cua ban: ");
        int x = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            return CreateStaff();
        }
        else if (x == 2)
        {
            return CreateManager();
        }
        else if (x == 3)
        {
            return CreateDirector();
        }
        return null;
    }

    private static Staff CreateManager()
    {
        var staff = CreateStaff();
        Console.WriteLine("Nhap chuc vu cua ban: ");
        string role = Console.ReadLine();
        Console.WriteLine("Nhap he so thuong : ");
        double bonus = double.Parse(Console.ReadLine());
        return new Manager(staff.ID, staff.FullName, staff.Phone, staff.Salary, staff.WorkingDay, role, bonus);
    }

    private static Staff CreateDirector()
    {
        var staff = CreateStaff();
        Console.Write("Nhap chuc vu cua ban: ");
        string role = Console.ReadLine();
        Console.Write("Nhap he so thuong : ");
        double bonus = double.Parse(Console.ReadLine());
        Console.Write("Nhap thoi gian vao cty: ");
        string time = Console.ReadLine();
        return new Director(staff.ID, staff.FullName, staff.Phone, staff.Salary, staff.WorkingDay, role,time, bonus);
    }

    private static Staff CreateStaff()
    {
        Staff staff = new Staff();
        Console.Write("Nhap ten cua ban: ");
        staff.FullName = Console.ReadLine();
        Console.Write("Nhap so dien thoai cua ban: ");
        staff.Phone = int.Parse(Console.ReadLine());
        Console.Write("Nhap muc luong: ");
        staff.Salary = long.Parse(Console.ReadLine());
        Console.Write("Nhap so ngay lam viec: ");
        staff.WorkingDay= int.Parse(Console.ReadLine());
        return staff;
    }

    internal static void ShowStaff(Staff[] staffs)
    {
        var titleId = "MNV";
        var titleFullName = "Ho va Ten";
        var titlePhone = "SDT";
        var titleSalary = "Luong co ban";
        var titleWorkingDay = "Ngay lam viec";
        var titleSumSalary = "Tong luong";
        Console.WriteLine($"{titleId,-15}{titleFullName,-15}{titlePhone,-15}{titleSalary,-15}{titleWorkingDay,-15}{titleSumSalary,-15}");
        foreach (var item in staffs)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.ID,-15}{item.FullName,-15}{item.Phone,-15}{item.Salary,-15}{item.WorkingDay,-15}{item.RealSalary,-15}");
            }
        }
    }

    internal static void RealWage(Staff[] staffs)
    {
        Console.Write("Nhap vao doanh thu: ");
        long profit = long.Parse(Console.ReadLine());
        foreach (var item in staffs)
        {
            if (item != null)
            {
                item.SumSalary(profit);
            }
        }
    }

    internal static void SortStaffByRealSalary(Staff[] staffs, int size)
    {
        int Compare(Staff s1 , Staff s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.RealSalary - s2.RealSalary != 0)
            {
                if (s2.RealSalary - s1.RealSalary > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
        for (int i = 0; i < staffs.Length; i++)
        {
            if (staffs != null)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Compare(staffs[j-1], staffs[j]) > 0)
                    {
                        Swap(ref staffs[j - 1], ref staffs[j]);
                    }
                }
            }
        }
    }

    private static void Swap(ref Staff staff1, ref Staff staff2)
    {
        var tmp = staff1;
        staff1 = staff2;
        staff2 = tmp;
    }

    internal static void SortStaffByWorkingDay(Staff[] staffs, int size)
    {
        int Compare(Staff s1, Staff s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.WorkingDay - s2.WorkingDay != 0)
            {
                if (s2.WorkingDay - s1.WorkingDay > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
        for (int i = 0; i < staffs.Length; i++)
        {
            if (staffs != null)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Compare(staffs[j - 1], staffs[j]) > 0)
                    {
                        Swap(ref staffs[j - 1], ref staffs[j]);
                    }
                }
            }
        }
    }

    internal static void UpdateSalary(Staff[] staffs, int index)
    {
        Console.WriteLine("Nhap ma nhan vien can tang luong: ");
        string id = Console.ReadLine();
        var staff = CheckId(staffs, id);
        if (staff != null)
        {
            Console.WriteLine("Nhap so luong can cap nhat: ");
            long salary = long.Parse(Console.ReadLine());
            staff.Salary = salary;
        }
        else
        {
            Console.WriteLine("Khong tim thay ma nhan vien !");
        }
    }

    private static Staff CheckId(Staff[] staffs, string id)
    {
        foreach (var item in staffs)
        {
            if (item != null && item.ID == id)
            {
                return item;
            }
        }
        return null;
    }

    internal static void SeachStaff(Staff[] staffs, int index)
    {
        Console.WriteLine("Nhap ma nhan vien: ");
        string id = Console.ReadLine() ;    
        var seachStaff = new Staff[index];
        int size = 0;
        foreach (var item in staffs)
        {
            if (item != null && item.ID == id)
            {
                seachStaff[size++] = item;
            }
        }
        if (size > 0)
        {
            ShowStaff(seachStaff);
        }
        else
        {
            Console.WriteLine("Khong tim thay nhan vien !");
        }
    }

    internal static void DeleteStaff(Staff[] staffs, ref int index)
    {
        Console.WriteLine("Nhap ma nhan vien : ");
        string id = Console.ReadLine();
        var staff = CheckId(staffs, id);
        bool check()
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != null && staffs[i] == staff)
                {
                    staffs[i] = null;
                    for (int j = i; j < staffs.Length; j++)
                    {
                        staffs[j] = staffs[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }
        if (check())
        {
            Console.WriteLine("Da xoa nhan vien !");
            index--;
        }
        else
        {
            Console.WriteLine("Khong tim thay nhan vien !");
        }
    }
}
class Run
{
    static void Main(string[] args)
    {
        Staff[] staffs = new Staff[100];
        int index = 0;
        int x;
        Console.OutputEncoding = Encoding.UTF8;
        do
        {
            Console.WriteLine("1) Thêm mới một nhân viên vào danh sách nhân viên.\r\n" +
           "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
           "3) Tính lương của các nhân viên trong danh sách.\r\n" +
           "4) Sắp xếp danh sách nhân viên theo mức lương thực lĩnh giảm dần.\r\n" +
           "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng giảm dần.\r\n" +
           "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
           "7) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
           "8) Xóa bỏ nhân viên có mã cho trước.\r\n" +
           "9) Thoát chương trình.");
            Console.Write("Moi ban lua chon: ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    var staff = StaffUtil.InforCreate();
                    if (staff != null)
                    {
                        staffs[index++] = staff;
                        Console.WriteLine("Tao thanh cong !");
                    }
                    else
                    {
                        Console.WriteLine("Sai lua chon !");
                    }
                    break;
                case 2:
                    if (index > 0)
                    {
                        StaffUtil.ShowStaff(staffs);
                    }
                    else
                    {
                        Console.WriteLine("Trong");
                    }
                    break;
                case 3:
                    if (index > 0)
                    {
                        StaffUtil.RealWage(staffs);
                        Console.WriteLine("Da tinh luong toan bo nhan vien !");
                    }
                    else
                    {
                        Console.WriteLine("Trong");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        StaffUtil.SortStaffByRealSalary(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        StaffUtil.SortStaffByWorkingDay(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                    }
                    break;
                case 6:
                    if (index > 0)
                    {
                        StaffUtil.SeachStaff(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                    }
                    break;
                case 7:
                    if (index > 0)
                    {
                        StaffUtil.UpdateSalary(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                    }
                    break;
                case 8:
                    if (index > 0)
                    {
                        StaffUtil.DeleteStaff(staffs,ref index);
                    }
                    else
                    {
                        Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                    }
                    break;
                case 9:
                    Console.WriteLine("Tam biet !");
                    break;
                default:
                    Console.WriteLine("Sai lua chon! ");
                    break;
            }
        } while (x != 9);

    }
}*/
#endregion
#region Bai 2

class BankAccount
{
    static BankAccount()
    {
        var rd = new Random();
        amount = rd.Next(1000000000, 2000000000);
    }

    private static long amount;
    private int _pin;

    public long BankId { get; set; }
    public string Owner { get; set; }
    public long Monney { get; set; }
    public string BankName { get; set; }
    public DateTime Time { get; set; }
    public long TranferOfDay { get; set; } // số tiền chuyển trong 1 ngày
    public long TotalDailyTransfer { get; set; }

    public int Pin
    {
        get => _pin;
        set
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (value.ToString().Length != 6)
            {
                Console.WriteLine("Mã pin phải là 6 chữ số. Mã pin được đổi về 000000");
                _pin = 000000;
            }
            else
            {
                _pin = value;
            }
        }
    }

    public BankAccount()
    {
        BankId = amount++;
    }

    public BankAccount(long id, string owner, long monney, string bankName, DateTime time, int pin)
    {
        BankId = id > 0 ? id : amount;
        Owner = owner;
        BankName = bankName;
        Monney = monney;
        Time = time;
        Pin = pin;
    }

    public virtual void CheckMonney()
    {
        Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
        Console.WriteLine($"Số tài khoản: {BankId}");
        Console.WriteLine($"Chủ tài khoản: {Owner}");
        Console.WriteLine($"Số dư: {Monney}đ");
        var formatter = "HH:mm:ss dd/MM/yyyy";
        Console.WriteLine($"Thời gian: {DateTime.Now.ToString(formatter)}");
        Console.WriteLine("=============================================");
    }

    public virtual void AddMonney(long monney)
    {
        if (monney > 0)
        {
            Monney += monney;
            TranferOfDay += monney;
            Console.WriteLine("Nạp tiền thành công!");
        }
        else
        {
            Console.WriteLine("Nạp tiền không thành công!");
        }
    }

    public virtual void TakeMonney(string bankName, long monney)
    {
        if (monney < 0 || monney > Monney - 50000 || string.IsNullOrEmpty(bankName))
        {
            Console.WriteLine("Rút tiền thất bại!");
        }
        else
        {
            Monney -= monney;
            TranferOfDay += monney;
            Console.WriteLine("Rút tiền thành công");
        }
    }

    public virtual void SendMonney(BankAccount other, long monney)
    {
        if (monney < 0 || monney > Monney - 70000)
        {
            Console.WriteLine("Chuyển tiền thất bại!");
        }
        else
        {
            Monney -= monney;
            other.Monney += monney;
            TranferOfDay += monney;
            Console.WriteLine("Chuyển tiền thành công!");
        }
    }
}

class SavingAccount : BankAccount
{

    public DateTime SendingTerm { get; set; } // kỳ hạn gửi
    public float InterestRate { get; set; } // lãi xuất
    public long Interest { get; set; } // tiền lãi
    const int Max_Tranfer = 500000000;

    public SavingAccount()
    {

    }

    public SavingAccount(long id, string owner, long monney, string bankName, DateTime time, int pin, DateTime sendingTerm, float interestRate, long interest)
        : base(id, owner, monney, bankName, time, pin)
    {
        SendingTerm = sendingTerm;
        InterestRate = interestRate;
        Interest = interest;
    }

    public override void TakeMonney(string bankName, long monney)
    {
        if (monney > 5000000)
        {
            Console.WriteLine("Số tiền rút vợt quá mức quy định 5tr/lần");
        }
        else if (monney > Monney - 61000)
        {
            Console.WriteLine("Số tiền rút vượt quá số dư của bạn !");
        }
        else
        {
            base.TakeMonney(bankName, monney);
            Monney -= 11000;
        }
    }

    public override void SendMonney(BankAccount other, long monney)
    {
        if (TotalDailyTransfer + monney > Max_Tranfer)
        {
            Console.WriteLine("Tài khoản của bạn đã vượt quá 500tr/1 ngày!");
            Console.WriteLine($"Bạn chỉ có thể chuyển : {Max_Tranfer - TotalDailyTransfer}");
        }
        else
        {
            base.SendMonney(other, monney);
            TotalDailyTransfer += monney;
        }
    }
}

class PayMentAccount : BankAccount
{

    public long DailyPaymentLimit { get; set; } // Hạn mức thanh toán trong ngày
    public int BankPaymentFees { get; set; } // phí thanh toán nội ngân hàng
    public int InterbankPaymentFees { get; set; } // phí thanh toán liên ngân hàng

    public PayMentAccount()
    {

    }

    public PayMentAccount(long id, string owner, long monney, string bankName, DateTime time, int pin, long dailyPaymentLimit, int bankPaymentFees, int interbankPaymentFees)
        : base(id, owner, monney, bankName, time, pin)
    {
        DailyPaymentLimit = dailyPaymentLimit;
        BankPaymentFees = bankPaymentFees;
        InterbankPaymentFees = interbankPaymentFees;
    }
    public override void CheckMonney()
    {
        Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
        Console.WriteLine($"Số tài khoản: {BankId}");
        Console.WriteLine($"Chủ tài khoản: {Owner}");
        Console.WriteLine($"Tai khoan thanh toan");
        Console.WriteLine($"Số dư: {Monney}đ");
        var formatter = "HH:mm:ss dd/MM/yyyy";
        Console.WriteLine($"Thời gian: {DateTime.Now.ToString(formatter)}");
        Console.WriteLine("=============================================");
    }
    public override void TakeMonney(string bankName, long monney)
    {
        var fee = (long)(1.0 / 100 * monney); // phí 1%
        var inbank = InterbankPaymentFees;
        if (monney > 5000000)
        {
            Console.WriteLine("Số tiền rút vợt quá mức quy định 5tr/lần");
            return;
        }
        if (bankName.CompareTo(BankName) == 0)
        {
            inbank = BankPaymentFees;
        }
        if (monney > Monney - 50000 - fee - inbank)
        {
            Console.WriteLine("số tiền vượt quá số dư !");
            return;
        }
        else
        {
            base.TakeMonney(bankName, monney);
            Monney -= inbank;
            Monney -= fee;
        }
    }

    public override void SendMonney(BankAccount other, long monney)
    {
        if (TotalDailyTransfer + monney > DailyPaymentLimit)
        {
            Console.WriteLine("Bạn đã thanh toán vượt quá hạn mức trong ngày!");
            Console.WriteLine($"Bạn chỉ có thể chuyển : {DailyPaymentLimit - TotalDailyTransfer}");
        }
        else
        {
            base.SendMonney(other, Monney);
            TotalDailyTransfer += monney;
        }
    }
}

class BankUtil
{
    internal static BankAccount CreateInfor()
    {
        Console.WriteLine("1) tài khoản thường");
        Console.WriteLine("2) tài khoản tiết kiệm");
        Console.WriteLine("3) tài khoản thanh toán");
        Console.Write("Nhập thẻ bạn muốn tạo: ");
        int x = int.Parse(Console.ReadLine()!);
        if (x == 1)
        {
            return CreateBankAcc();
        }
        else if (x == 2)
        {
            return CreateSavingAcc();
        }
        else if (x == 3)
        {
            return CreatePayAcc();
        }
        return null!;
    }

    private static BankAccount CreatePayAcc()
    {
        var acc = CreateBankAcc();
        Console.Write("Nhập hạn mức thanh toán: ");
        long dailyPaymentLimit = long.Parse(Console.ReadLine()!);
        Console.Write("Nhập phí thanh toán nội ngân hàng: ");
        int bankPaymentFees = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập phí thanh toán liên ngân hàng: ");
        int interbankPaymentFees = int.Parse(Console.ReadLine()!);
        return new PayMentAccount(acc.BankId, acc.Owner, acc.Monney, acc.BankName, acc.Time, acc.Pin, dailyPaymentLimit, bankPaymentFees, interbankPaymentFees);
    }

    private static BankAccount CreateSavingAcc()
    {
        var acc = CreateBankAcc();
        Console.Write("Nhập kỳ hạn gửi: ");
        var date = Console.ReadLine();
        DateTime sendingTerm = DateTime.ParseExact(date!, "MM/yyyy", null);
        Console.Write("Nhập lãi xuất: ");
        float interestRate = float.Parse(Console.ReadLine()!);
        Console.Write("Nhập tiền lãi: ");
        long interest = long.Parse(Console.ReadLine()!);
        return new SavingAccount(acc.BankId, acc.Owner, acc.Monney, acc.BankName, acc.Time, acc.Pin, sendingTerm, interestRate, interest);
    }

    private static BankAccount CreateBankAcc()
    {
        BankAccount bankAccount = new BankAccount();
        Console.Write("Nhập tên chủ tài khoản: ");
        bankAccount.Owner = Console.ReadLine()!;
        Console.Write("Nhập số dư: ");
        bankAccount.Monney = long.Parse(Console.ReadLine()!);
        Console.Write("Nhập tên ngân hàng: ");
        bankAccount.BankName = Console.ReadLine()!;
        Console.Write("Nhập thời gian sử dụng (tháng/năm): ");
        var date = Console.ReadLine();
        bankAccount.Time = DateTime.ParseExact(date!, "MM/yyyy", null);
        Console.Write("Nhập mã Pin: ");
        bankAccount.Pin = int.Parse(Console.ReadLine()!);
        return bankAccount;
    }

    internal static void ShowMonney(BankAccount[] bankAccounts)
    {
        Console.Write("Nhập vào số tài khoản cần kiểm tra: ");
        long id = long.Parse(Console.ReadLine()!);
        var acc = GetAcc(bankAccounts, id);
        if (acc != null)
        {
            acc.CheckMonney();
        }
        else
        {
            Console.WriteLine("Không tìm thấy tài khoản!");
        }
    }

    private static BankAccount GetAcc(BankAccount[] bankAccounts, long id)
    {
        foreach (var item in bankAccounts)
        {
            if (item != null && item.BankId == id)
            {
                return item;
            }
        }
        return null!;
    }

    internal static void InputMonney(BankAccount[] bankAccounts)
    {
        Console.Write("Nhập vào số tài khoản cần nạp tiền: ");
        long id = long.Parse(Console.ReadLine()!);
        var acc = GetAcc(bankAccounts, id);
        if (acc != null)
        {
            Console.Write("Nhập số tiền cần nạp: ");
            long monney = long.Parse(Console.ReadLine()!);
            acc.AddMonney(monney);
        }
        else
        {
            Console.WriteLine("Không tìm thấy tài khoản!");
        }
    }

    internal static void WithdrawMoney(BankAccount[] bankAccounts)
    {
        Console.Write("Nhập vào số tài khoản cần rút tiền: ");
        long id = long.Parse(Console.ReadLine()!);
        var acc = GetAcc(bankAccounts, id);
        if (acc != null)
        {
            Console.Write("Nhập vào mã pin của bạn: ");
            int pin = int.Parse(Console.ReadLine()!);
            if (acc.Pin == pin)
            {
                Console.Write("Nhập ngân tên ngân hàng rút: ");
                string bankName = Console.ReadLine()!;
                Console.Write("Nhập số tiền cần rút: ");
                long monney = long.Parse(Console.ReadLine()!);
                acc.TakeMonney(bankName, monney);
            }
            else
            {
                Console.WriteLine("Sai mã pin !");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy tài khoản!");
        }
    }

    internal static void TranferMonney(BankAccount[] bankAccounts)
    {
        Console.Write("Nhập vào số tài khoản của bạn: ");
        long id = long.Parse(Console.ReadLine()!);
        var acc = GetAcc(bankAccounts, id);
        if (acc != null)
        {
            Console.Write("Nhập vào mã pin của bạn: ");
            int pin = int.Parse(Console.ReadLine()!);
            if (acc.Pin == pin)
            {
                Console.Write("Nhập vào số tài khoản thụ thưởng!");
                long id2 = long.Parse(Console.ReadLine()!);
                var acc2 = GetAcc(bankAccounts, id2);
                if (acc2 != null)
                {
                    Console.Write("Nhập vào số tiền cần chuyển: ");
                    long monney = long.Parse(Console.ReadLine()!);
                    acc.SendMonney(acc2, monney);
                }
                else
                {
                    Console.WriteLine("Số tài khoản thụ hưởng không chính xác !");
                }
            }
            else
            {
                Console.WriteLine("Sai mã pin !");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy tài khoản!");
        }
    }

    internal static void ShowBankAcc(BankAccount[] bankAccounts)
    {
        var titleId = "STK";
        var titleOwner = "Owner";
        var titleMonney = "Số dư";
        var titleBankName = "BankName";
        var titleDate = "Time";
        var titlePin = "Pin";
        Console.WriteLine($"{titleId,-15}{titleOwner,-15}{titleMonney,-15}{titleBankName,-15}{titleDate,-15}{titlePin,-15}");
        foreach (var item in bankAccounts)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.BankId,-15}{item.Owner,-15}{item.Monney,-15}{item.BankName,-15}{item.Time,-15}{item.Pin,-15}");
            }
        }
    }

    internal static void SortAccByMonney(BankAccount[] bankAccounts, int index)
    {
        int Compare(BankAccount s1, BankAccount s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.Monney - s2.Monney != 0)
            {
                if (s2.Monney - s1.Monney > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
        for (int i = 0; i < bankAccounts.Length; i++)
        {
            if (bankAccounts[i] != null)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(bankAccounts[j - 1], bankAccounts[j]) > 0)
                    {
                        Swap(ref bankAccounts[j - 1], ref bankAccounts[j]);
                    }
                }
            }
        }
    }

    private static void Swap(ref BankAccount bankAccount1, ref BankAccount bankAccount2)
    {
        var tmp = bankAccount1;
        bankAccount1 = bankAccount2;
        bankAccount2 = tmp;
    }

    internal static void SeachAcc(BankAccount[] bankAccounts, int index)
    {
        static string Cut(long id)
        {
            var idToString = id.ToString();
            var StringToChar = idToString.ToCharArray();
            var result = "";
            for (int i = StringToChar.Length - 1; i > StringToChar.Length - 5; i--)
            {
                result += StringToChar[i];
            }
            return new string(result.Reverse().ToArray()); ;
        }
        Console.Write("Nhập vào 4 số cuối của stk cần tìm kiếm: ");
        string id = Console.ReadLine()!;
        var seachAcc = new BankAccount[index];
        int size = 0;
        foreach (var item in bankAccounts)
        {
            if (item != null && Cut(item.BankId).CompareTo(id) == 0)
            {
                seachAcc[size++] = item;
            }
        }
        if (size > 0)
        {
            ShowBankAcc(seachAcc);
        }
        else { Console.WriteLine("Không tìm thấy tài khoản nào"); }
    }
}

class Run
{
  /*  static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        BankAccount[] bankAccounts = new BankAccount[100];
        int index = 0;
        int x;
        do
        {
            Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
            "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
            "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
            "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
            "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 70k VNđ.\r\n" +
            "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n" +
            "7) Sắp xếp danh sách tài khoản theo số dư giảm dần.\r\n" +
            "8) Tìm tài khoản theo 4 số cuối của số tài khoản.\r\n" +
            "9) Kết thúc chương trình.");
            Console.Write("Nhập lựa chọn của bạn: ");
            x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    var staff = BankUtil.CreateInfor();
                    if (staff != null)
                    {
                        bankAccounts[index++] = staff;
                        Console.WriteLine($"Tạo tài khoản thành công. Số tài khoản là: {bankAccounts[index - 1].BankId} ");
                    }
                    else
                    {
                        Console.WriteLine("Tạo thất bại!");
                    }
                    break;
                case 2:
                    if (index > 0)
                    {
                        BankUtil.ShowMonney(bankAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 3:
                    if (index > 0)
                    {
                        BankUtil.InputMonney(bankAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        BankUtil.WithdrawMoney(bankAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        BankUtil.TranferMonney(bankAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 6:
                    if (index > 0)
                    {
                        BankUtil.ShowBankAcc(bankAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 7:
                    if (index > 0)
                    {
                        BankUtil.SortAccByMonney(bankAccounts, index);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 8:
                    if (index > 0)
                    {
                        BankUtil.SeachAcc(bankAccounts, index);
                    }
                    else
                    {
                        Console.WriteLine("Trống !");
                    }
                    break;
                case 9:
                    Console.WriteLine("Tạm biệt !");
                    break;
                default:
                    Console.WriteLine("Sai lựa chọn!");
                    break;
            }
        } while (x != 9);
    }*/
}

#endregion
#region Bai 3
/*
class Student
{
    private static int _amount = 1000;
    private FullName fullName = new();

    public Student()
    {
        Id = "EMP" + _amount++;
    }
    public Student(string id, string name, string addRess, float test, string major)
    {
        Id = string.IsNullOrEmpty(id) ? "EMP" + _amount++ : id;
        Name = name;
        AddRess = addRess;
        Test = test;
        Major = major;
    }
    public string Id { get; set; }
    public string AddRess { get; set; }
    public float Test { get; set; }
    public string Major { get; set; }
    public string Name
    {
        get => $"{fullName.FirstName} {fullName.MidName} {fullName.LastName}";
        set
        {
            var data = value.Split(' ');
            if (data.Length > 0)
            {
                fullName.FirstName = data[0];
                fullName.LastName = data[data.Length - 1];
                var mid = "";
                for (int i = 1; i < data.Length - 1; i++)
                {
                    mid += data[i] + " ";
                }
                fullName.MidName = mid.TrimEnd();
            }
            else
            {
                fullName.FirstName = "";
                fullName.MidName = "";
                fullName.LastName = data[0];
            }
        }
    }
    public string GetFirstName { get => fullName.FirstName; }
    public string GetMidName { get => fullName.MidName; }
    public string GetLasName { get => fullName.LastName; }
    class FullName
    {
        public FullName()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
    }
}
class GradutedStudent : Student
{
    public GradutedStudent()
    {

    }
    public GradutedStudent(string id, string name, string addRess, float test, string major, long salary, DateTime graduationYear, string graduationClassification)
        : base(id, name, addRess, test, major)
    {
        Salary = salary;
        GraduationYear = graduationYear;
        GraduationClassification = graduationClassification;
    }
    public long Salary { get; set; } // mức lương
    public DateTime GraduationYear { get; set; } // năm tốt nghiệp
    public string GraduationClassification { get; set; } // xếp loại tốt nghiệp

}
class UndergraduateStudent : Student
{
    public UndergraduateStudent()
    {

    }
    public UndergraduateStudent(string id, string name, string addRess, float test, string major, long tuitionPerCredit, int numberOfCreditsOwed, int numberOfCreditsCompleted) : base(id, name, addRess, test, major)
    {
        TuitionPerCredit = tuitionPerCredit;
        NumberOfCreditsOwed = numberOfCreditsOwed;
        NumberOfCreditsCompleted = numberOfCreditsCompleted;
    }
    public long TuitionPerCredit { get; set; } // Học phí mỗi tín chỉ
    public int NumberOfCreditsOwed { get; set; } // Số tín chỉ nợ
    public int NumberOfCreditsCompleted { get; set; } // số tín chỉ đã hoàn thành
}
class Information
{
    public Information(string city, int amount)
    {
        City = city;
        Amount = amount;
    }
    public string City { get; set; }
    public int Amount { get; set; }
}
class StudentUitl
{
    internal static Student GetInfor()
    {
        Console.WriteLine("1) Tao sinh vien");
        Console.WriteLine("2) Tao sinh vien da ra truong");
        Console.WriteLine("3) Tao sinh vien chua tot nghiep");
        Console.Write("Nhap vao loai sinh vien: ");
        int x = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            return CreateStudent();
        }
        else if (x == 2)
        {
            return CreateStudent2();
        }
        else if (x == 3)
        {
            return CreateStudent3();
        }
        return null;
    }

    private static Student CreateStudent2()
    {
        var student = CreateStudent();
        Console.Write("Nhap vao muc luong: ");
        long salary = long.Parse(Console.ReadLine());
        Console.Write("Nhap vao nam tot nghiep: ");
        var date = Console.ReadLine();
        DateTime dateTime = DateTime.ParseExact(date, "yyyy", null);
        Console.Write("Nhap vao xep loai tot nghiep: ");
        string xl = Console.ReadLine();
        return new GradutedStudent(student.Id, student.Name, student.AddRess, student.Test, student.Major, salary, dateTime, xl);
    }

    private static Student CreateStudent3()
    {
        var student = CreateStudent();
        Console.Write("Nhap vao hoc phi: ");
        long hp = long.Parse(Console.ReadLine());
        Console.Write("Nhap vao so tin chi con no: ");
        int no = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so tin chi da tich luy: ");
        int tichLuy = int.Parse(Console.ReadLine());
        return new UndergraduateStudent(student.Id, student.Name, student.AddRess, student.Test, student.Major, hp, no, tichLuy);
    }

    private static Student CreateStudent()
    {
        Student student = new Student();
        Console.Write("Nhap vao ho va ten: ");
        student.Name = Console.ReadLine();
        Console.Write("Nhap vao dia chi: ");
        student.AddRess = Console.ReadLine();
        Console.Write("Nhap vao diem tb: ");
        student.Test = float.Parse(Console.ReadLine());
        Console.Write("Nhap vao chuyen nganh: ");
        student.Major = Console.ReadLine();
        return student;
    }
    public static void ShowStudent(Student[] student)
    {
        var titleMSV = "MSV";
        var titleName = "Ho Ten";
        var titleCity = "Dia chi";
        var titleTest = "Diem TB";
        var titleMajor = "Chuyen Nganh";
        Console.WriteLine($"{titleMSV,-15}{titleName,-20}{titleCity,-15}{titleTest,-15}{titleMajor,-15}");
        foreach (var item in student)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.Id,-15}{item.Name,-20}{item.AddRess,-15}{item.Test,-15}{item.Major,-15}");
            }
        }
    }

    internal static void SortStudentByTest(Student[] students, int index)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.Test - s2.Test != 0)
            {
                if (s2.Test - s1.Test > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1], students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }
    }

    private static void Swap(ref Student student1, ref Student student2)
    {
        var tmp = student1;
        student1 = student2;
        student2 = tmp;
    }

    internal static void SortStudentByName(Student[] students, int index)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            return s1.GetLasName.CompareTo(s2.GetLasName);
        }
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1], students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }
    }

    internal static void SortStudentByAll(Student[] students, int index)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.Test - s2.Test != 0)
            {
                if (s2.Test - s1.Test > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return s1.GetLasName.CompareTo(s2.GetLasName);
        }
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1], students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }
    }

    internal static void SeachStudentByName(Student[] students, int index)
    {
        Console.Write("Nhap ten sinh vien : ");
        string name = Console.ReadLine();
        var seachStudent = new Student[index];
        int size = 0;
        foreach (var item in students)
        {
            if (item != null && item.GetLasName.CompareTo(name) == 0)
            {
                seachStudent[size++] = item;
            }
        }
        if (size > 0)
        {
            ShowStudent(seachStudent);
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien");
        }
    }

    internal static void SeachStudentByCity(Student[] students, int index)
    {
        Console.Write("Nhap tinh can tim : ");
        string addRess = Console.ReadLine();
        var seachStudent = new Student[index];
        int size = 0;
        foreach (var item in students)
        {
            if (item != null && item.AddRess.CompareTo(addRess) == 0)
            {
                seachStudent[size++] = item;
            }
        }
        if (size > 0)
        {
            ShowStudent(seachStudent);
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien");
        }
    }

    internal static void DeleteStudent(Student[] students, ref int index)
    {
        Console.WriteLine("Nhap ma sinh vien can xoa: ");
        string id = Console.ReadLine();
        bool check()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                {
                    students[i] = null;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }
        if (check())
        {
            Console.WriteLine("Xoa thanh cong !");
            index--;
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien!");
        }
    }

    internal static void StatStudentByCity(Student[] students, int index)
    {
        Information[] stat = new Information[students.Length];
        int size = 0;
        bool Check(Information[] stat, string city) 
        {
            foreach (var item in stat)
            {
                if (item != null && item.City.CompareTo(city) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        int Cout(string city, Student[] students)
        {
            int cout = 0;
            foreach (var item in students)
            {
                if (item != null && item.AddRess.CompareTo(city) ==0)
                {
                    cout++;
                }
            }
            return cout;
        }
        foreach (var item in students)
        {
            if (item != null && Check(stat, item.AddRess))
            {
                stat[size++] = new Information(item.AddRess, Cout(item.AddRess, students));
            }
        }
        var finalResutl = new Information[size];
        Array.Copy(stat, finalResutl, size);
        Array.Sort(finalResutl, (p1, p2) => p2.Amount - p1.Amount);
        foreach (var item in finalResutl)
        {
            Console.WriteLine($"{item.City} co {item.Amount}");
        }
    }
}

class Run
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Student[] students = new Student[100];
        int index = 0;
        int x;
        do
        {
            Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
           "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
           "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
           "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
           "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
           "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
           "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
           "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
           "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
           "10) Liệt kê số lượng sinh viên theo đầu điểm môn tiếng anh giảm dần.\r\n" +
           "11) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
           "12) Kết thúc chương trình.");
            Console.Write("Nhap lua chon cua ban: ");
            x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    var staff = StudentUitl.GetInfor();
                    if (staff != null)
                    {
                        students[index++] = staff;
                        Console.WriteLine($"Tao tai khoan thanh cong . MSV cua ban la : {staff.Id}");
                    }
                    else
                    {
                        Console.WriteLine("Tao tai khoan khong thanh cong!");
                    }
                    break;
                case 2:
                    if (index > 0)
                    {
                        StudentUitl.ShowStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 3:
                    if (index > 0)
                    {
                        StudentUitl.SortStudentByTest(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        StudentUitl.SortStudentByName(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        StudentUitl.SortStudentByAll(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 6:
                    if (index > 0)
                    {
                        StudentUitl.SeachStudentByName(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 7:
                    if (index > 0)
                    {
                        StudentUitl.SeachStudentByCity(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 8:
                    if (index > 0)
                    {
                        StudentUitl.DeleteStudent(students,ref index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 9:
                    if (index > 0)
                    {
                        StudentUitl.StatStudentByCity(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Sai lua chon! ");
                    break;
            }
        } while (x != 12);
    }
}
*/
#endregion




