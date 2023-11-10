using Chuong6.StudentAll;
using Chuong6.StudentOutIn;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP;
#region Bai 1
/*
class Staff
{
    private static int _amount = 1000;
    private FullName _fullName ;

    public string ID { get; set; }
    public string FullName { 
        get => _fullName.ToString();
        set => _fullName = new FullName(value);}
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

class FullName
{
    public string FristName { get; set; } = "";
    public string MidName { get; set; } = "";
    public string LastName { get; set; } = "";

    public FullName()
    {

    }
    public FullName(string name)
    {
        SetFullName(name);
    }

    private void SetFullName(string name)
    {
        var data = name.Split(' ');
        FristName = data[0];
        LastName = data[data.Length -1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.TrimEnd();
    }

    public override string ToString() => $"{FristName} {MidName} {LastName}";
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
        return new Director(staff.ID, staff.FullName, staff.Phone, staff.Salary, staff.WorkingDay, role, time, bonus);
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
        string id = Console.ReadLine();
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
class Uitl
{
    internal static Student CreateStudent()
    {
        Console.Write("Nhap vao ten cua ban: ");
        string name = Console.ReadLine();
        Console.Write("nhap vao chuyen nganh cua ban: ");
        string major = Console.ReadLine();
        return new Student(null, name, major);
    }

    internal static Subject CreateSubject()
    {
        Console.Write("Nhap ten mon hoc: ");
        string subjectName = Console.ReadLine();
        Console.Write("Nhap so tin chi : ");
        int numberOfCredit = int.Parse(Console.ReadLine());
        Console.Write("Nhap so tiet hoc: ");
        int numberOfLessons = int.Parse(Console.ReadLine());
        return new Subject(0, subjectName, numberOfCredit, numberOfLessons);
    }
    private static Student GetStudent(Student[] students, string id)
    {
        foreach (var item in students)
        {
            if (item != null && item.Id.CompareTo(id) == 0)
            {
                return item;
            }
        }
        return null;
    }
    private static Subject GetSubject(Subject[] subjects, int idSubject)
    {
        foreach (var item in subjects)
        {
            if (item != null && item.SubjectId == idSubject)
            {
                return item;
            }
        }
        return null;
    }

    internal static Register CreateRegister(Register[] registers, Student[] students, Subject[] subjects)
    {
        Console.Write("Nhap vao ma sinh vien : ");
        string id = Console.ReadLine();
        var student = GetStudent(students, id);
        if (student != null)
        {
            Console.Write("Nhap vao ma mon hoc can dang ky: ");
            int idSubject = int.Parse(Console.ReadLine());
            var subject = GetSubject(subjects, idSubject);
            if (subject != null)
            {
                if (student.CheckRegister <= 8)
                {
                    if (!CheckSubject(registers, student, subject))
                    {
                        student.CheckRegister++;
                        return new Register(0, student, subject, DateTime.Now);
                    }
                    else
                    {
                        Console.WriteLine("Mon hoc da ton tai !");
                    }
                }
                else
                {
                    Console.WriteLine("So mon hoc da vuot qua 8 !");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay mon hoc !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien !");
        }
        return null;
    }

    private static bool CheckSubject(Register[] registers, Student student, Subject subject)
    {
        foreach (var item in registers)
        {
            if (item != null && student.Equals(item.Student) && subject.Equals(item.Subject))
            {
                return true;
            }
        }
        return false;
    }

    internal static void ShowStudent(Student[] students)
    {
        var titleId = "MSV";
        var titleFullName = "Ho Va Ten";
        var titleMajor = "Chuyen Nganh";
        var titleSubject = "So Mon Hoc Da DK";
        Console.WriteLine($"{titleId,-15}{titleFullName,-15}{titleMajor,-15}{titleSubject,-15}");
        foreach (var item in students)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.Id,-15}{item.FullName,-15}{item.Major,-15}{item.CheckRegister,-15}");
            }
        }
    }

    internal static void ShowSubject(Subject[] subjects)
    {
        var titleId = "Ma Dang Ky";
        var titleName = "Ten HP";
        var titleNumberC = "So Tin Chi";
        var titleNumberL = "So Tiet Hoc";
        Console.WriteLine($"{titleId,-15}{titleName,-15}{titleNumberC,-15}{titleNumberL,-15}");
        foreach (var item in subjects)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.SubjectId,-15}{item.SubjectName,-15}{item.NumberOfCredits,-15}{item.NumberOfLessons,-15}");
            }
        }
    }

    internal static void ShowRegister(Register[] registers)
    {
        var formatter = "HH:mm:ss dd/MM/yyyy";
        var titleId = "Ma Dang Ky";
        var titleIdStudent = "MSV";
        var titleNameStudent = "Ho Ten SV";
        var titleIdSubject = "Ma HP";
        var titleNameSubject = "Ten HP";
        var titleTimeRegister = "Thoi Gian Dang Ky";
        Console.WriteLine($"{titleId,-15}{titleIdStudent,-15}{titleNameStudent,-15}{titleIdSubject,-15}{titleNameSubject,-15}{titleTimeRegister,-15}");
        foreach (var item in registers)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.RegisterId,-15}{item.Student.Id,-15}{item.Student.FullName,-15}{item.Subject.SubjectId,-15}{item.Subject.SubjectName,-15}{item.RegisterTime.ToString(formatter),-15}");
            }
        }
    }

    internal static void SortStudentByName(Student[] students)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.FullName.LastName.CompareTo(s2.FullName.LastName) != 0)
            {
                if (s1.FullName.LastName.CompareTo(s2.FullName.LastName) > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return s1.FullName.FirstName.CompareTo(s2.FullName.FirstName);
        }
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (Compare(students[i], students[j]) > 0)
                {
                    var tmp = students[i];
                    students[i] = students[j];
                    students[j] = tmp;
                }
            }
        }
    }

    internal static void SortSubjectByNumberCredit(Subject[] subjects)
    {
        int Compare(Subject s1, Subject s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.NumberOfCredits - s2.NumberOfCredits != 0)
            {
                if (s2.NumberOfCredits - s1.NumberOfCredits > 0)
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
        for (int i = 0; i < subjects.Length; i++)
        {
            for (int j = i + 1; j < subjects.Length; j++)
            {
                if (Compare(subjects[i], subjects[j]) > 0)
                {
                    var tmp = subjects[i];
                    subjects[i] = subjects[j];
                    subjects[j] = tmp;
                }
            }
        }
    }

    internal static void SortRegisterByTime(Register[] registers)
    {
        int Compare(Register s1, Register s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.RegisterTime.CompareTo(s2.RegisterTime) != 0)
            {
                if (s1.RegisterTime.CompareTo(s2.RegisterTime) > 0)
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
        for (int i = 0; i < registers.Length; i++)
        {
            for (int j = i + 1; j < registers.Length; j++)
            {
                if (Compare(registers[i], registers[j]) > 0)
                {
                    var tmp = registers[i];
                    registers[i] = registers[j];
                    registers[j] = tmp;
                }
            }
        }
    }

    internal static void SortRegisterByIdSutdent(Register[] registers)
    {
        int Compare(Register s1, Register s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.Student.Id.CompareTo(s2.Student.Id) != 0)
            {
                if (s1.Student.Id.CompareTo(s2.Student.Id) > 0)
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
        for (int i = 0; i < registers.Length; i++)
        {
            for (int j = i + 1; j < registers.Length; j++)
            {
                if (Compare(registers[i], registers[j]) > 0)
                {
                    var tmp = registers[i];
                    registers[i] = registers[j];
                    registers[j] = tmp;
                }
            }
        }
    }

    internal static void SortRegisterByIdSubject(Register[] registers)
    {
        int Compare(Register s1, Register s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.Subject.SubjectId.CompareTo(s2.Subject.SubjectId) != 0)
            {
                if (s1.Subject.SubjectId.CompareTo(s2.Subject.SubjectId) > 0)
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
        for (int i = 0; i < registers.Length; i++)
        {
            for (int j = i + 1; j < registers.Length; j++)
            {
                if (Compare(registers[i], registers[j]) > 0)
                {
                    var tmp = registers[i];
                    registers[i] = registers[j];
                    registers[j] = tmp;
                }
            }
        }
    }

    internal static void SeachByIdSubject(Register[] registers, Subject[] subjects)
    {
        Console.Write("Nhap ma mon hoc can tim kiem: ");
        int idSubject = int.Parse(Console.ReadLine());
        var subject = GetSubject(subjects, idSubject);
        var seachRegister = new Register[registers.Length];
        var index = 0;
        if (subject != null)
        {
            foreach (var item in registers)
            {
                if (item != null && item.Equals(subject))
                {
                    seachRegister[index++] = item;

                }
            }
            if (index > 0)
            {
                ShowRegister(seachRegister);
            }
            else
            {
                Console.WriteLine("Mon hoc nay khong duoc sinh vien nao dang ky !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay ma mon hoc !");
        }
    }

    internal static void SeachByIdSutdent(Register[] registers, Student[] students)
    {
        Console.Write("Nhap vao ma sinh vien can tim kiem: ");
        string id = Console.ReadLine();
        var student = GetStudent(students, id);
        var seachRegister = new Register[registers.Length];
        var index = 0;
        if (student != null)
        {
            foreach (var item in registers)
            {
                if (item != null && item.Equals(student))
                {
                    seachRegister[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowRegister(seachRegister);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien co ma nay !");
        }
    }

    internal static void EditNameStudent(Student[] students)
    {
        Console.WriteLine("Nhap ma sinh vien can sua: ");
        string id = Console.ReadLine();
        var student = GetStudent(students, id);
        if (student != null)
        {
            Console.WriteLine("Nhap ten muon thay doi: ");
            string name = Console.ReadLine();
            student.FullName = new FullName(name);
            Console.WriteLine("Thay doi thanh cong !");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien !");
        }
    }

    internal static void EditLessonsSubject(Subject[] subjects)
    {
        Console.WriteLine("Nhap ma hoc phan can sua : ");
        int id = int.Parse(Console.ReadLine());
        var subject = GetSubject(subjects, id);
        if (subject != null)
        {
            Console.WriteLine("Nhap so tiet hoc can sua : ");
            int lessons = int.Parse(Console.ReadLine());
            subject.NumberOfLessons = lessons;
            Console.WriteLine("Sua thanh cong !");
        }
        else
        {
            Console.WriteLine("Khong tim thay hoc phan !");
        }
    }

    internal static void DeleteSubject(Subject[] subjects, ref int index)
    {
        Console.WriteLine("Nhap vao ma mon hoc can xoa : ");
        int id = int.Parse(Console.ReadLine());
        var subject = GetSubject(subjects, id);
        if (subject != null)
        {
            bool Delete()
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    if (subjects[i] != null && subjects[i].Equals(subject))
                    {
                        subjects[i] = null;
                        for (int j = i; j < subjects.Length - 1; j++)
                        {
                            subjects[j] = subjects[j + 1];
                        }
                        return true;
                    }
                }
                return false;
            }
            if (Delete())
            {
                index--;
                Console.WriteLine("Da xoa thanh cong !");
            }
            else
            {
                Console.WriteLine("Xoa that bai !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay mon hoc !");
        }
    }

    internal static void DeleteStudent(Student[] students, ref int indexStudent)
    {
        Console.WriteLine("Nhap ma sinh vien can xoa : ");
        string id = Console.ReadLine();
        var student = GetStudent(students, id);
        if (student != null)
        {
            bool Delete()
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null && students[i].Equals(student))
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
            if (Delete())
            {
                Console.WriteLine("Xoa thanh cong !");
                indexStudent--;
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien !");
        }
    }

    internal static void DeleteRegister(Register[] registers, ref int indexRegister)
    {
        Console.WriteLine("Nhap ma dang ky can xoa : ");
        int id = int.Parse(Console.ReadLine());
            bool Delete()
            {
                for (int i = 0; i < registers.Length; i++)
                {
                    if (registers[i] != null && registers[i].RegisterId == id)
                    {
                    registers[i] = null;
                        for (int j = i; j < registers.Length - 1; j++)
                        {
                        registers[j] = registers[j + 1];
                        }
                        return true;
                    }
                }
                return false;
            }
            if (Delete())
            {
                Console.WriteLine("Xoa thanh cong !");
            indexRegister--;
            }
        else
        {
            Console.WriteLine("Xoa that bai");
        }
        
    }
}
class Run
{
    static void Main()
    {
        var formatter = "HH:mm:ss dd/MM/yyyy";
        Console.OutputEncoding = Encoding.UTF8;
        const int Max = 100;
        Student[] students = new Student[Max];
        Subject[] subjects = new Subject[]
        {
            new Subject(1,"Toan",2,2),
            new Subject(2,"Anh",4,2),
            new Subject(3,"Van",8,2),
            new Subject(4,"Ly",1,2),
            new Subject(5,"Hoa",6,2),
            new Subject(6,"TD",8,2),
            new Subject(7,"QP",2,2),
            new Subject(8,"Alo",4,2),
            new Subject(9,"Al32o",10,2),
        };
        Register[] registers = new Register[Max];
        int indexStudent = 0;
        int indexSubject = 0;
        int indexRegister = 0;
        int x;
        do
        {
            Console.WriteLine("" +
           "1) Thêm mới sinh viên vào danh sách sinh viên.\r\n" +
           "2) Thêm mới môn học vào danh sách môn học.\r\n" +
           "3) Thêm mới bản đăng ký môn học cho sinh viên bằng cách nhập mã sinh viên và mã môn\r\nhọc cần đăng ký. Mỗi sinh viên với 1 môn học không được xuất hiện quá 1 lần trong danh\r\nsách bản đăng ký. Mỗi sinh viên chỉ được đăng ký không quá 8 môn học.\r\n" +
           "4) Hiển thị danh sách sinh viên ra màn hình dạng bảng gồm các hàng, cột ngay ngắn.\r\n" +
           "5) Hiển thị danh sách môn học ra màn hình dạng bảng gồm các hàng, cột ngay ngắn.\r\n" +
           "6) Hiển thị danh sách đăng ký môn học ra màn hình dạng bảng gồm các hàng cột ngay ngắn.\r\n" +
           "Thông tin hiển thị bao gồm: mã đăng ký, mã sinh viên, họ tên sinh viên, mã môn, tên môn,\r\n" +
           "thời gian đăng ký.\r\n" +
           "7) Sắp xếp danh sách sinh viên theo tên a-z. Nếu tên trùng nhau thì sắp xếp theo họ a-z.\r\n" +
           "8) Sắp xếp danh sách môn học theo số tín chỉ giảm dần.\r\n" +
           "9) Sắp xếp danh sách đăng ký môn học theo thời gian đăng ký từ sớm nhất đến muộn nhất.\r\n" +
           "10) Sắp xếp danh sách đăng ký môn học theo mã sinh viên tăng dần.\r\n" +
           "11) Sắp xếp danh sách đăng ký môn học theo mã môn học tăng dần.\r\n" +
           "12) Tìm danh sách đăng ký theo mã môn học.\r\n" +
           "13) Tìm danh sách đăng ký theo mã sinh viên.\r\n" +
           "14) Sửa thông tin tên sinh viên theo mã sinh viên cho trước.\r\n" +
           "15) Sửa thông tin số tiết học theo mã môn học cho trước.\r\n" +
           "16) Xóa môn học khỏi danh sách môn học theo mã môn học.\r\n" +
           "17) Xóa sinh viên khỏi danh sách sinh viên theo mã sinh viên.\r\n" +
           "18) Xóa bản đăng ký theo mã đăng ký.\r\n" +
           "19) Thoát chương trình.");
            Console.Write("Nhap lua chon cua ban: ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    var student = Uitl.CreateStudent();
                    students[indexStudent++] = student;
                    Console.WriteLine($"Them sinh vien thanh cong. MSV cua ban la: {student.Id}");
                    break;
                case 2:
                    var subject = Uitl.CreateSubject();
                    subjects[indexSubject++] = subject;
                    Console.WriteLine($"Them mon hoc thanh cong . Ma mon hoc la: {subject.SubjectId}");
                    break;
                case 3:
                    var register = Uitl.CreateRegister(registers, students, subjects);
                    if (register != null)
                    {
                        registers[indexRegister++] = register;
                        Console.WriteLine($"Dang ky thanh cong. Ma dang ky la: {register.RegisterId} : {register.RegisterTime.ToString(formatter)}");
                    }
                    else
                    {
                        Console.WriteLine("Dang ky khong thanh cong !");
                    }
                    break;
                case 4:
                    if (indexStudent > 0)
                    {
                        Uitl.ShowStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien dang trong!");
                    }
                    break;
                case 5:
                    if (indexSubject > 0)
                    {
                        Uitl.ShowSubject(subjects);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach mon hoc dang trong!");
                    }
                    break;
                case 6:
                    if (indexRegister > 0)
                    {
                        Uitl.ShowRegister(registers);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 7:
                    if (indexStudent > 0)
                    {
                        Uitl.SortStudentByName(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien dang trong!");
                    }
                    break;
                case 8:
                    if (indexSubject > 0)
                    {
                        Uitl.SortSubjectByNumberCredit(subjects);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach mon hoc dang trong!");
                    }
                    break;
                case 9:
                    if (indexRegister > 0)
                    {
                        Uitl.SortRegisterByTime(registers);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 10:
                    if (indexRegister > 0)
                    {
                        Uitl.SortRegisterByIdSutdent(registers);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 11:
                    if (indexRegister > 0)
                    {
                        Uitl.SortRegisterByIdSubject(registers);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 12:
                    if (indexRegister > 0)
                    {
                        Uitl.SeachByIdSubject(registers, subjects);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 13:
                    if (indexRegister > 0)
                    {
                        Uitl.SeachByIdSutdent(registers, students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 14:
                    if (indexStudent > 0)
                    {
                        Uitl.EditNameStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien dang trong!");
                    }
                    break;
                case 15:
                    if (indexSubject > 0)
                    {
                        Uitl.EditLessonsSubject(subjects);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach mon hoc dang trong!");
                    }
                    break;
                case 16:
                    if (indexSubject > 0)
                    {
                        Uitl.DeleteSubject(subjects, ref indexSubject);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach mon hoc dang trong!");
                    }
                    break;
                case 17:
                    if (indexStudent > 0)
                    {
                        Uitl.DeleteStudent(students, ref indexStudent);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien dang trong!");
                    }
                    break;
                case 18:
                    if (indexRegister > 0)
                    {
                        Uitl.DeleteRegister(registers, ref indexRegister);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach hoc phan dang ky dang trong!");
                    }
                    break;
                case 19:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Sai lua chon!");
                    break;
            }
        } while (x != 19);
    }
}
*/
#endregion
#region Bai 3
class Uitl
{
    internal static Student CreateStudent()
    {
        Console.Write("Nhap vao  ho ten cua ban: ");
        string name = Console.ReadLine();
        Console.Write("Nhap vao tuoi cua ban: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao dia chi cua ban: ");
        string addRess = Console.ReadLine();
        Console.Write("Nhap vao chuyen nganh cua ban: ");
        string major = Console.ReadLine();
        return new Student(null, name, age, addRess, major);
    }

