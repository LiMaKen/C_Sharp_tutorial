using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.StaffOutin
{
    internal partial class Staff
    {
        public Staff()
        {
            ID = null;
        }

        public Staff(string name, int phone, string role, long salary, int date, long sumSalary) : this()
        {
            Name = name;
            Phone[0] = phone;
            Role = role;
            Salary = salary;
            Date = date;
            SumSalary = sumSalary;
        }

        private readonly Fullname _name = new();
        private string _id;
        private static int amount = 1000;

        public int[] Phone { get; set; } = new int[6];
        public string Role { get; set; }
        public long Salary { get; set; }
        public int Date { get; set; }
        public long SumSalary { get; set; }

        public string FirstName { get => _name.FistName; }
        public string MidName { get => _name.FistName; }
        public string LastName { get => _name.LastName; }

        public partial void CheckIn(string time);
        public partial void CheckOut(string time);
        public partial void DoWork(string work);
        public partial long SumWage();

    }

    internal partial class Staff
    {
        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + amount++;
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string Name
        {
            get => $"{_name.LastName} {_name.MidName} {_name.FistName}";
            set
            {
                var data = value.Split(' ');
                if (data.Length >= 3)
                {
                    _name.FistName = data[data.Length - 1];
                    _name.LastName = data[0];
                    var mid = "";
                    for (int i = 1; i < data.Length - 1; i++)
                    {
                        mid += data[i] + " ";
                    }
                    _name.MidName = mid.TrimEnd();
                }
                else
                {
                    _name.FistName = value;
                    _name.LastName = "";
                    _name.MidName = "";
                }
            }
        }

        internal class Fullname
        {
            public string FistName { get; set; }
            public string MidName { get; set; }
            public string LastName { get; set; }

            public Fullname()
            {

            }

            public Fullname(string fistName, string midName, string lastName)
            {
                FistName = fistName;
                MidName = midName;
                LastName = lastName;
            }
        }

        public partial void CheckIn(string time)
        {
            Console.WriteLine($"Nhan vien {Name} checkin luc : {time}");
        }

        public partial void CheckOut(string time)
        {
            Console.WriteLine($"Nhan vien {Name} checkout luc : {time}");
        }

        public partial void DoWork(string work)
        {
            Console.WriteLine($"Nhan vien {Name} dang lam : {work}");
        }

        public partial long SumWage()
        {
            double bonus = Salary * 0.2;
            double date = (double) Date/22;
            return (long)((Date >= 22) ? Salary * date + bonus : Salary * date);
        }
    }
}
