using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP;
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
#endregion Bai 1