    internal static Subject CreateSubject()
    {
        Subject subject = new Subject();
        Console.Write("Nhap vao ten mon hoc : ");
        subject.SubjectName = Console.ReadLine();
        Console.Write("Nhap vao so tin chi: ");
        subject.NumberOfCredit = int.Parse(Console.ReadLine());
        return subject;
    }

    internal static Course CreateCourses(Subject[] subjects)
    {
        Console.Write("Nhap vao ma mon hoc can mo lop: ");
        int subjectId = int.Parse(Console.ReadLine());
        var subject = GetSubject(subjects, subjectId);
        if (subject != null)
        {
            Console.Write("Nhap vao so luong sinh vien: ");
            int numberOfStudent = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao ten giao vien: ");
            string teacher = Console.ReadLine();
            return new Course(subject, teacher, numberOfStudent);
        }
        else
        {
            Console.WriteLine("Mon hoc nay khong ton tai !");
        }
        return null;
    }

    private static Subject GetSubject(Subject[] subjects, int subjectId)
    {
        foreach (var item in subjects)
        {
            if (item != null && subjectId.CompareTo(item.SubjectId) == 0)
            {
                return item;
            }
        }
        return null;
    }

    internal static void CreateTranScript(Course[] courses, Student[] students)
    {
        Console.WriteLine("Nhap vao ma lop hoc: ");
        int courseId = int.Parse(Console.ReadLine());
        var course = GetCourse(courses, courseId);
        if (course != null)
        {
            Console.WriteLine("Nhap vao ma sinh vien : ");
            string studentId = Console.ReadLine();
            var student = GetStudent(students, studentId);
            if (student != null)
            {
                if (course.NumberOfTranscript < course.NumberOfStudent)
                {
                    if (!CheckStudentInCourse(course, student))
                    {
                        Console.WriteLine("Nhap diem he 1: ");
                        float test1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem he 2 : ");
                        float test2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem he 3: ");
                        float test3 = float.Parse(Console.ReadLine());
                        var tranScript = new TranScript(student, test1, test2, test3);
                        tranScript.SumTest();
                        course.TranScript[course.NumberOfTranscript++] = tranScript;
                    }
                    else
                    {
                        Console.WriteLine("Sinh vien nay da co bang diem mon hoc nay !");
                    }
                }
                else
                {
                    Console.WriteLine("Bang diem cua sinh vien da du !");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay khoa hoc !");
        }
    }

    private static bool CheckStudentInCourse(Course course, Student student)
    {
        var tranScript = course.TranScript;
        foreach (var item in tranScript)
        {
            if (item != null && item.Student.Equals(student))
            {
                return true;
            }
        }
        return false;
    }

    private static Student GetStudent(Student[] students, string studentId)
    {
        foreach (var item in students)
        {
            if (item != null && item.Id.CompareTo(studentId) == 0)
            {
                return item;
            }
        }
        return null;
    }

    private static Course GetCourse(Course[] courses, int courseId)
    {
        foreach (var item in courses)
        {
            if (item != null && item.CourseId == courseId)
            {
                return item;
            }
        }
        return null;
    }

    internal static void ShowStudent(Student[] students)
    {
        var titleId = "MSV";
        var titleFullName = "Ho Va Ten";
        var titleAge = "Tuoi";
        var titleMajor = "Chuyen Nganh";
        var titleAddRess = "Dia Chi";
        Console.WriteLine($"{titleId,-15}{titleFullName,-15}{titleAge,-15}{titleMajor,-15}{titleAddRess,-15}");
        foreach (var item in students)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.Id,-15}{item.FullName,-15}{item.Age,-15}{item.Major,-15}{item.AddRess,-15}");
            }
        }
    }

    internal static void ShowSubject(Subject[] subjects)
    {
        var titleId = "Ma Dang Ky";
        var titleName = "Ten HP";
        var titleNumberC = "So Tin Chi";
        Console.WriteLine($"{titleId,-15}{titleName,-15}{titleNumberC,-15}");
        foreach (var item in subjects)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.SubjectId,-15}{item.SubjectName,-15}{item.NumberOfCredit,-15}");
            }
        }
    }

    internal static void ShowCourses(Course[] courses)
    {
        var titleId = "Ma Bang Diem";
        var titleIdStudent = "MSV";
        var titleStudentName = "Ho Ten";
        var titleHe1 = "Diem He 1";
        var titleHe2 = "Diem He 2";
        var titleHe3 = "Diem He 3";
        var titleTb = "Diem TB";
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null)
            {
                Console.WriteLine($"ID lop {courses[i].CourseId} Ten mon hoc: {courses[i].Subject.SubjectName}");
                Console.WriteLine($"{titleId,-15}{titleIdStudent,-15}{titleStudentName,-15}{titleHe1,-15}{titleHe2,-15}{titleHe3,-15}{titleTb,-15}");
                foreach (var item in courses[i].TranScript)
                {
                    if (item != null)
                    {
                        Console.WriteLine($"{item.TranScriptId,-15}{item.Student.Id,-15}{item.Student.FullName,-15}{item.Test1,-15}{item.Test2,-15}{item.Test3,-15}{item.TB,-15}");
                    }
                }
            }
        }
    }

    internal static void SortStudentByName(Student[] students)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            return s1.FullName.LastName.CompareTo(s2.FullName.LastName);
        }
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (Compare(students[i], students[j]) > 0)
                {
                    var tmp = students[i];
                    students[i] = students[j];
                    students[j] = tmp;
                }
            }
        }
    }

    internal static void SeachStudent(Student[] students)
    {
        Console.WriteLine("Nhap vao ma sinh vien can tim: ");
        string id = Console.ReadLine();
        var student = GetStudent(students, id);
        if (student != null)
        {
            Console.WriteLine("Sinh vien can tim la : ");
            Console.WriteLine($"{student.Id} {student.FullName} {student.Age} {student.Major}");
        }
        else
        {
            Console.WriteLine("Khong tim thay ma sinh vien tuong ung!");
        }
    }

    internal static void DeleteStudent(Student[] students)
    {
        Console.WriteLine("Nhap vao ma sinh vien can xoa: ");
        string id = Console.ReadLine();
        bool Delete()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                {
                    students[i] = null;
                    return true;
                }
            }
            return false;
        }
        if (Delete())
        {
            Console.WriteLine("Xoa thanh cong !");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien !");
        }
    }

    internal static void ShortTranScrip(Course[] courses)
    {
        Console.WriteLine("Nhap vao ma lop hoc can sap xep: ");
        int idCourse = int.Parse(Console.ReadLine());
        var course = GetCourse(courses, idCourse);
        if (course != null)
        {
            SortTranScript(course.TranScript);
            Console.WriteLine("Hoc phan da duoc sap xep !");
        }
        else
        {
            Console.WriteLine("Khong tim thay lop hoc !");
        }
    }

    private static void SortTranScript(TranScript[] tranScript)
    {
        int Compare(TranScript s1, TranScript s2)
        {
            if ((s1 == null) || (s2 == null)) return 0;
            if (s1.TB - s2.TB != 0)
            {
                if (s2.TB - s1.TB > 0)
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
        for (int i = 0; i < tranScript.Length; i++)
        {
            if (tranScript[i] != null)
            {
                for (int j = i + 1; j < tranScript.Length; j++)
                {
                    if (Compare(tranScript[i], tranScript[j]) > 0)
                    {
                        var tmp = tranScript[i];
                        tranScript[i] = tranScript[j];
                        tranScript[j] = tmp;
                    }
                }
            }
        }
    }

    internal static void StatStudentHight(Course[] courses)
    {
        int Check(float tb, Information[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null && result[i].NumberGood == tb)
                {
                    return i;
                }
            }
            return -1;
        }
        Information[] result = new Information[courses.Length];
        int size = 0;
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null)
            {
                var tranScript = courses[i].TranScript;
                foreach (var item in tranScript)
                {
                    if (item != null && item.TB >= 8)
                    {
                        var resultCheck = Check(item.TB, result);
                        if (resultCheck != -1)
                        {
                            result[resultCheck].StudentGood++;
                            continue;
                        }
                        else
                        {
                            result[size] = new Information();
                            result[size].NumberGood = item.TB;
                            result[size].StudentGood = 1;
                            size++;
                        }
                    }
                }
            }
        }
        var finalResult = new Information[size];
        Array.Copy(result, finalResult, size);
        Array.Sort(finalResult, (p1, p2) => Convert.ToInt32(p2.NumberGood - p1.NumberGood));
        foreach (var item in finalResult)
        {
            Console.WriteLine($"Co {item.StudentGood} sinh vien dat diem {item.NumberGood}");
        }
    }

    internal static void StatStudentBad(Course[] courses)
    {
        int Check(float tb, Information[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null && result[i].NumberBad == tb)
                {
                    return i;
                }
            }
            return -1;
        }
        Information[] result = new Information[courses.Length];
        int size = 0;
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null)
            {
                var tranScript = courses[i].TranScript;
                foreach (var item in tranScript)
                {
                    if (item != null && item.TB < 4)
                    {
                        var resultCheck = Check(item.TB, result);
                        if (resultCheck != -1)
                        {
                            result[resultCheck].StudentBad++;
                            continue;
                        }
                        else
                        {
                            result[size] = new Information();
                            result[size].NumberBad = item.TB;
                            result[size].StudentBad = 1;
                            size++;
                        }
                    }
                }
            }
        }
        var finalResult = new Information[size];
        Array.Copy(result, finalResult, size);
        Array.Sort(finalResult, (p1, p2) => Convert.ToInt32(p2.NumberBad - p1.NumberBad));
        foreach (var item in finalResult)
        {
            Console.WriteLine($"Co {item.StudentBad} sinh vien truot mon voi so diem:  {item.NumberBad}");
        }
    }

    internal static void EditTest(Course[] courses, Student[] students)
    {
        Console.WriteLine("Nhap lop hoc phan: ");
        int idCourse = int.Parse(Console.ReadLine());
        var course = GetCourse(courses, idCourse);
        if (course != null)
        {
            Console.WriteLine("Nhap vao ma sinh vien can sua diem: ");
            string id = Console.ReadLine();
            var student = GetStudent(students, id);
            if (student != null)
            {
                for (int i = 0; i < course.TranScript.Length; i++)
                {
                    if (course.TranScript[i] != null && student.Equals(course.TranScript[i].Student))
                    {
                        Console.WriteLine("Nhap vao so diem he 1: ");
                        float he1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao so diem he 2: ");
                        float he2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao so diem he 3: ");
                        float he3 = float.Parse(Console.ReadLine());
                        var newTranScript = new TranScript(student, he1, he2, he3);
                        newTranScript.SumTest();
                        course.TranScript[i] = newTranScript;
                        Console.WriteLine("Sua thanh cong !");
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay hoc phan !");
        }
    }

    internal static void SeachStudentByIdCourse(Course[] courses, Student[] students)
    {
        Console.WriteLine("Nhap vao ma lop: ");
        int idCourse = int.Parse(Console.ReadLine());
        var course = GetCourse(courses, idCourse);
        if (course != null)
        {
            Console.WriteLine("Nhap diem >= can tim : ");
            float x = float.Parse(Console.ReadLine());
            var seachStudent = new Student[students.Length];
            int size = 0;
            foreach (var item in course.TranScript)
            {
                if (item != null && item.TB >= x)
                {
                    seachStudent[size++] = item.Student;
                }
            }
            if (size > 0)
            {
                ShowStudent(seachStudent);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao dat diem nhu vay !");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay ma hoc phan !");
        }
    }

    internal static void DeleteTranScript(Course[] courses, Student[] students)
    {
        Console.WriteLine("Nhap ma lop : ");
        int idCourse = int.Parse(Console.ReadLine());
        var course = GetCourse(courses,idCourse);
        if (course != null)
        {
            Console.WriteLine("Nhap vao ma sinh vien can xoa bang diem: ");
            string idStudent = Console.ReadLine();
            var student = GetStudent(students,idStudent);
            bool Delete()
            {
                for (int i = 0; i < course.TranScript.Length; i++)
                {
                    if (course.TranScript[i] != null && course.TranScript[i].Student.Equals(student))
                    {
                        course.TranScript[i] = null;
                        return true;
                    }
                }
                return false;
            }
            if (Delete())
            {
                Console.WriteLine("Xoa thanh cong !");
            }
            else
            {
                Console.WriteLine("Xoa that bai!");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay ma lop hoc !");
        }
    }
}
class Run
{
    /*static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        const int Max = 100;
        Student[] students = new Student[Max];
        Subject[] subjects = new Subject[Max];
        Course[] courses = new Course[Max];
        int studentIndex = 0;
        int subjectIndex = 0;
        int coursesIndex = 0;
        int x;
        do
        {
            Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
          "2) Thêm mới môn học vào danh sách.\r\n" +
          "3) Thêm mới lớp học phần vào danh sách các lớp học phần.\r\n" +
          "4) Nhập bảng điểm cho các sinh viên trong một lớp học phần bằng cách nhập mã lớp, mã\r\nsinh viên và các đầu điểm hệ số 1, 2. 3. Bảng điểm của mỗi sinh viên với 1 môn học chỉ\r\nxuất hiện 1 lần trong danh sách bảng điểm.\r\n" +
          "5) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
          "6) Hiển thị danh sách môn học ra màn hình.\r\n" +
          "7) Hiển thị danh sách bảng điểm của từng lớp học phần\r\n" +
          "8) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
          "9) Tìm sinh viên theo mã sinh viên cho trước.\r\n" +
          "10) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
          "11) Sắp xếp danh sách bảng điểm của một lớp học phần theo thứ tự điểm TB môn giảm dần.\r\n" +
          "12) Liệt kê số lượng sinh viên đạt điểm TB loại giỏi(>= 8.0 ở hệ 10) trong các lớp học phần\r\ntheo thứ tự giảm dần.\r\n" +
          "13) Liệt kê số lượng sinh viên trượt môn trong từng lớp học phần(điểm TB < 4) theo thứ tự\r\nsố lượng sinh viên giảm dần.\r\n" +
          "14) Sửa điểm cho sinh viên theo mã lớp học phần và mã sinh viên.\r\n" +
          "15) Tìm các sinh viên có điểm >= x trong lớp học phần khi biết mã lớp.\r\n" +
          "16) Xóa bảng điểm của sinh viên có mã x trong lớp học phần mã p nào đó.\r\n" +
          "17) Kết thúc chương trình.");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    var student = Uitl.CreateStudent();
                    students[studentIndex++] = student;
                    Console.WriteLine($"Tao sinh vien thanh cong. Ma sinh vien cua ban la {student.Id}");
                    break;
                case 2:
                    var subject = Uitl.CreateSubject();
                    subjects[subjectIndex++] = subject;
                    Console.WriteLine($"Tao mon hoc thanh cong. Ma mon hoc la : {subject.SubjectId}");
                    break;
                case 3:
                    var course = Uitl.CreateCourses(subjects);
                    if (course != null)
                    {
                        courses[coursesIndex++] = course;
                        Console.WriteLine($"Tao lop hoc thanh cong. Ma lop hoc la : {course.CourseId}");
                    }
                    else
                    {
                        Console.WriteLine("Tao lop hoc that bai !");
                    }
                    break;
                case 4:
                    if (coursesIndex > 0)
                    {
                        Uitl.CreateTranScript(courses, students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 5:
                    if (studentIndex > 0)
                    {
                        Uitl.ShowStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien trong!");
                    }
                    break;
                case 6:
                    if (subjectIndex > 0)
                    {
                        Uitl.ShowSubject(subjects);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach mon hoc trong !");
                    }
                    break;
                case 7:
                    if (coursesIndex > 0)
                    {
                        Uitl.ShowCourses(courses);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 8:
                    if (studentIndex > 0)
                    {
                        Uitl.SortStudentByName(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien trong!");
                    }
                    break;
                case 9:
                    if (studentIndex > 0)
                    {
                        Uitl.SeachStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien trong!");
                    }
                    break;
                case 10:
                    if (studentIndex > 0)
                    {
                        Uitl.DeleteStudent(students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach sinh vien trong!");
                    }
                    break;
                case 11:
                    if (coursesIndex > 0)
                    {
                        Uitl.ShortTranScrip(courses);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 12:
                    if (coursesIndex > 0)
                    {
                        Uitl.StatStudentHight(courses);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 13:
                    if (coursesIndex > 0)
                    {
                        Uitl.StatStudentBad(courses);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 14:
                    if (coursesIndex > 0)
                    {
                        Uitl.EditTest(courses, students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 15:
                    if (coursesIndex > 0)
                    {
                        Uitl.SeachStudentByIdCourse(courses, students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 16:
                    if (coursesIndex > 0)
                    {
                        Uitl.DeleteTranScript(courses, students);
                    }
                    else
                    {
                        Console.WriteLine("Danh sach khoa hoc trong !");
                    }
                    break;
                case 17:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Sai lua chon!");
                    break;
            }
        } while (x != 17);
    }
    */
}

#endregion
