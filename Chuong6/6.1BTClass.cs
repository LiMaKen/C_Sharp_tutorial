using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
    #region Bai 1
    /*
    class Staff
    {
        public Staff(string mNV, string nAME, int pHONENUMBER, long wAGE)
        {
            MNV = mNV;
            NAME = nAME;
            PHONENUMBER = pHONENUMBER;
            WAGE = wAGE;
        }

        public string MNV { get; set; }
        public string NAME { get; set; }
        public int PHONENUMBER { get; set; }
        public long WAGE { get; set; }

        public override string ToString() => $"{MNV} - {NAME} - {WAGE} -";

        public void CheckIn(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} checkin luc {x}");
        }
        public void Checkout(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} checkout luc {x}");
        }
        public void DoWork(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} dang lam {x}");
        }
        public double SumWage(double workingDay)
        {
            double bonus = (workingDay >= 22) ? 0.2*WAGE: 0;       
            return (WAGE * workingDay / 22) + bonus;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = CreateStaff();

            staff.CheckIn("8:30");
            staff.Checkout("17:30");
            staff.DoWork("Danh nhau voi code");
            Console.WriteLine("Tong luong: " + staff.SumWage(22)); 

        }

        public static Staff CreateStaff()
        {
            Console.Write("Moi ban nhap ma NV: ");
            string mnv = Console.ReadLine();
            Console.Write("Moi ban nhap ho va ten:");
            string name = Console.ReadLine();
            Console.Write("Moi ban nhap so dien thoai: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap muc luong: ");
            long wage = long.Parse(Console.ReadLine());
            return new Staff(mnv, name, phone, wage);

        }
    }
    */
    #endregion
    #region Bai 2
    /*
    class Matrix
    {
        public int Row { get; set; }
        public int Colum { get; set; }
        public int[,] data { get; set; }

        public Matrix(int row, int colum)
        {
            this.Row = row;
            this.Colum = colum;
            data = new int[row, colum];
        }

        public void GetData()
        {
            Console.WriteLine($"So hang {Row} x So cot {Colum}");
            for (int i = 0; i < Row; i++)
            {
                var element = Console.ReadLine().Split(' ');
                for (int j = 0; j < Colum; j++)
                {
                    data[i,j] = Convert.ToInt32(element[j]);
                }
                Console.WriteLine();
            }
        }

        public void ShowMaTrix()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j  = 0; j < Colum; j++)
                {
                    Console.Write(data[i,j]);
                }
                Console.WriteLine();
            }
        }
        public Matrix SumMatrix(Matrix other)
        {
            if (other == null || other.Row != this.Row || other.Colum != this.Colum)
            {
                return null; 
            }
            Matrix result = new Matrix(Row, Colum);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Colum; j++)
                {
                    result.data[i, j] = data[i, j] + other.data[i, j];
                }
            }
            return result;
        }
        public Matrix Mul(Matrix other)
        {
            if (Colum != other.Row)
            {
                return null;
            }
            Matrix result = new Matrix(Row, other.Colum);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < other.Colum; j++)
                {
                    for (int k = 0; k < Colum; k++)
                    {
                        result.data[i, j] += data[i, k] * other.data[k, j];
                    }
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixA = new Matrix(3, 4);
            Matrix matrixB = new Matrix(3, 4);
            Matrix matrixC = new Matrix(4, 3);
            Console.WriteLine("Nhap ma tran A: ");
            matrixA.GetData();
            Console.WriteLine("Nhap ma tran B: ");
            matrixB.GetData();
            Console.WriteLine("Nhap ma tran C: ");
            matrixC.GetData();
            Console.WriteLine("Ma tran A: ");
            matrixA.ShowMaTrix();
            Console.WriteLine("Ma tran B: ");
            matrixB.ShowMaTrix();
            Console.WriteLine("Ma tran C: ");
            matrixC.ShowMaTrix();
            Console.WriteLine("Tong cua 2 ma tran la:");
            Matrix result = matrixA.SumMatrix(matrixB);
            result.ShowMaTrix();
            var product = matrixA.Mul(matrixC);
            Console.WriteLine("Ma tran tich A x C: ");
            product.ShowMaTrix();
        }
    }
    */
    #endregion
    #region Bai 4
    /*
    class BankAccount
    {
        public int IDBANK { get; set; }
        public string NAME { get; set; }
        public long MONNEY { get; set; }
        public string BANKNAME { get; set; }
        public string DATE { get; set; }
        public int PIN { get; set; }

        public BankAccount(int idBank, string name, long monney, string bankName, string date, int pin)
        {
            IDBANK = idBank;
            NAME = name;
            MONNEY = monney;
            BANKNAME = bankName;
            DATE = date;
            PIN = pin;
        }

        public void ShowMonney()
        {
            Console.WriteLine($"Tai khoan {NAME} co so du la : {MONNEY}");
        }

        public long AddMonney(long cash)
        {
            if (cash > 0)
            {
                MONNEY += cash;
                return cash;
            }
            return 0;
        }

        public string TakeMoney(long cash)
        {
            if (cash < MONNEY - 50000 && MONNEY > 0)
            {
                MONNEY -= cash;
                return "Rut tien thanh cong !";
            }
            else
            {
                return "Rut tien that bai !";
            }
        }

        public string SendMonney(BankAccount other, long cash)
        {
            if (cash < MONNEY - 50000 && MONNEY > 0)
            {
                MONNEY -= cash;
                other.MONNEY += cash;
                return "Chuyen tien thanh cong !";
            }
            else
            {
                return "Chuyen tien that bai !";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x;
            BankAccount[] account = new BankAccount[100];
            int index = 0;
            do
            {
                Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào mảng.\r\n" +
               "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
               "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
               "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút.\r\n" +
               "5) Chuyển tiền từ tài khoản x sang tài khoản y.\r\n" +
               "6) Hiển thị danh sách tài khoản ra màn hình.\r\n" +
               "7) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        BankAccount account2 = GetData();
                        if (CheckID(account, account2.IDBANK) == null)
                        {
                            account[index++] = account2;
                            Console.WriteLine("Tao tai khoan thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("So tai khoan da ton tai !");
                        }
                        break;
                    case 2:
                        if (index > 0)
                        {
                            ShowMonney(account);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            AddMonneyToID(account);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            TakeMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            SendMoney(account);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            ShowBankAcc(account);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tam biet !");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;
                }
            } while (x != 7);
        }

        private static void ShowBankAcc(BankAccount[] account)
        {
            var titleID = "So TK";
            var titleOwner = "Chu TK";
            var titleMoney = "So Du";
            var titleBankName = "Ngan Hang";
            var titleDate = "Han Su Dung";
            var titlePin = "Ma PIN";
            Console.WriteLine($"{titleID,-15:d}{titleOwner,-20:d}{titleMoney,-15:d}" +
                        $"{titleBankName,-15:d}{titleDate,-15:d}{titlePin,-10:d}");
            foreach (var item in account)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.IDBANK,-15:d}{item.NAME,-20:d}" +
                       $"{item.MONNEY,-15:d}{item.BANKNAME,-15:d}{item.DATE,-15:d}" +
                       $"{item.PIN,-10:d}");
                }
                else
                {
                    break;
                }
            }
        }

        private static void TakeMoney(BankAccount[] account)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap ma Pin :");
            int pin = int.Parse(Console.ReadLine());
            var acc = CheckID(account, id);
            if (acc != null && acc.PIN == pin)
            {
                Console.Write("Moi ban nhap so tien can rut :");
                long cash = int.Parse(Console.ReadLine());
                Console.WriteLine(acc.TakeMoney(cash));
                acc.ShowMonney();
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le !");
            }
        }

        private static void SendMoney(BankAccount[] account)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap ma Pin :");
            int pin = int.Parse(Console.ReadLine());
            var acc = CheckID(account, id);
            if (acc != null && acc.PIN == pin)
            {
                Console.Write("Moi ban nhap so tai khoan ngoi thu huong :");
                int idSend = int.Parse(Console.ReadLine());
                Console.Write("Moi ban nhap so tien can chuyen :");
                long cash = int.Parse(Console.ReadLine());
                var acc2 = CheckID(account, idSend);
                if (acc2 != null)
                {
                    Console.WriteLine(acc.SendMonney(acc2, cash));
                    acc.ShowMonney();
                }
                else
                {
                    Console.WriteLine("Khong tim thay thong tin tai khoan thu huong !");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin tai khoan !");
            }
        }

        private static void AddMonneyToID(BankAccount[] account)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap co tien muon nap: ");
            long cash = long.Parse(Console.ReadLine());
            var acc = CheckID(account, id);
            if (acc != null)
            {
                long check = acc.AddMonney(cash);
                if (check > 0)
                {
                    Console.WriteLine("Nap tien thanh cong !");
                    acc.ShowMonney();
                }
                else
                {
                    Console.WriteLine("Nap tien that bai !");
                }

            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin tai khoan");
            }
        }

        private static void ShowMonney(BankAccount[] account)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            var id = int.Parse(Console.ReadLine());
            var acc = CheckID(account, id);
            if (acc != null)
            {
                acc.ShowMonney();
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin tai khoan !");
            }
        }

        public static BankAccount CheckID(BankAccount[] acc, int id)
        {
            foreach (var item in acc)
            {
                if (item != null && item.IDBANK == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static BankAccount GetData()
        {
            while (true)
            {
                Console.Write("Nhap vao so tai khoan: ");
                string checkID = Console.ReadLine();
                Console.Write("Nhap vao ten tai khoan: ");
                string name = Console.ReadLine();
                Console.Write("Nhap vao so tien: ");
                string checkMonney = Console.ReadLine();
                Console.Write("Nhap vao ngan hang phat hanh: ");
                string bankName = Console.ReadLine();
                Console.Write("Nhap vao thoi diem het hieu luc: ");
                string date = Console.ReadLine();
                Console.Write("Nhap vao ma PIN: ");
                string checkPin = Console.ReadLine();
                if (checkID == "" || name == "" || checkMonney == "" || bankName == "" || date == "" || checkPin == "")
                {
                    Console.WriteLine("Nhap du cac thong tin");
                    continue;
                }
                else if (int.TryParse(checkID, out int id) == false || long.TryParse(checkMonney, out long monney) == false || int.TryParse(checkPin, out int pin) == false)
                {
                    Console.WriteLine("Sai dinh dang");
                    continue;
                }
                else if (monney < 0)
                {
                    Console.WriteLine("So tien phai lon hon 0");
                    continue;
                }
                else if (pin.ToString().Length != 6)
                {
                    Console.WriteLine("Ma pin phai du 6 so");
                    continue;
                }
                else
                {
                    return new BankAccount(id, name, monney, bankName, date, pin);
                }
            }
        }
    }
    */
    #endregion
    #region Bai 5
    /*
    class Student
    {
        public string MSV { get; set; }
        public string SURNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string NAME { get; set; }
        public string CITY { get; set; }
        public double TEST { get; set; }
        public string MAJOR { get; set; }

        public Student(string MSV, string SURNAME, string MIDDLENAME, string NAME, string CITY, double TEST, string MAJOR)
        {
            this.MSV = MSV;
            this.SURNAME = SURNAME;
            this.MIDDLENAME = MIDDLENAME;
            this.NAME = NAME;
            this.CITY = CITY;
            this.TEST = TEST;
            this.MAJOR = MAJOR;
        }
    }
    internal class chuong6
    {
        static void Main()
        {
            Student[] students = new Student[100];
            int index = 0;
            int x;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
                "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn.\r\n" +
                "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
                "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
                "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
                "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
                "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
                "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
                "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
                "10) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
                "11) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Student student = CreateStudent();
                        if (CheckStudent(students, student.MSV) == null)
                        {
                            students[index++] = student;
                            Console.WriteLine("Them thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("Sinh vien da ton tai !");
                        }
                        break;
                    case 2:
                        if (index > 0)
                        {
                            ShowStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            SortStudentByTest(students, index);
                            Console.WriteLine("Danh sach sinh vien da duoc sap xep!");
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            SortStudentByName(students, index);
                            Console.WriteLine("Danh sach sinh vien da duoc sap xep!");
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            SortStudentByAll(students, index);
                            Console.WriteLine("Danh sach sinh vien da duoc sap xep!");
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            SeachStudentByName(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 7:
                        if (index > 0)
                        {
                            SeachStudentByCity(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 8:
                        if (index > 0)
                        {
                            DeleteStudentByMsv(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 9:
                        if (index > 0)
                        {
                            Status(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
                        }
                        break;
                    case 10:
                        if (index > 0)
                        {
                            EditTest(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong !");
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

        private static void EditTest(Student[] students)
        {
            Console.Write("Nhap ma sinh vien muon xoa: ");
            string msv = Console.ReadLine();
            var studen = CheckStudent(students, msv);
            if (studen != null)
            {
                Console.Write("Nhap so diem TB can thay doi: ");
                double edit = double.Parse(Console.ReadLine());
                studen.TEST = edit;
                Console.WriteLine("Diem TB da duoc thay doi !");
            }
            else
            {
                Console.WriteLine("Ma sinh vien khong hop le !");
            }
        }

        class Information
        {
            public string CITY { get; set; }
            public int AMOUNT { get; set; }
        }

        private static void Status(Student[] students)
        {
            bool CheckCity(string city, Information[] check)
            {
                foreach (var item in check)
                {
                    if (item != null && city.CompareTo(item.CITY) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            int Cout(string city, Student[] student)
            {
                int cout = 0;
                foreach (var item in student)
                {
                    if (item != null && item.CITY.CompareTo(city) == 0)
                    {
                        cout++;
                    }
                }
                return cout;
            }
            Information[] result = new Information[students.Length];
            int size = 0;
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (CheckCity(item.CITY, result))
                    {
                        result[size] = new Information();
                        result[size].CITY = item.CITY;
                        result[size].AMOUNT = Cout(item.CITY, students);
                        size++;
                    }
                }
            }
            var finalResult = new Information[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult,(p1,p2) => p2.AMOUNT - p1.AMOUNT );
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.CITY} + {item.AMOUNT} ");
            }
        }

        private static void DeleteStudentByMsv(Student[] students)
        {
            Console.Write("Nhap ma sinh vien muon xoa: ");
            string msv = Console.ReadLine();
            var student = CheckStudent(students, msv);
            if (student != null)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == student)
                    {
                        students[i] = null;
                        for (int j = i; j < students.Length - 1; j++)
                        {
                            students[j] = students[j + 1];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien !");
            }
        }

        private static void SeachStudentByCity(Student[] students, int index)
        {
            Console.Write("Nhap tinh thanh pho can tim: ");
            string cityName = Console.ReadLine();
            Student[] studentSeach = new Student[index];
            int size = 0;
            foreach (var item in students)
            {
                if (item != null && item.CITY.CompareTo(cityName) == 0)
                {
                    studentSeach[size++] = item;
                }
            }
            Console.WriteLine("Danh sach tim kiem : ");
            ShowStudent(studentSeach);
        }

        public static void SeachStudentByName(Student[] students, int index)
        {
            Console.Write("Nhap ten sinh vien can tim: ");
            string name = Console.ReadLine();
            Student[] studentSeach = new Student[index];
            int size = 0;
            foreach (var item in students)
            {
                if (item != null && item.NAME.CompareTo(name) == 0)
                {
                    studentSeach[size++] = item;
                }
            }
            Console.WriteLine("Danh sach tim kiem : ");
            ShowStudent(studentSeach);
        }

        public static void SortStudentByAll(Student[] students, int index)
        {

            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    var compareName = students[i].NAME.ToLower().CompareTo(students[j].NAME.ToLower());
                    var compareSurName = students[i].SURNAME.ToLower().CompareTo(students[j].SURNAME.ToLower());
                    if (students[i].TEST < students[j].TEST || students[i].TEST == students[j].TEST && compareName > 0 || students[i].TEST == students[j].TEST && compareName == 0 && compareSurName > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }

                }
            }
        }

        public static void SortStudentByName(Student[] students, int index)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    if (students[i].NAME.ToLower().CompareTo(students[j].NAME.ToLower()) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        public static void SortStudentByTest(Student[] students, int index)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    if (students[i].TEST < students[j].TEST)
                    {
                        Swap(ref students[i], ref students[j]);
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

        public static void ShowStudent(Student[] students)
        {
            var titleMSV = "MSV";
            var titleName = "Ho Ten";
            var titleCity = "Thanh Pho";
            var titleTest = "Diem TB";
            var titleMajor = "Chuyen Nganh";
            Console.WriteLine($"{titleMSV,-15}{titleName,-20}{titleCity,-15}{titleTest,-15}{titleMajor,-15}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.MSV,-15}{item.NAME,-20}{item.CITY,-15}{item.TEST,-15}{item.MAJOR,-15}");
                }
                else
                {
                    break;
                }
            }
        }

        public static Student CheckStudent(Student[] students, string msv)
        {
            foreach (var item in students)
            {
                if (item != null && item.MSV == msv)
                {
                    return item;
                }
            }
            return null;
        }

        public static Student CreateStudent()
        {
            Console.Write("Nhap ma sinh vien: ");
            string msv = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            var name = Console.ReadLine().Split(' ');
            Console.Write("Nhap tinh thanh pho: ");
            string city = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            double test = double.Parse(Console.ReadLine());
            Console.Write("Nhap chuyen nganh hoc: ");
            string major = Console.ReadLine();
            return new Student(msv, name[0], name[1], name[2], city, test, major);
        }
    }
    */
    #endregion
}
