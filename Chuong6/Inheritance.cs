using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chuong6
{
    class Staff
    {
        private static int _amount = 1000;

        public string ID { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public long Salary { get; set; }
        public int WorkingDay { get; set; }
        public long RealSalary { get; set; } = 0;

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
            var salaryReal = (long)(salary + bonus);
            return salaryReal;
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
            var salaryReal = (long)(salary + Bonus * salary);
            return salaryReal;
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
            var salaryReal = (long)(salary + (salary * 0.15 + Bonus * profit));
            return salaryReal;
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
            Console.WriteLine("Nhap chuc vu cua ban: ");
            string role = Console.ReadLine();
            Console.WriteLine("Nhap he so thuong : ");
            double bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian vao cty: ");
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
            foreach (var item in staffs)
            {
                if (item != null)
                {
                    item.RealSalary = item.SumSalary(100000000);
                }
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
                        }
                        else
                        {
                            Console.WriteLine("Trong");
                        }
                        break;
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
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
}
