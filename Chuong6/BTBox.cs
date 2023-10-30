using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
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
}
