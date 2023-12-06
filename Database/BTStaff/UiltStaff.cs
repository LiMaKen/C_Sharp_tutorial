using Database.controller;
using Database.Sql;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Database.BTStaff
{
    internal class UiltStaff
    {
        internal static Staff Create()
        {
            Console.WriteLine("1) Tao nhan vien \n 2) tao quan ly \n 3) tao giam doc");
            Console.WriteLine("Moi ban lua chon: ");
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
            else
            {
                Console.WriteLine("Sai lua chon");
            }
            return null;
        }

        internal static void ShowStaff(List<Staff> staffs)
        {
            var titleStaffId = "StaffId";
            var titleFullName = "FullName";
            var titleEmail = "Email";
            var titlePhone = "Phone";
            var titleRole = "Role";
            var titleSalary = "Salary";
            var titleWorkingDay = "WorkingDay";
            var titleRealSalary = "RealSalary";
            var titleBonus = "Bonus";
            var titleTime = "Time";
            var TitleNo = "-";
            Console.WriteLine($"{titleStaffId,15}{titleFullName,20}{titleEmail,20}{titlePhone,15}{titleRole,15}{titleSalary,15}{titleWorkingDay,15}{titleRealSalary,15}{titleBonus,15}{titleTime,15}");
            foreach (var item in staffs)
            {
                if (item is Manager)
                {
                    var manager = (Manager)item;
                    Console.WriteLine($"{manager.StaffId,15}{manager.FullName,20}{manager.Email,20} {manager.Phone,15} {manager.Role,15} {manager.Salary,15} {manager.WorkingDay,15} {manager.RealSalary,15} {manager.Bonus,15} {TitleNo,15}");
                }
                else if (item is Director)
                {
                    var director = (Director)item;
                    Console.WriteLine($"{director.StaffId,15} {director.FullName,20} {director.Email,20} {director.Phone,15} {director.Role,15} {director.Salary,15} {director.WorkingDay,15} {director.RealSalary,15} {director.Bonus,15} {director.Time,15}");
                }
                else
                {
                    Console.WriteLine($"{item.StaffId,15}{item.FullName,20}{item.Email,20}{item.Phone,15}{item.Role,15}{item.Salary,15}{item.WorkingDay,15}{item.RealSalary,15}{TitleNo,15}{TitleNo,15}");
                }
            }
        }
        public static void SortStaffBySalary()
        {
            var staffs = new List<Staff>();
            staffs = StaffData.SelectAllDataBySalary();
            ShowStaff(staffs);
        }
        private static Director CreateDirector()
        {
            Controler controler = new Controler();
            var staff = CreateStaff();
            Console.WriteLine("Nhap vao he so thuong:");
            float bonus = float.Parse(Console.ReadLine());
            if (bonus <= 0)
            {
                Console.WriteLine("He so khong the nho hon 0");
                return null;
            }
            Console.WriteLine("Nhap vao thoi gian nhan chuc: ");
            string date = Console.ReadLine();
            if (!controler.IsBirth(date))
            {
                Console.WriteLine("Ngay thang nam khong hop le!");
                return null;
            }
            return new Director(staff.StaffId, staff.FullName.ToString(), staff.Email, staff.Phone, "Giam doc", staff.Salary, staff.WorkingDay, 0, bonus, date);
        }

        private static Manager CreateManager()
        {
            var staff = CreateStaff();
            Console.WriteLine("nhap vao he so thuong: ");
            float bonus = float.Parse(Console.ReadLine());
            if (bonus <= 0)
            {
                Console.WriteLine("He so khong the nho hon 0");
                return null;
            }
            return new Manager(staff.StaffId, staff.FullName.ToString(), staff.Email, staff.Phone, "Quan ly", staff.Salary, staff.WorkingDay, 0, bonus);
        }

        private static Staff CreateStaff()
        {
            Controler controler = new Controler();
            Console.WriteLine("Nhap vao ho va ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap vao email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Nhap vao so dien thoai: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Nhap vao luong cung: ");
            long salary = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so ngay di lam: ");
            int workingDay = int.Parse(Console.ReadLine());
            if (!controler.IsName(name))
            {
                Console.WriteLine("Ten khong hop le!");
                return null;
            }
            if (!controler.IsEmail(email))
            {
                Console.WriteLine("Email khong hop le!");
                return null;
            }
            if (!controler.IsPhone(phone))
            {
                Console.WriteLine("So dien thoai khong hop le!");
                return null;
            }
            return new Staff(null, name, email, phone, "Nhan vien", salary, workingDay); ;
        }

        internal static void SumSalaryAll()
        {
            var staffs = StaffData.SelectAllData();
            try
            {
                MySqlCommand command = DatabaseConnect.Connection.CreateCommand();

                foreach (var staff in staffs)
                {
                    command.CommandText = "UPDATE staff SET realsalary=@realsalary WHERE staffid=@staffid";
                    command.Parameters.AddWithValue("staffid", staff.StaffId);
                    command.Parameters.AddWithValue("realsalary", staff.SumSalary());
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                Console.WriteLine("UPDATE THANH CONG!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        internal static void SortStaffByWrokingDay()
        {
           
            try
            {
                var staffs = StaffData.SelectByWorkingDay();
                ShowStaff(staffs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal static void SeachStaffByStaffId()
        {
            Console.WriteLine("Nhap vao ma nhan vien can tim:");
            string staffid = Console.ReadLine();
            List<Staff> staffs = StaffData.SeachStaffId(staffid);
            if (staffs.Count == 0)
            {
                Console.WriteLine("Khong tim thay!");
            }
            else
            {
                ShowStaff(staffs);
            }
        }

        internal static void SeachStaffBySalary()
        {
            Console.WriteLine("Nhap vao muc luong can tim:");
            string salary = Console.ReadLine();
            List<Staff> staffs = StaffData.SeachStaffBySalary(salary);
            if (staffs.Count == 0)
            {
                Console.WriteLine("Khong tim thay!");
            }
            else
            {
                ShowStaff(staffs);
            }
        }

        internal static void UpdateSalary()
        {
            Console.WriteLine("Nhap vao ma nhan vien: ");
            string staffid = Console.ReadLine();
            var staff = GetStaff(Run.staffs, staffid);
            if (staff != null)
            {
                Console.WriteLine("Nhap vao muc luong tang: ");
                string salary = Console.ReadLine();
                StaffData.UpdateStaffSalary(staff,salary);
            }
            else
            {
                Console.WriteLine("khong tim thay nhan vien");
            }
        }

        private static Staff GetStaff(List<Staff> staffs, string staffid)
        {
            foreach (var item in staffs)
            {
                if (item != null && item.StaffId == staffid)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void DeleteStaffByStaffId()
        {
            Console.WriteLine("Nhap vao ma nhan vien: ");
            string staffid = Console.ReadLine();
            var staff = GetStaff(Run.staffs, staffid);
            if (staff != null)
            {
                StaffData.DeleteStaff(staff);
            }
            else
            {
                Console.WriteLine("khong tim thay nhan vien");
            }
        }
    }
}
