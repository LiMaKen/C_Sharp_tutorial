using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.StaffAll
{
    partial class Staff
    {
        public Staff(string id , string name , int phone , string role, long salary , int date , long sumSalary)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Role = role;
            Salary = salary;
            Date = date;
            SumSalary = sumSalary;
        }

        private static int AmountId = 1000;
        private string _id;
        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + AmountId++;
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
        public long SumSalary { get; set; }

        public partial void CheckIn(string time);
        public partial void CheckOut(string time);
        public partial void DoWork(string work);
        public partial long SumWage();
    }
    partial class Staff
    {
        public partial void CheckIn(string time)
        {
            Console.WriteLine($"Nhan vien {Name} checkin luc: {time}");
        }
        public partial void CheckOut(string time)
        {
            Console.WriteLine($"Nhan vien {Name} checkout luc: {time}");
        }
        public partial void DoWork(string work)
        {
            Console.WriteLine($"Nhan vien {Name} đang lam: {work}");
        }
        public partial long SumWage()
        {
            double bonus = Salary * 0.2;
            double date = (double) Date / 22;
            return (long)((Date >= 22) ? Salary * date + bonus : Salary * date);
        }
    }
}
