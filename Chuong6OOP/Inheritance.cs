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
    private static long amount = (long)Math.Pow(1, 13);

    public long BankId { get; set; }
    public string Owner { get; set; }
    public long Monney { get; set; }
    public string BankName { get; set; }
    public DateTime Time { get; set; }
    public long TranferOfDay { get; set; } // số tiền chuyển trong 1 ngày
    public long TotalDailyTransfer { get; set; }

    public int Pin
    {
        get => Pin;
        set
        {
            if (value.ToString().Length != 6)
            {
                Console.WriteLine("Ma pin phai la 6 chu so. Ma pin cua ban duoc doi thanh 000000");
                Pin = 000000;
            }
            else
            {
                Pin = value;
            }
        }
    }

    public BankAccount()
    {
        BankId = amount++;
    }

    public BankAccount(long id, string owner, long monney, string bankName, DateTime time, int pin)
    {
        BankId = id > 0 ? id : amount++;
        Owner = owner;
        BankName = bankName;
        Monney = monney;
        Time = time;
        Pin = pin;
    }

    public void CheckMonney()
    {
        Console.WriteLine("=====THÔNG BÁO SỐ DƯ=====");
        Console.WriteLine($"Số tài khoản {BankId} chủ sở hữu {Owner} có số dư là: {Monney}");
    }

    public void AddMonney(long monney)
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

}

class Run
{
    static void Main()
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
        Console.ReadLine();
    }
}
#endregion



