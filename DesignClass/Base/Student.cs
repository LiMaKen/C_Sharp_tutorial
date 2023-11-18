using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignClass.Base
{
    public class Student : Person
    {
        private static int amount = 1000;
        public Student()
        {
            Id = "ST" + amount++;
        }

        public Student(string id, string name, string addRess, int age, string major)
        {
            Id = string.IsNullOrEmpty(id) ? "ST" + amount++ : id;
            FullName = new FullName(name);
            AddRess = addRess;
            Age = age;
            Major = major;
        }

        public string Id { get; set; }

        public string Major { get; set; }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            var orther = (Student)obj;
            return orther.Id.CompareTo(Id) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
    }
}