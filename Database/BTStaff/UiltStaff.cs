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
            throw new NotImplementedException();
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
    }
}
