using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
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
}
