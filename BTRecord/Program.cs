using System.Text;
using System;
#region Bai 1
/*
public class Run
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Student[] students = new Student[100];
        int x;
        int index = 0;
        do
        {
            Console.WriteLine("1) Thêm mới một record vào mảng.\r\n" +
           "2) Hiển thị danh sách các record ra màn hình.\r\n" +
           "3) Sắp xếp các record theo thứ tự điểm giảm dần.\r\n" +
           "4) Tìm record theo chuyên ngành.\r\n" +
           "5) Xóa record khỏi mảng.\r\n" +
           "6) Kết thúc chương trình.");
            Console.Write("Nhap lua chon cua ban : ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    students[index++] = CreateStudent();
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
                        SortStudentByTest(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        SeachStudentByMajor(students);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        DeleteSudent(students, ref index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 6:
                    Console.WriteLine("Tam biet !");
                    break;
                default:
                    Console.WriteLine("Sai lua chon !");
                    break;
            }
        } while (x != 6);
    }

    public static Student CreateStudent()
    {
        Console.Write("Nhap vao ma sinh vien: ");
        string id = Console.ReadLine();
        Console.Write("Nhap vao ho va ten: ");
        string name = Console.ReadLine();
        Console.Write("Nhap vao diem trung binh: ");
        double test = double.Parse(Console.ReadLine());
        Console.Write("nhap vao chuyen nganh: ");
        string major = Console.ReadLine();
        return new Student(id, name, test, major);
    }

    public static void ShowStudent(Student[] students)
    {
        var titleMSV = "MSV";
        var titleName = "Ho Ten";
        var titleTest = "Diem TB";
        var titleMajor = "Chuyen Nganh";
        Console.WriteLine($"{titleMSV,-15}{titleName,-20}{titleTest,-15}{titleMajor,-15}");
        foreach (var item in students)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.id,-15}{item.name,-20}{item.test,-15}{item.major,-15}");
            }
        }
    }

    public static void SortStudentByTest(Student[] students , int size)
    {
        int Compare(Student s1, Student s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            if (s1.test - s2.test != 0)
            {
                if (s2.test - s1.test > 0)
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
            for (int j = size - 1 ; j > i ; j--)
            {
                if (Compare(students[j-1], students[j]) > 0)
                {
                    Swap(ref students[j - 1], ref students[j]);
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

    public static void SeachStudentByMajor(Student[] students)
    {
        Console.Write("Nhap chuyen nganh can tim: ");
        string major = Console.ReadLine();
        var seachMajor = new Student[students.Length];
        int index = 0;
        foreach (var item in students)
        {
            if (item != null & item.major.CompareTo(major) == 0)
            {
                seachMajor[index++] = item;
            }
        }
        ShowStudent(seachMajor);
    }

    public static void DeleteSudent(Student[] students, ref int index)
    {
        Console.Write("Nhap ma sinh vien can xoa: ");
        string id = Console.ReadLine();
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null && students[i].id.CompareTo(id) == 0)
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
}
public record Student(string id, string name, double test, string major);
*/
#endregion
#region Bai 2
/*
public class Run
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Student[] students = new Student[100];
        int x;
        int index = 0;
        do
        {
            Console.WriteLine("1) Thêm mới một record vào mảng.\r\n" +
           "2) Hiển thị danh sách các record ra màn hình.\r\n" +
           "3) Sắp xếp các record theo thứ tự điểm giảm dần.\r\n" +
           "4) Tìm record theo chuyên ngành.\r\n" +
           "5) Xóa record khỏi mảng.\r\n" +
           "6) Kết thúc chương trình.");
            Console.Write("Nhap lua chon cua ban : ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    students[index++] = CreateStudent();
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
                        SortStudentByTest(students, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        SeachStudentByMajor(students);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        DeleteSudent(students, ref index);
                    }
                    else
                    {
                        Console.WriteLine("Trong!");
                    }
                    break;
                case 6:
                    Console.WriteLine("Tam biet !");
                    break;
                default:
                    Console.WriteLine("Sai lua chon !");
                    break;
            }
        } while (x != 6);
    }

    public static Student CreateStudent()
    {
        Console.Write("Nhap vao ma sinh vien: ");
        string id = Console.ReadLine();
        Console.Write("Nhap vao ho va ten: ");
        string name = Console.ReadLine();
        Console.Write("Nhap vao diem trung binh: ");
        double test = double.Parse(Console.ReadLine());
        Console.Write("nhap vao chuyen nganh: ");
        string major = Console.ReadLine();
        return new Student
        {
            Id = id,
            Name = name,
            Test = test,
            Major = major
        };
    }

    public static void ShowStudent(Student[] students)
    {
        var titleMSV = "MSV";
        var titleName = "Ho Ten";
        var titleTest = "Diem TB";
        var titleMajor = "Chuyen Nganh";
        Console.WriteLine($"{titleMSV,-15}{titleName,-20}{titleTest,-15}{titleMajor,-15}");
        foreach (var item in students)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.Id,-15}{item.Name,-20}{item.Test,-15}{item.Major,-15}");
            }
        }
    }

    public static void SortStudentByTest(Student[] students, int size)
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
            for (int j = size - 1; j > i; j--)
            {
                if (Compare(students[j - 1], students[j]) > 0)
                {
                    Swap(ref students[j - 1], ref students[j]);
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

    public static void SeachStudentByMajor(Student[] students)
    {
        Console.Write("Nhap chuyen nganh can tim: ");
        string major = Console.ReadLine();
        var seachMajor = new Student[students.Length];
        int index = 0;
        foreach (var item in students)
        {
            if (item != null & item.Major.CompareTo(major) == 0)
            {
                seachMajor[index++] = item;
            }
        }
        ShowStudent(seachMajor);
    }

    public static void DeleteSudent(Student[] students, ref int index)
    {
        Console.Write("Nhap ma sinh vien can xoa: ");
        string id = Console.ReadLine();
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null && students[i].Id.CompareTo(id) == 0)
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
}
public record Student
{
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public double Test { get; init; } = default!;
    public string Major { get; init; } = default!;
}
*/
#endregion
#region Bai 3
class Run
{
    static void Main()
    {
        Staff[] staffs = new Staff[100];
        int x;
        int index = 0;
        Console.OutputEncoding = Encoding.UTF8;
        do
        {
            Console.WriteLine("1) Thêm mới một record vào mảng.\r\n" +
           "2) Hiển thị danh sách các record ra màn hình.\r\n" +
           "3) Sắp xếp các record theo thứ tự mức lương giảm dần.\r\n" +
           "4) Sắp xếp các record theo thứ tự mức phạt giảm dần.\r\n" +
           "5) Sắp xếp các record theo thứ tự lương thực lĩnh giảm dần.\r\n" +
           "6) Tìm record theo mã nhân viên.\r\n" +
           "7) Xóa record khỏi mảng.\r\n" +
           "8) Kết thúc chương trình.");
            Console.WriteLine("Nhap vao lua chon cua ban: ");
            x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    var staff = CreateStaff();
                    staffs[index++] = staff;
                    Console.WriteLine("Tao nhan vien thanh cong !");
                    break;
                case 2:
                    if (index > 0)
                    {
                        ShowStaff(staffs);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 3:
                    if (index > 0)
                    {
                        SortStaffBySalary(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 4:
                    if (index > 0)
                    {
                        SortStaffByFine(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 5:
                    if (index > 0)
                    {
                        SortStaffByRealSalary(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 6:
                    if (index > 0)
                    {
                        SeachStaff(staffs, index);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 7:
                    if (index > 0)
                    {
                        DeleteStaff(staffs,ref index);
                    }
                    else
                    {
                        Console.WriteLine("Trong !");
                    }
                    break;
                case 8:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Sai lua chon !");
                    break;
            }
        } while (x != 8);
    }

    private static void DeleteStaff(Staff[] staffs, ref int index)
    {
        Console.Write("Nhap vao ma nhan vien can xoa: ");
        string id = Console.ReadLine()!;
        bool delete()
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i].Id.CompareTo(id) == 0)
                {
                    for (int j = i; j < staffs.Length - 1; j++)
                    {
                        staffs[j] = staffs[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }
        if (delete())
        {
            Console.WriteLine("Nhan vien da duoc xoa !");
            index--;
        }
        else
        {
            Console.WriteLine("Khong tim thay nhan vien !");
        }
        
    }

    private static void SeachStaff(Staff[] staffs, int index)
    {
        Console.Write("Nhap vao ma nhan vien can tim: ");
        string id = Console.ReadLine()!;
        var seachStaff = new Staff[index];
        int size = 0;
        for (int i = 0; i < staffs.Length; i++)
        {
            if (staffs[i] != null && staffs[i].Id.CompareTo(id) == 0)
            {
                seachStaff[size++] = staffs[i];
            }
        }
        if (size == 0)
        {
            Console.WriteLine("Khong tim thay nhan vien!");
        }
        else
        {
            ShowStaff(seachStaff);
        }
    }

    private static void SortStaffByRealSalary(Staff[] staffs, int index)
    {
        for (int i = 0; i < staffs.Length; i++)
        {
            for (int j = index - 1; j > i; j--)
            {
                if (staffs[j - 1].RealSalary < staffs[j].RealSalary)
                {
                    Swap(ref staffs[j - 1], ref staffs[j]);
                }
            }
        }
    }

    private static void SortStaffByFine(Staff[] staffs, int index)
    {
        for (int i = 0; i < staffs.Length; i++)
        {
            for (int j = index - 1; j > i; j--)
            {
                if (staffs[j - 1].Fine < staffs[j].Fine)
                {
                    Swap(ref staffs[j - 1], ref staffs[j]);
                }
            }
        }
    }

    private static void SortStaffBySalary(Staff[] staffs, int index)
    {
        for (int i = 0; i < staffs.Length; i++)
        {
            for (int j = index - 1; j > i; j--)
            {
                if (staffs[j - 1].Salary < staffs[j].Salary)
                {
                    Swap(ref staffs[j - 1], ref staffs[j]);
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

    private static void ShowStaff(Staff[] staffs)
    {
        var titleId = "Mã NV";
        var titleName = "Họ và tên";
        var titleWorkingDay = "Số ngày LV";
        var titleSalary = "Lương";
        var titleLate = "Đi làm muộn";
        var titleFine = "Tiền phạt";
        var titleReSalary = "Lương thực lĩnh";

        Console.WriteLine($"{titleId,-12:d}{titleName,-25:d}{titleWorkingDay,-12:d}" +
            $"{titleSalary,-12:d}{titleLate,-15:d}{titleFine,-12:d}{titleReSalary,-12:d}");
        foreach (var item in staffs)
        {
            if (item != null)
            {
                Console.WriteLine($"{item.Id,-12:d}{item.Name,-25:d}" +
                    $"{Math.Round(item.WorkDay, 2) + "",-12:d}" +
                    $"{Math.Round(item.Salary, 2) + "",-12:d}{item.LateDay,-15:d}" +
                    $"{Math.Round(item.Fine, 2) + "",-12:d}{Math.Round(item.RealSalary, 2) + "",-12:d}");
            }
        }
    }

    private static Staff CreateStaff()
    {
        Console.WriteLine("Nhap vao ma nhan vien: ");
        var id = Console.ReadLine();
        Console.WriteLine("Nhap vao ho va ten: ");
        var name = Console.ReadLine();
        Console.WriteLine("Nhap vao so ngay di lam: ");
        float workDay = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap vao luong cung : ");
        float salary = long.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap vao so ngay di muon : ");
        int lateDay = int.Parse(Console.ReadLine()!);
        return new Staff(id!, name!, workDay, salary, lateDay);
    }
}
public record Staff(string Id, string Name, float WorkDay, float Salary, int LateDay)
{
    public float Fine => 50000 * LateDay; // tiền phạt
    public float TempSalary => Salary * WorkDay / 22; // lương tạm tính
    public float RealSalary => TempSalary - Fine; // lương thực tế
}
#endregion