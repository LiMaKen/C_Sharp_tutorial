using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP;
#region Bai 2
class Student
{
    private static int amount = 1000;
    public string Id { get; set; }
    public FullName FullName { get; set; }
    public string Major { get; set; }

    public Student()
    {
       
    }
    public Student(string id)
    {
        Id = string.IsNullOrEmpty(id) ? "STU" + amount++ : id;
    }
    public Student(string id, string name, string major) : this(id)
    {
        FullName = new FullName(name);
        Major = major;
    }
}
class FullName
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string MidName { get; set; } = "";

    public FullName() { }

    public FullName(string fullName)
    {
        SetFullName(fullName);
    }

    public FullName(string firstName, string lastName, string midName)
    {
        FirstName = firstName;
        LastName = lastName;
        MidName = midName;
    }

    public void SetFullName(string fullName)
    {
        var data = fullName.Split(' ');
        LastName = data[0];
        FirstName = data[data.Length - 1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.Trim();
    }

    public override string ToString()
    {
        return $"{LastName} {MidName} {FirstName}";
    }
}
class Subject
{
    private static int amount = 10000;
    public int SubjectId { get; set; } // Mã môn học
    public string SubjectName { get; set; } // tên môn học
    public int NumberOfCredits { get; set; } // số tín chỉ
    public int NumberOfLessons { get; set; } // số tiết học
    public Subject()
    {
        SubjectId = amount++;
    }
    public Subject(int id)
    {
        SubjectId = id == 0 ? amount++ : id;
    }
    public Subject(int id, string subjectName, int numberOfCredits, int numberOfLessons) : this(id)
    {
        SubjectName = subjectName;
        NumberOfCredits = numberOfCredits;
        NumberOfLessons = numberOfLessons;
    }
}
class Register
{
    private static int amount = 10000;
    public int RegisterId { get; set; } // mã đăng ký
    public Student Student { get; set; } // tên sinh viên
    public Subject Subject { get; set; } // tên môn học
    public DateTime RegisterTime { get; set; } // thời gian đăng ký
    public Register()
    {
        RegisterId = amount++;
    }
    public Register(int id)
    {
        RegisterId = id == 0 ? amount++ : id;
    }
    public Register(int id, Student student, Subject subject, DateTime registerTime) : this(id)
    {
        Student = student;
        Subject = subject;
        RegisterTime = registerTime;
    }
}
#endregion
