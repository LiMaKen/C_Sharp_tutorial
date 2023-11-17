using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP.polymorphism
{
    #region Bai 1
    /*
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
            float bonus = float.Parse(Console.ReadLine());
            return new Manager(staff.Id, staff.fullName.ToString(), staff.Phone, staff.Salary, staff.WorkingDay, bonus, role);
        }

        private static Staff CreateDirector()
        {
            var staff = CreateStaff();
            Console.Write("Nhap chuc vu cua ban: ");
            string role = Console.ReadLine();
            Console.Write("Nhap he so thuong : ");
            float bonus = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian vao cty: ");
            string time = Console.ReadLine();
            var date = DateTime.ParseExact(time, "HH/yyyy", null);
            return new Director(staff.Id, staff.fullName.ToString(), staff.Phone, staff.Salary, staff.WorkingDay, bonus, date, role);
        }

        private static Staff CreateStaff()
        {
            Staff staff = new Staff();
            Console.Write("Nhap ten cua ban: ");
            staff.fullName = new FullName(Console.ReadLine());
            Console.Write("Nhap so dien thoai cua ban: ");
            staff.Phone = int.Parse(Console.ReadLine());
            Console.Write("Nhap muc luong: ");
            staff.Salary = long.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay lam viec: ");
            staff.WorkingDay = int.Parse(Console.ReadLine());
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
                    if (item is Manager)
                    {
                        Manager manager = (Manager)item;
                        Console.WriteLine($"{manager.Id,-15}{manager.fullName,-15}{manager.Phone,-15}{manager.Salary,-15}{manager.WorkingDay,-15}{manager.RealSalary,-15} {manager.Role,-15}{manager.BonusCoe,-15}");
                    }
                    else if (item is Director)
                    {
                        Director director = (Director)item;
                        Console.WriteLine($"{director.Id,-15}{director.fullName,-15}{director.Phone,-15}{director.Salary,-15}{director.WorkingDay,-15}{director.RealSalary,-15}{director.Time,-15}{director.Role,-15}{director.Bonus,-15}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Id,-15}{item.fullName,-15}{item.Phone,-15}{item.Salary,-15}{item.WorkingDay,-15}{item.RealSalary,-15}");
                    }
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
                    item.SumRealSalary(profit);
                }
            }
        }

        internal static void SortStaffByRealSalary(Staff[] staffs, int size)
        {
            int Compare(Staff s1, Staff s2)
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
                        if (Compare(staffs[j - 1], staffs[j]) > 0)
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
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void SeachStaff(Staff[] staffs, int index)
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            string id = Console.ReadLine();
            var seachStaff = new Staff[index];
            int size = 0;
            foreach (var item in staffs)
            {
                if (item != null && item.Id == id)
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
                            StaffUtil.DeleteStaff(staffs, ref index);
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
    }
    */
    #endregion
    #region Bai 2
    /*
    class BankUitl
    {
        internal static BankAccount CreateBankAccount()
        {
            Console.WriteLine("1) Tao tai khoan thanh toan");
            Console.WriteLine("2) Tao tai khoan tiet kiem");
            Console.Write("Nhap lua chon cua ban: ");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.Write("Nhap vao ten tai khoan: ");
                string name = Console.ReadLine();
                Console.Write("Nhap vao ten ngan hang: ");
                string bankName = Console.ReadLine();
                Console.Write("Nhap vao thoi gian tao: ");
                string time = Console.ReadLine();
                Console.Write("nhap vao so tien: ");
                long monney = long.Parse(Console.ReadLine());
                Console.Write("Nhap vao han muc trong 1 ngay: ");
                long limit = long.Parse(Console.ReadLine());
                return new PaymentAccount(null, name, bankName, time, monney, limit);
            }
            else if (x == 2)
            {
                Console.Write("Nhap vao ten tai khoan : ");
                string name = Console.ReadLine();
                Console.Write("Nhap vao ten ngan hang: ");
                string bankName = Console.ReadLine();
                Console.Write("Nhap vao thoi gian tao: ");
                string time = Console.ReadLine();
                Console.Write("Nhap vao so tien: ");
                long monney = long.Parse(Console.ReadLine());
                Console.Write("Nhap vao ngay gui: ");
                string date = Console.ReadLine();
                DateTime timeStart = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                Console.Write("Nhap vao ngay ket thuc: ");
                string dateEnd = Console.ReadLine();
                DateTime timeEnd = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", null);
                Console.Write("Nhap vao ky han gui (bang -1 la khong thoi han: )");
                int term = int.Parse(Console.ReadLine());
                return new SavingAccount(null, name, bankName, time, monney, timeStart, timeEnd, term);
            }
            return null;
        }
        internal static void ShowAccounts(BankAccount[] bankAccounts)
        {
            var accNumber = "Số tài khoản";
            var owner = "Chủ tài khoản";
            var bank = "Ngân hàng";
            var releaseDate = "Ngày phát hành";
            var balance = "Số dư";
            var interestRate = "Lãi suất";
            var limit = "Hạn mức";
            var term = "Kỳ hạn";
            var start = "Ngày gửi";
            var end = "Ngày hết hạn";
            var interest = "Tiền lãi";
            Console.WriteLine($"{accNumber,-20:d}{owner,-25:d}{bank,-15:d}{releaseDate,-15:d}" +
                $"{balance,-20:d}{interestRate,-15:d}{limit,-20:d}{term,-15:d}{start,-15:d}" +
                $"{end,-15:d}{interest,-20:d}");
            var noData = "-";
            var noTerm = "Không kỳ hạn";
            var format = "dd/MM/yyyy";
            foreach (var item in bankAccounts)
            {
                if (item == null)
                {
                    break;
                }
                if (item.GetType() == typeof(PaymentAccount))
                {
                    var acc = item as PaymentAccount;
                    Console.WriteLine($"{acc.BankId,-20:d}{acc.Owner,-25:d}{acc.BankName,-15:d}" +
                        $"{acc.Time,-15:d}{acc.Monney,-20:n}{acc.InterestRate / 100,-15:p}" +
                        $"{acc.DailyPaymentLimit,-20:n}{noTerm,-15:d}{noData,-15:d}" +
                        $"{noData,-15:d}{acc.CalculateInterest(),-20:n}");
                }
                else if (item.GetType() == typeof(SavingAccount))
                {
                    var acc = item as SavingAccount;
                    var termValue = acc.SendingTerm == -1 ? "Không thời hạn" : $"{acc.SendingTerm}";
                    Console.WriteLine($"{acc.BankId,-20:d}{acc.Owner,-25:d}{acc.BankName,-15:d}" +
                        $"{acc.Time,-15:d}{acc.Monney,-20:n}{acc.InterestRate / 100,-15:p}" +
                        $"{noData,-20:d}{termValue,-15:d}{acc.DispatchDate.ToString(format),-15:d}" +
                        $"{acc.ExpirationDate.ToString(format),-15:d}{acc.CalculateInterest(),-20:n}");
                }
            }
        }

        internal static void SortAccountByMonney(BankAccount[] bankAccounts)
        {
            int Compare(BankAccount a, BankAccount b)
            {
                if (a == null || b == null)
                {
                    return 0;
                }
                if (a.Monney - b.Monney != 0)
                {
                    if (b.Monney - a.Monney > 0)
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
                for (int j = i + 1; j < bankAccounts.Length; j++)
                {
                    if (Compare(bankAccounts[i], bankAccounts[j]) > 0)
                    {
                        var tmp = bankAccounts[i];
                        bankAccounts[i] = bankAccounts[j];
                        bankAccounts[j] = tmp;
                    }
                }
            }
        }

        internal static void Add(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tien muon nap: ");
                long monney = long.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten ngan hang : ");
                string bankName = Console.ReadLine();
                if (acc.GetType() == typeof(PaymentAccount))
                {
                    PaymentAccount accpay = acc as PaymentAccount;
                    accpay.AddMonney(monney, bankName);
                    accpay.CheckMonney();
                }
                else
                {
                    SavingAccount accsave = acc as SavingAccount;
                    accsave.AddMonney(monney, bankName);
                    accsave.CheckMonney();
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }

        private static BankAccount GetBankAccount(BankAccount[] bankAccounts, string id)
        {
            foreach (var item in bankAccounts)
            {
                if (item != null && item.BankId.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void Check(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                acc.CheckMonney();
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }

        internal static void Take(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tien muon rut: ");
                long monney = long.Parse(Console.ReadLine());

                acc.TakeMonney(monney, acc.BankName);
                acc.CheckMonney();

            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }

        internal static void TakeOtherBank(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tien muon rut: ");
                long monney = long.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ngan hang: ");
                string bankName = Console.ReadLine();
                acc.TakeMonney(monney, bankName);
                acc.CheckMonney();
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }

        internal static void Send(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tai khoan thu huong:");
                string id2 = Console.ReadLine();
                BankAccount acc2 = GetBankAccount(bankAccounts, id2);
                if (acc2 != null)
                {
                    Console.WriteLine("Nhap so tien muon chuyen: ");
                    long monney = long.Parse(Console.ReadLine());
                    acc.SendMonney(acc2, monney, acc.BankName);
                    acc.CheckMonney();
                }
                else
                {
                    Console.WriteLine("Khong tim thay so tai khoan thu huong !");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }

        internal static void SendOtherBank(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Nhap so tai khoan cua ban: ");
            string id = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tai khoan thu huong:");
                string id2 = Console.ReadLine();
                BankAccount acc2 = GetBankAccount(bankAccounts, id2);
                if (acc2 != null)
                {
                    Console.WriteLine("Nhap so tien muon chuyen: ");
                    long monney = long.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap ten ngan hang: ");
                    string bankName = Console.ReadLine();
                    acc.SendMonney(acc2, monney, bankName);
                    acc.CheckMonney();
                }
                else
                {
                    Console.WriteLine("Khong tim thay so tai khoan thu huong !");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan !");
            }
        }
        internal static void PayService(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Số tài khoản cần thanh toán: ");
            var accNumber = Console.ReadLine();
            var acc = GetBankAccount(bankAccounts, accNumber);
            Console.WriteLine("Số tài khoản nhận thanh toán: ");
            var destAccNumber = Console.ReadLine();
            var destAcc = GetBankAccount(bankAccounts, destAccNumber);
            if (acc != null && destAcc != null)
            {
                Console.WriteLine("Số tiền phải trả(kđ): ");
                var amount = long.Parse(Console.ReadLine()) * 1000;
                var result = acc.Pay(destAcc, amount, acc.BankName);
                if (result > 0)
                {
                    Console.WriteLine("==> Thanh toán thành công. <==");
                }
                else
                {
                    Console.WriteLine("==> Thanh toán thất bại. <==");
                }
            }
            else
            {
                Console.WriteLine("==> Tài khoản nguồn hoặc tài khoản đích không tồn tại. <==");
            }
        }
        internal static void CalculateInterest(BankAccount[] bankAccounts)
        {
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i] == null)
                {
                    break;
                }
                var acc = bankAccounts[i];
                var amount = acc.CalculateInterest();
                acc.AddMonney(amount, acc.BankName);
            }
        }
    }
    class RunAbtract
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            BankAccount[] bankAccounts = new BankAccount[100];
            int numOfAccount = 0;
            CreateFakeAccount(bankAccounts, ref numOfAccount);
            int choice;
            do
            {
                Console.WriteLine("================== CÁC CHỨC NĂNG ==================");
                Console.WriteLine("01. Thêm mới tài khoản ngân hàng vào danh sách.");
                Console.WriteLine("02. Hiển thị danh sách tài khoản ra màn hình.");
                Console.WriteLine("03. Sắp xếp danh sách theo số dư giảm dần.");
                Console.WriteLine("04. Nộp tiền vào tài khoản theo số tài khoản.");
                Console.WriteLine("05. Kiểm tra số dư của tài khoản.");
                Console.WriteLine("06. Rút tiền cùng ngân hàng của một tài khoản.");
                Console.WriteLine("07. Rút tiền khác ngân hàng của một tài khoản.");
                Console.WriteLine("08. Chuyển tiền cùng ngân hàng của một tài khoản.");
                Console.WriteLine("09. Chuyển tiền khác ngân hàng của một tài khoản.");
                Console.WriteLine("10. Thanh toán phí dịch vụ cho một tài khoản.");
                Console.WriteLine("11. Chốt lãi cho các tài khoản trong danh sách.");
                Console.WriteLine("12. Thoát chương trình.");
                Console.WriteLine("==> Xin mời bạn chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var account = BankUitl.CreateBankAccount();
                        if (account != null)
                        {
                            bankAccounts[numOfAccount++] = account;
                            Console.WriteLine($"tao tai khoan thanh cong . ID cua ban la {account.BankId}");
                        }
                        else
                        {
                            Console.WriteLine("Tao tai khoan khong thanh cong !");
                        }
                        break;
                    case 2:
                        if (numOfAccount > 0)
                        {
                            BankUitl.ShowAccounts(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 3:
                        if (numOfAccount > 0)
                        {
                            BankUitl.SortAccountByMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 4:
                        if (numOfAccount > 0)
                        {
                            BankUitl.Add(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 5:
                        if (numOfAccount > 0)
                        {
                            BankUitl.Check(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 6:
                        if (numOfAccount > 0)
                        {
                            BankUitl.Take(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 7:
                        if (numOfAccount > 0)
                        {
                            BankUitl.TakeOtherBank(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 8:
                        if (numOfAccount > 0)
                        {
                            BankUitl.Send(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 9:
                        if (numOfAccount > 0)
                        {
                            BankUitl.SendOtherBank(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 10:
                        if (numOfAccount > 0)
                        {
                            BankUitl.PayService(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 11:
                        if (numOfAccount > 0)
                        {
                            BankUitl.CalculateInterest(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("danh sach trong !");
                        }
                        break;
                    case 12:
                        Console.WriteLine("Tam biet !");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;
                }
            }
            while (choice != 12);
        }
        private static void CreateFakeAccount(BankAccount[] bankAccounts, ref int numOfAccount)
        {
            var dateFormatter = "dd/MM/yyyy";
            bankAccounts[numOfAccount++] = new PaymentAccount("0021000435680", "TRAN VAN NAM", "Vietcombank", "05/22", 100000000, 1000000000);
            bankAccounts[numOfAccount++] = new PaymentAccount("0021000435681", "LE TAN TAI", "Vietcombank", "06/22", 120000000, 1000000000);
            bankAccounts[numOfAccount++] = new PaymentAccount("0021000435682", "NGUYEN BICH HOA", "Vietcombank", "07/22", 180000000, 500000000);
            bankAccounts[numOfAccount++] = new PaymentAccount("0021000435683", "HO HAI DANG", "Vietcombank", "08/22", 160000000, 500000000);
            bankAccounts[numOfAccount++] = new PaymentAccount("0021000435685", "MAI TUAN NGOC", "Vietcombank", "09/22", 15000000, 900000000);
            bankAccounts[numOfAccount++] = new SavingAccount("0021000435686", "LUU TRIEU VI", "Vietcombank", "10/22", 1950000000, DateTime.ParseExact("15/10/2022", dateFormatter, null), DateTime.ParseExact("15/10/2023", dateFormatter, null), 12);
            bankAccounts[numOfAccount++] = new SavingAccount("0021000435688", "LE VAN CONG", "Vietcombank", "09/22", 1500000000, DateTime.ParseExact("10/06/2022", dateFormatter, null), DateTime.ParseExact("10/12/2023", dateFormatter, null), 18);
        }
    }
    */
    #endregion
    #region Bai 3
    class Geometry
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual double Perimeter() => 0;
        public virtual double Area() => 0;
    }
    class Circle : Geometry
    {
        public int Radius { get; set; }
        public Circle()
        {

        }

        public override double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override double Area()
        {
            return Math.Pow(Perimeter(), 2) / (4 * Math.PI * Radius);
        }
    }
    class Rectangle : Geometry
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return (Length + Width) * 2;
        }
    }
    class Triangle : Geometry
    {
        public int AB { get; set; }
        public int AC { get; set; }
        public int BC { get; set; }

        public override double Area()
        {
            var p = Perimeter();
            return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
        }

        public override double Perimeter()
        {
            return AB + AC + BC;
        }
    }
    class Trapezium : Geometry
    {
        public int BigBottom { get; set; }
        public int SmallBottom { get; set; }
        public int Height { get; set; }

        public override double Area()
        {
            return 0.5 * (BigBottom + SmallBottom) * Height;
        }

        public override double Perimeter()
        {
            return BigBottom + SmallBottom + 2 * Math.Sqrt(Math.Pow((BigBottom - SmallBottom) / 2, 2) + Height * Height);
        }
    }
    class Rhombus : Geometry
    {
        public int LengthDiagonalLine { get; set; }

        public override double Area()
        {
            return (LengthDiagonalLine * LengthDiagonalLine) / 2.0;
        }

        public override double Perimeter()
        {
            return 4 * Math.Sqrt((LengthDiagonalLine * LengthDiagonalLine) / 4.0);
        }
    }
    #endregion
    #region Bai 5
    class IUiltBase
    {
       public virtual string[] Split(string input) => null;
       public virtual int Cout(string input) => 0;
       public virtual string Up(string input) => null;
       public virtual string Sort(string input)=> null;
       public virtual string SortByLength(string input) => null;
       public virtual string SeachByK(char k, string input)=> null;
       public virtual string SeachMaxLength(string input)=> null;
       public virtual string SeachMinLength(string input) => null;
       public virtual string Revers(string input)=> null;
    }
    class Uilt : IUiltBase
    {
        public override int Cout(string input)
        {
            var result = Split(input);
            return result.Length;
        }

        public override string[] Split(string input)
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
        public override string Up(string intput)
        {
            var result = Split(intput);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = StringToChar(result[i]);
            }
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public override string Sort(string input)
        {
            var result = Split(input);
            Array.Sort(result, 0, result.Length);
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public override string SortByLength(string input)
        {
            var result = Split(input);
            Array.Sort(result, (p1, p2) => p2.ToCharArray().Length - p1.ToCharArray().Length);
            var data = string.Join(" ", result);
            return data.TrimEnd();
        }

        public override string SeachByK(char k, string input)
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

        public override string SeachMaxLength(string input)
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
        public override string SeachMinLength(string input)
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

        public override string Revers(string input)
        {
            var result = Split(input);
            Array.Reverse(result);
            return string.Join(" ", result);
        }
    }
    class Run
    {
        /* static void Main()
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
         }*/
    }
    #endregion
}
