using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.StudentAll
{
    class Student
    {
        public Student()
        {
            ID = null;
        }
        public Student(string id, string name, string middleName, string surName, string addRess, double test, string major)
        {
            ID = id;
            Name = name;
            MiddleName = middleName;
            SurName = surName;
            AddRess = addRess;
            Test = test;
            Major = major;

        }
        private static int IDCout { get; set; } = 1000;
        private string _id;
        public string ID
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "ST" + IDCout++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string AddRess { get; set; }
        public double Test { get; set; }
        public string Major { get; set; }
    }
}
