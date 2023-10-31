using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chuong6
{
    #region Bai 1
    /*
    class Staff
    {
        public Staff()
        {

        }

        public Staff(string id, string name, int phone, string role, long salary, int date, long wage)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Role = role;
            Salary = salary;
            Date = date;
            Wage = wage;
        }

        private string _id;
        private static int _amount = 1000;
        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + _amount++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Role { get; set; }
        public long Salary { get; set; }
        public int Date { get; set; }
        public long Wage { get; set; }

        public string CheckIn(string time)
        {
            return $"Nhan vien {Name} CheckIn luc: {time}";
        }

        public string CheckOut(string time)
        {
            return $"Nhan vien {Name} CheckOut luc: {time}";
        }

        public string DoWork(string work)
        {
            return $"Nhan vien {Name} dang lam: {work}";
        }

        public long SumWage()
        {
            double bonus = (double) 0.2 * Salary;
            double inDate = (double)Date / 22;
            return  (long) ((Date >= 22) ? Salary * inDate + bonus : Salary * inDate);
        }
    }
    class StaffUtils
    {
        public static Staff CreateStaff()
        {
            Console.Write("Nhap ho ten : ");
            string name = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu: ");
            string role = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            long salary = long.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay lam viec: ");
            int date = int.Parse(Console.ReadLine());
            return new Staff(null, name, phone, role, salary, date, 0);
        }

        public static void ShowStaff(Staff[] staffs)
        {
            var titleID = "Ma nhan vien";
            var titleName = "Ho va Ten";
            var titlePhone = "SDT";
            var titleRole = "Chuc Vu";
            var titleSalary = "Luong Cung";
            var titleDate = "So ngay lam";
            var titleWage = "Tong luong";
            Console.WriteLine($"{titleID,-15}{titleName,-15}{titlePhone,-15}{titleRole,-15}{titleSalary,-15}{titleDate,-15}{titleWage,-15}");
            foreach (var item in staffs)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.ID,-15}{item.Name,-15}{item.Phone,-15}{item.Role,-15}{item.Salary,-15}{item.Date,-15}{item.Wage,-15}");
                }
            }
        }

        public static void SumWage(Staff[] staffs)
        {
            foreach (var item in staffs)
            {
                if (item != null)
                {
                    item.Wage = item.SumWage();
                }
            }
        }

        public static void SortStaffBySalary(Staff[] staffs, int size)
        {
            int Compare(Staff s1 , Staff s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.Salary - s2.Salary != 0)
                {
                    if (s2.Salary > s1.Salary)
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
                for (int j = size - 1 ; j > i; j--)
                {
                    if (Compare(staffs[j - 1], staffs[j]) > 0)
                    {
                        var tmp = staffs[i];
                        staffs[i] = staffs[j];
                        staffs[j] = tmp;
                    }
                }
            }
        }

        public static void SortStaffByDate(Staff[] staffs, int size)
        {
            int Compare(Staff s1, Staff s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.Date - s2.Date != 0)
                {
                    if (s2.Date > s1.Date)
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
                for (int j = size - 1; j > i; j--)
                {
                    if (Compare(staffs[j - 1], staffs[j]) > 0)
                    {
                        var tmp = staffs[i];
                        staffs[i] = staffs[j];
                        staffs[j] = tmp;
                    }
                }
            }
        }

        public static void SeachStaff(Staff[] staffs, int size)
        {
            Console.Write("Nhap ma nhan vien can tim: ");
            string id = Console.ReadLine();
            var staff = CheckStaff(staffs, id);
            Staff[] addStaff = new Staff[size];
            int index = 0;
            if (staff != null)
            {
                addStaff[index++] = staff;
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien !");
            }
            ShowStaff(addStaff);
        }

        public static void EditSalary(Staff[] staffs, int size)
        {
            Console.Write("Nhap ma nhan vien can cap nhat luong: ");
            string id = Console.ReadLine();
            var staff = CheckStaff(staffs, id);
            if (staff != null)
            {
                Console.WriteLine("Nhap muc luong can chinh sua: ");
                long editSalary = long.Parse(Console.ReadLine());
                staff.Salary = editSalary;
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien !");
            }
        }

        public static bool DeleteStaff(Staff[] staffs,ref int size)
        {
            Console.Write("Nhap ma nhan vien can xoa: ");
            string id = Console.ReadLine();
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != null && staffs[i].ID.CompareTo(id) == 0)
                {
                    staffs[i] = null;
                    size--;
                    for (int j = i; j < staffs.Length - 1; j++)
                    {
                        staffs[j] = staffs[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }

        public static Staff CheckStaff(Staff[] staffs, string id)
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
    }
    class BTBox
    {
        static void Main()
        {
            Staff[] staffs = new Staff[100];
            int x;
            int indexStaff = 0;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("1) Thêm mới một nhân viên vào danh sách nhân viên.\r\n" +
                    "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
                "3) Tính lương của các nhân viên trong danh sách.\r\n" +
                "4) Sắp xếp danh sách nhân viên theo mức lương giảm dần.\r\n" +
                "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng giảm dần.\r\n" +
                "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
                "7) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
                "8) Xóa bỏ nhân viên có mã cho trước.\r\n" +
                "9) Thoát chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        staffs[indexStaff++] = StaffUtils.CreateStaff();
                        break;
                    case 2:
                        if (indexStaff > 0)
                        {
                            StaffUtils.ShowStaff(staffs);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (indexStaff > 0)
                        {
                            StaffUtils.SumWage(staffs);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (indexStaff > 0)
                        {
                            StaffUtils.SortStaffBySalary(staffs,indexStaff);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (indexStaff > 0)
                        {
                            StaffUtils.SortStaffByDate(staffs, indexStaff);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (indexStaff > 0)
                        {
                            StaffUtils.SeachStaff(staffs, indexStaff);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        if (indexStaff > 0)
                        {
                            StaffUtils.EditSalary(staffs, indexStaff);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 8:
                        if (indexStaff > 0)
                        {
                            bool check = StaffUtils.DeleteStaff(staffs,ref indexStaff);
                            if (check)
                            {
                                Console.WriteLine("Xoa thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay sinh vien !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Tam biet !");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;
                }
            } while (x != 9);
        }
    }
    */
    #endregion
    #region bai 2
    /*
    class BankAccount
    {
        public BankAccount()
        {

        }

        public BankAccount(int id, string name, long monney, string bankName, string date, string pin)
        {
            BankID = id;
            Name = name;
            Monney = monney;
            BankName = bankName;
            Date = date;
            Pin = pin;
        }

        private static long _idAmount = (long)Math.Pow(10, 13);

        private long _id;
        private string _pin;

        public long BankID
        {
            get => _id;
            set
            {
                if (value == 0)
                {
                    _id = _idAmount++;
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string Name { get; set; }
        public long Monney { get; set; }
        public string BankName { get; set; }
        public string Date { get; set; }

        public string Pin
        {
            get => _pin;
            set
            {
                if (value.Length == 6)
                {
                    _pin = value;
                }
                else
                {
                    Console.WriteLine("Ma pin khong hop le! Ma pin duoc nap mac dinh la : 000000");
                    _pin = "000000";
                }
            }
        }

        public void ShowMonney()
        {
            Console.WriteLine($"So du stk {BankID} la : {Monney}");
        }

        public void AddMonney(long monney)
        {
            if (monney > 0)
            {
                Monney += monney;
                Console.WriteLine("Nap tien thanh cong! ");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }

        public void TakeMonney(long monney)
        {
            if (monney > 0 && monney < Monney - 50000)
            {
                Monney -= monney;
                Console.WriteLine("Rut tien thanh cong!");
            }
            else { Console.WriteLine("Rut tien that bai !"); }
        }

        public void SendMonney(BankAccount orther, long monney)
        {
            if (monney > 0 && monney < Monney - 50000)
            {
                Monney -= monney;
                orther.Monney += monney;
                Console.WriteLine("Chuyen tien thanh cong!");
            }
            else
            {
                Console.WriteLine("Chuyen tien that bai!");
            }
        }
    }

    class BankUtil
    {
        public static BankAccount CreateAccount()
        {
            Console.Write("Nhap vao ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap vao so tien: ");
            long monney = long.Parse(Console.ReadLine());
            Console.Write("Nhap vao ten ngan hang: ");
            string bankName = Console.ReadLine();
            Console.Write("Nhap vao han su dung: ");
            string date = Console.ReadLine();
            Console.Write("Nhap vao ma pin: ");
            string pin = Console.ReadLine();
            return new BankAccount(0, name, monney, bankName, date, pin);
        }

        public static void ShowBankAccount(BankAccount[] account)
        {
            var titleID = "STK";
            var titleOwner = "Owner";
            var titleMonney = "Monney";
            var titleBankName = "Bank Name";
            var titleDate = "HSD";
            var titlePin = "Pin";
            Console.WriteLine($"{titleID,-15}{titleOwner,-15}{titleMonney,-15}{titleBankName,-15}{titleDate,-15}{titlePin,-15}");
            foreach (var item in account)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.BankID,-15}{item.Name,-15}{item.Monney,-15}{item.BankName,-15}{item.Date,-15}{item.Pin,-15}");
                }
            }
        }

        public static void ShowMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk can kiem tra: ");
            long id = long.Parse(Console.ReadLine());
            var acc = CheckAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine($"STK {acc.BankID} so du: {acc.Monney}");
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin tai khoan!");
            }

        }

        public static BankAccount CheckAccount(BankAccount[] bankAccounts, long id)
        {
            foreach (var item in bankAccounts)
            {
                if (item != null && item.BankID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void TakeMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk can rut tien : ");
            long id = long.Parse(Console.ReadLine());
            var acc = CheckAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap ma pin: ");
                string pin = Console.ReadLine();
                if (acc.Pin.CompareTo(pin) == 0)
                {
                    Console.Write("Nhap so tien can rut: ");
                    long money = long.Parse(Console.ReadLine());
                    acc.TakeMonney(money);
                }
                else
                {
                    Console.WriteLine("Ma pin khong chinh xac !");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        public static void SendMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk : ");
            long id = long.Parse(Console.ReadLine());
            var acc1 = CheckAccount(bankAccounts, id);
            if (acc1 != null)
            {
                Console.WriteLine("Nhap ma pin: ");
                string pin = Console.ReadLine();
                if (acc1.Pin.CompareTo(pin) == 0)
                {
                    Console.Write("Nhap so tai khoan thu huong: ");
                    long id2 = long.Parse(Console.ReadLine());
                    var acc2 = CheckAccount(bankAccounts, id2);
                    if (acc2 != null)
                    {
                        Console.Write("Nhap so tien can chuyen: ");
                        long money = long.Parse(Console.ReadLine());
                        acc1.SendMonney(acc2, money);
                    }
                    else
                    {
                        Console.WriteLine("So tai khoan thu huong khong chinh xac!");
                    }
                }
                else
                {
                    Console.WriteLine("Ma pin khong chinh xac !");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }
    }

    class Run
    {
        static void Main()
        {
            BankAccount[] bankAccounts = new BankAccount[100];
            int index = 0;
            int x;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
                    "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
                    "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
                    "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
                    "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 50k VNđ.\r\n" +
                    "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n7) Kết thúc chương trình.");
                Console.Write("Nhap vao lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        bankAccounts[index++] = BankUtil.CreateAccount();
                        break;
                    case 2:
                        if (index > 0)
                        {
                            BankUtil.ShowMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            BankUtil.ShowMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            BankUtil.TakeMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            BankUtil.SendMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            BankUtil.ShowBankAccount(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon!");
                        break;
                }
            } while (x != 7);
        }
    }
    */
    #endregion
    #region Bai 3
    /*
    class Student
    {
        public Student()
        {
            ID = null;
        }
        public Student(string id, string name, string middleName, string surName, string addRess, double test, string major)
        {
            ID = id;
            Name = name;
            MiddleName = middleName;
            SurName = surName;
            AddRess = addRess;
            Test = test;
            Major = major;

        }
        private static int IDCout { get; set; } = 1000;
        private string _id;
        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "ST" + IDCout++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string AddRess { get; set; }
        public double Test { get; set; }
        public string Major { get; set; }
    }

    class StudentUitl
    {
        public static void EditTest(Student[] students, int index)
        {
            Console.Write("Nhap vao ma sinh vien can thay doi diem: ");
            string msv = Console.ReadLine();
            var student = CheckId(students, msv);
            if (student != null)
            {
                Console.Write("Nhap vao so diem can thay doi: ");
                double change = double.Parse(Console.ReadLine());
                student.Test = change;
            }
            else { Console.WriteLine("Khong tim thay sinh vien !"); }
        }

        class Information
        {
            public string Address { get; set; }
            public int Amount { get; set; }
        }

        public static void StatAddress(Student[] students, int index)
        {
            bool Check(string addRess, Information[] stats)
            {
                foreach (var item in stats)
                {
                    if (item != null && item.Address.CompareTo(addRess) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            int Cout(string addRess, Student[] student)
            {
                int cout = 0;
                foreach (var item in student)
                {
                    if (item != null && item.AddRess.CompareTo(addRess) == 0)
                    {
                        cout++;
                    }
                }
                return cout;
            }
            Information[] stat = new Information[students.Length];
            int size = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (Check(students[i].AddRess, stat))
                    {
                        stat[size] = new Information();
                        stat[size].Address = students[i].AddRess;
                        stat[size].Amount = Cout(students[i].AddRess, students);
                        size++;
                    }
                }
            }
            var finalResult = new Information[size];
            Array.Copy(stat, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => p2.Amount - p1.Amount);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Address} + {item.Amount}");
            }
        }

        public static void DeleteStudent(Student[] students, ref int index)
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string msv = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].ID.CompareTo(msv) == 0)
                {
                    students[i] = null;
                    index--;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];

                    }
                }
            }
        }

        public static void SeachStudentByAddRess(Student[] students, int index)
        {
            Console.Write("Nhap dia chi: ");
            string addRess = Console.ReadLine();
            var show = new Student[index];
            int cout = 0;
            for (int i = 0; i < index; i++)
            {
                if (students[i] != null && students[i].AddRess.CompareTo(addRess) == 0)
                {
                    show[cout++] = students[i];
                }
            }
            if (cout > 0)
            {
                ShowStudent(show);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao !");
            }
        }

        public static Student CheckId(Student[] students, string id)
        {
            foreach (var item in students)
            {
                if (item != null && item.ID.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        public static void SeachStudentById(Student[] students, int index)
        {
            Console.Write("Nhap ma sinh vien: ");
            string id = Console.ReadLine();
            var student = CheckId(students, id);
            var show = new Student[index];
            int cout = 0;
            if (student != null)
            {
                show[cout++] = student;
                ShowStudent(show);
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin sinh vien!");
            }
        }

        public static void SortStudentByAll(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.Test - s2.Test != 0)
                {
                    if (s2.Test > s1.Test)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return s1.Name.CompareTo(s2.Name);
                }
            }
            for (int i = 0; i < index - 1; i++)
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

        public static void SortStudentByName(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.Name.CompareTo(s2.Name);
            }
            for (int i = 0; i < index - 1; i++)
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

        public static void SortStudentByTest(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    for (int j = i + 1; j < students.Length; j++)
                    {
                        if (students[j] != null && students[i].Test < students[j].Test)
                        {
                            Swap(ref students[i], ref students[j]);
                        }
                    }
                }
            }
        }

        public static void Swap(ref Student student1, ref Student student2)
        {
            Student tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        public static Student CreateStudent()
        {
            Console.Write("Nhap ten cua ban: ");
            var name = Console.ReadLine().Split(' ');
            Console.Write("Nhap dia chi: ");
            string addRess = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            double test = double.Parse(Console.ReadLine());
            Console.Write("Nhap chuyen nganh: ");
            string major = Console.ReadLine();
            return new Student(null, name[2], name[1], name[0], addRess, test, major);
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
                    Console.WriteLine($"{item.ID,-15}{item.SurName + " " + item.MiddleName + " " + item.Name,-20}{item.AddRess,-15}{item.Test,-15}{item.Major,-15}");
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Run
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[100];
            int index = 0;
            int x;
            do
            {
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
               "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn.Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
               "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
               "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
               "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
               "6) Tìm sinh viên theo tên.Hiển thị kết quả tìm được.\r\n" +
               "7) Tìm sinh viên theo tỉnh.Hiển thị kết quả tìm được.\r\n" +
               "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
               "9) Liệt kê số lượng sinh viên theo từng tỉnh.Sắp xếp giảm dần theo số lượng.\r\n" +
               "10) Liệt kê số lượng sinh viên theo đầu điểm môn tiếng anh giảm dần.\r\n" +
               "11) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
               "12) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        students[index] = StudentUitl.CreateStudent();
                        Console.WriteLine($"Them sinh vien thanh cong! Ma sinh vien cua ban la {students[index].ID}");
                        index++;
                        Console.WriteLine();
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
                            StudentUitl.SortStudentByTest(students);
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
                            StudentUitl.SeachStudentById(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        if (index > 0)
                        {
                            StudentUitl.SeachStudentByAddRess(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 8:
                        if (index > 0)
                        {
                            StudentUitl.DeleteStudent(students, ref index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 9:
                        if (index > 0)
                        {
                            StudentUitl.StatAddress(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 10:
                        if (index > 0)
                        {
                            StudentUitl.EditTest(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Tam biet !");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;

                }
            } while (x != 11);
        }
    }
    */
    #endregion
}
