using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
    #region Bai 1
    /*
    class Staff
    {
        static Staff() 
        {
            CheckID = 1000;
        }
        public Staff(string Name, int Phone , string Role , long Salary) 
        {
            ID = $"EMP{CheckID++}";
            this.Name = Name ;
            this.Phone = Phone ;
            this.Role = Role ;
            this.Salary = Salary ;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Role { get; set; }
        public long Salary { get; set; }
        public static int CheckID { get; set; }

        public string CheckIn(string checkIn) 
        {
            return $"Vao lam luc: {checkIn}";
        }

        public string CheckOut(string checkOut)
        {
            return $"Ra ve luc: {checkOut}";
        }

        public string Working(string working)
        {
            return $"{Name} dang lam {working}";
        }

        public double SumSalary(int day)
        {
            double bonus =(double) 0.2 * Salary;
            return (day >= 20) ?  Salary * (day/22) + bonus : Salary * (day/22);
        }
    }
    internal class BTStatic
    {
        static void Main()
        {
            Staff staff1 = new Staff("Do Quang Tu",0392126034,"Manager",1000000);
            Console.WriteLine(staff1.ID);
            Console.WriteLine(staff1.CheckIn("8h30"));
            Console.WriteLine(staff1.CheckOut("17h30"));
            Console.WriteLine(staff1.Working("ABC"));
            Console.WriteLine($"Tong luong : {staff1.SumSalary(22)}");
            Console.WriteLine("_____________________________________________");
            Staff staff2 = new Staff("Do Quang Tu", 0392126034, "Manager", 1000000);
            Console.WriteLine(staff2.ID);
            Console.WriteLine(staff2.ID);
            Console.WriteLine(staff2.CheckIn("8h30"));
            Console.WriteLine(staff2.CheckOut("17h30"));
            Console.WriteLine(staff2.Working("ABC"));     
            Console.WriteLine($"Tong luong : {staff2.SumSalary(22)}");
        }
    }
    */
    #endregion
    #region Bai 2
    /*
    class BankAccount
    {
        static BankAccount()
        {
            var rd = new Random();
            BankId =  rd.Next(1000000000, 2000000000);
        }
        public BankAccount()
        {
            Id = BankId;
        }

        public BankAccount(string Owner, long Money, string BankName, string Date, int Pin) : this()
        {
            this.Owner = Owner;
            this.Monney = Money;
            this.BankName = BankName;
            this.Date = Date;
            this.Pin = Pin;
        }

        public static long BankId { get; set; }

        public long Id { get; set; }
        public string Owner { get; set; }
        public long Monney { get; set; }
        public string BankName { get; set; }
        public string Date { get; set; }
        public int Pin { get; set; }

        public string AddMoney(long monney)
        {
            if (monney > 0)
            {
                Monney += monney;
                return "Nap tien thanh cong!";
            }
            else
            {
                return "Nap tien that bai!";
            }
        }

        public string TakeMoney(long monney)
        {
            if (monney > 0 && monney < Monney - 50000)
            {
                Monney -= monney;
                return "Rut tien thanh cong!";
            }
            else
            {
                return "Rut tien that bai!";
            }
        }
        
        public static string SendMoney(BankAccount account1, BankAccount account2, long monney)
        {
            if (monney > 0 && monney < account1.Monney - 50000)
            {
                account1.Monney -= monney;
                account2.Monney += monney;
                return "Chuyen tien thanh cong!";
            }
            else
            {
                return "Chuyen tien that bai!";
            }
        }
    }
    class Run
    {
        static void Main()
        {
            BankAccount[] account = new BankAccount[100];
            int index = 0;
            int x;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. \r\n" +
                    "2) Kiểm tra số dư của tài khoản b.\r\n" +
                    "3) Nạp tiền vào tài khoản.\r\n" +
                    "4) Rút tiền từ tài khoản .\r\n" +
                    "5) Chuyển tiền .\r\n" +
                    "6) Hiển thị danh sách tài khoản ra màn hình.\r\n" +
                    "7) Kết thúc chương trình.");
                Console.Write("Nhap vao lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine($"Tai khoan so: {BankAccount.BankId}");
                        account[index++] = CreateAccount();
                        Console.WriteLine($"Tao tai khoan thanh cong!");
                        break;
                    case 2:
                        if (index > 0)
                        {
                            ShowMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Trong");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            AddMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Trong");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            TakeMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Trong");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            SendMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Trong");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            ShowBankAccount(account);
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

        private static void SendMoney(BankAccount[] account)
        {
            Console.Write("Nhap STK cua ban: ");
            long stk1 = long.Parse(Console.ReadLine());
            var acc1 = FindAccount(account, stk1);
            if (acc1 != null)
            {
                Console.Write("Vui long nhap ma pin: ");
                int pin = int.Parse(Console.ReadLine());
                if (acc1.Pin == pin)
                {
                    Console.Write("Nhap stk nguoi nhan: ");
                    long stk2 = long.Parse(Console.ReadLine());
                    var acc2 = FindAccount(account, stk2);
                    if (acc2 != null)
                    {
                        Console.Write("Nhap so tien can chuyen: ");
                        long money = long.Parse(Console.ReadLine());
                        Console.WriteLine(BankAccount.SendMoney(acc1, acc2, money));
                    }
                    else
                    {
                        Console.WriteLine("Thong tin khong hop le!");
                    }
                }
                else
                {
                    Console.WriteLine("Ma pin khong hop le!");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        private static void TakeMoney(BankAccount[] account)
        {
            Console.Write("Nhap STK cua ban: ");
            long stk = long.Parse(Console.ReadLine());
            var acc = FindAccount(account, stk);
            if (acc != null)
            {
                Console.WriteLine("Vui long nhap ma pin: ");
                int pin = int.Parse(Console.ReadLine());
                if (acc.Pin == pin)
                {
                    Console.WriteLine("Nhap so tien can rut: ");
                    long money = long.Parse(Console.ReadLine());
                    Console.WriteLine(acc.TakeMoney(money));
                }
                else
                {
                    Console.WriteLine("Ma pin khong hop le!");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        private static void AddMoney(BankAccount[] account)
        {
            Console.Write("Nhap STK can nap tien: ");
            long stk = long.Parse(Console.ReadLine());
            var acc = FindAccount(account, stk);
            if (acc != null)
            {
                Console.WriteLine("Nhap so tien can nap: ");
                long money = long.Parse(Console.ReadLine());
                Console.WriteLine(acc.AddMoney(money));
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        private static void ShowMoney(BankAccount[] account)
        {
            Console.Write("Nhap STK can tra cuu: ");
            long stk = long.Parse(Console.ReadLine());
            var acc = FindAccount(account, stk);
            if (acc != null)
            {
                Console.WriteLine($"So du tai khoan {acc.Id} la: {acc.Monney}");
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        private static BankAccount FindAccount(BankAccount[] account, long id)
        {
            foreach (var item in account)
            {
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private static void ShowBankAccount(BankAccount[] account)
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
                    Console.WriteLine($"{item.Id,-15}{item.Owner,-15}{item.Monney,-15}{item.BankName,-15}{item.Date,-15}{item.Pin,-15}");
                }
            }
        }

        private static BankAccount CreateAccount()
        {
            while (true)
            {
                Console.Write("Nhap ten tai khoan cua ban: ");
                string name = Console.ReadLine();
                Console.Write("Nhap so tien: ");
                long monney = long.Parse(Console.ReadLine());
                Console.Write("Nhap ten ngan hang: ");
                string bankName = Console.ReadLine();
                Console.Write("Nhap han su dung: ");
                string date = Console.ReadLine();
                Console.Write("Nhap ma Pin cua ban: ");
                int pin = int.Parse(Console.ReadLine());
                if (pin.ToString().Length != 6)
                {
                    Console.WriteLine("Ma pin phai co 6 chu so!");
                    continue;
                }
                else
                {
                    return new BankAccount(name, monney, bankName, date, pin);
                }
            }
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
            ID = "ST" + IDCout++;
        }
        public Student(string name, string middleName, string surName, string addRess, double test, string major) : this()
        {
            Name = name;
            MiddleName = middleName;
            SurName = surName;
            AddRess = addRess;
            Test = test;
            Major = major;

        }
        public static int IDCout { get; set; } = 1000;

        public string ID { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string AddRess { get; set; }
        public double Test { get; set; }
        public string Major { get; set; }
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
                        Console.WriteLine($"* Sinh vien {Student.IDCout} *");
                        students[index++] = CreateStudent();
                        Console.WriteLine("Them sinh vien thanh cong! ");
                        Console.WriteLine();
                        break;
                    case 2:
                        if (index > 0)
                        {
                            ShowStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            SortStudentByTest(students);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            SortStudentByName(students,index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            SortStudentByAll(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            SeachStudentById(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        if (index > 0)
                        {
                            SeachStudentByAddRess(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 8:
                        if (index > 0)
                        {
                            DeleteStudent(students,ref index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 9:
                        if (index > 0)
                        {
                            StatAddress(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 10:
                        if (index > 0)
                        {
                            EditTest(students,index);
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

        private static void EditTest(Student[] students, int index)
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

        private static void StatAddress(Student[] students, int index)
        {
            bool Check(string addRess , Information[] stats)
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
            Array.Sort(finalResult,(p1,p2) => p2.Amount - p1.Amount);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Address} + {item.Amount}");
            }
        }

        private static void DeleteStudent(Student[] students,ref int index)
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

        private static void SeachStudentByAddRess(Student[] students, int index)
        {
            Console.Write("Nhap dia chi: ");
            string addRess = Console.ReadLine();
            var show = new Student[index];
            int cout = 0;
            for (int i = 0; i < index; i++)
            {
                if (students[i]!= null && students[i].AddRess.CompareTo(addRess)== 0)
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
            var student = CheckId(students,id);
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
                if (s1 == null ||  s2 == null)
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
                        Swap(ref students[j-1], ref students[j]);
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
            return new Student(name[2], name[1], name[0], addRess, test, major);
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
    */
    #endregion
}
