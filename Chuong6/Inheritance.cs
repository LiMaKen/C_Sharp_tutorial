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
            throw new NotImplementedException();
        }

        private static Staff CreateDirector()
        {
            throw new NotImplementedException();
        }

        private static Staff CreateStaff()
        {
            throw new NotImplementedException();
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
                        }
                        else
                        {
                            Console.WriteLine("Sai lua chon !");
                        }
                        break;
                    case 2:
                        break;
                    case 3:
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
