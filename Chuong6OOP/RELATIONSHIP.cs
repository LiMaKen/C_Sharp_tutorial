using Chuong6.StudentAll;
using Chuong6.StudentOutIn;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
#endregion
