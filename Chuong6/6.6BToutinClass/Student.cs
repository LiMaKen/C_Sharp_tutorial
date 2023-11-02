using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chuong6.StudentOutIn
{
    internal partial class Student
    {
        public Student()
        {
            ID = null;
        }
        public Student(string name , string major , string xa, string phuong, string tinh, double lapTrinhC, double eng, double toan) : this()
        {
            Name = name;
            Major = major;
            Xa = xa;
            Phuong = phuong;
            Tinh = tinh;
            LaptrinhC = lapTrinhC;
            Eng = eng;
            Toan = toan;
        }

        private static int _amount = 1000;
        private string _id;
        private FullName _name = new();
        private AddRess _addRess = new();
        private Test _test = new();

        public string Major { get; set; }

        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "ST" + _amount++;
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string LastName { get => _name.LastName; }

        public string Name
        {
            get => $"{_name.FistName} {_name.MidName} {_name.LastName}";
            set
            {
                var data = value.Split(' ');
                if (data.Length >= 1)
                {
                    _name.FistName = data[0];
                    _name.LastName = data[data.Length - 1];
                    var mid = "";
                    for (int i = 1; i < data.Length - 1; i++)
                    {
                        mid += data[i];
                    }
                    _name.MidName = mid;
                }
                else
                {
                    _name.FistName = "";
                    _name.MidName = "";
                    _name.LastName = data[0];
                }
            }
        }

        public string Xa { get => _addRess.Xa; set => _addRess.Xa = value; }
        public string Phuong { get => _addRess.Phuong; set => _addRess.Phuong = value; }
        public string Tinh { get => _addRess.Tinh; set => _addRess.Tinh = value; }

        public double LaptrinhC
        {
            get => _test.LapTrinhC;
            set
            {
                if (value <= 10 && value >= 0)
                {
                    _test.LapTrinhC = value;
                }
                else
                {
                    Console.WriteLine("Diem khong hop le");
                    _test.LapTrinhC = 0;
                }
            }
        }
        public double Eng
        {
            get => _test.Eng;
            set
            {
                if (value <= 10 && value >= 0)
                {
                    _test.Eng = value;
                }
                else
                {
                    Console.WriteLine("Diem khong hop le !");
                    _test.Eng = 0;
                }
            }
        }
        public double Toan { get => _test.Toan;
            set
            {
                if (value <= 10 && value >= 0)
                {
                    _test.Toan = value;
                }
                else
                {
                    Console.WriteLine("Diem khong hop le !");
                    _test.Toan = 0;
                }
            }
        }
        public double Sum { get => _test.SumTest; set => _test.SumTest = value; }

        public double SumTest()
        {
            return (double) ((LaptrinhC + Eng + Toan) / 3);
        }

    }

    internal partial class Student
    {
        class Test
        {
            public Test()
            {

            }
            public double LapTrinhC { get; set; }
            public double Eng { get; set; }
            public double Toan { get; set; }
            public double SumTest { get; set; }
        }

        class FullName
        {
            public FullName()
            {

            }
            public string FistName { get; set; }
            public string MidName { get; set; }
            public string LastName { get; set; }
        }

        class AddRess
        {
            public AddRess()
            {

            }
            public string Xa { get; set; }
            public string Phuong { get; set; }
            public string Tinh { get; set; }
        }
    }

}
