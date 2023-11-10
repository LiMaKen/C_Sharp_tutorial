using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP;
#region Bai 2
/*
class Student
{
    private static int amount = 1000;
    public string Id { get; set; }
    public FullName FullName { get; set; } 
    public string Major { get; set; }
    public int CheckRegister { get; set; }

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
        CheckRegister = 0;
    }
    public override bool Equals(object obj)
    {
        if (obj.GetType() != this.GetType())
        {
            return false;
        }
        var other = (Student)obj;
        return other.Id == Id;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
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
        FirstName = data[0];
        LastName = data[data.Length - 1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.Trim();
    }

    public override string ToString()
    {
        return $"{FirstName} {MidName} {LastName}";
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
    public override bool Equals(object obj)
    {
        if (obj.GetType() != this.GetType())
        {
            return false;
        }
        var other = (Subject)obj;
        return other.SubjectId == SubjectId;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
class Register
{
    private static int amount = 10000;
    public int RegisterId { get; set; } // mã đăng ký
    public Student Student { get; set; } //  sinh viên
    public Subject Subject { get; set; } //  môn học
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

    public override bool Equals(object obj)
    { 
        
        if (obj is Subject)
        {
            var other = (Subject)obj;
            if (other.SubjectId == Subject.SubjectId)
            {
                return true;
            }
        }
        if (obj is Student)
        {
            var other2 = (Student)obj;
            if (other2.Id == Student.Id)
            {
                return true;
            }
        }
        return false;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
*/
#endregion
#region Bai 3
class Person
{
    public FullName FullName { get; set; }
    public string AddRess { get; set; }
    public int Age { get; set; }
}
class FullName
{
    public string FirstName { get; set; }
    public string MidName { get; set; }
    public string LastName { get; set; }
    public FullName()
    {
        FirstName = "";
        MidName = "";
        LastName = "";
    }
    public FullName(string name)
    {
        SetFullName(name);
    }

    private void SetFullName(string name)
    {
        var data = name.Split(' ');
        FirstName = data[0];
        LastName = data[data.Length - 1];
        var mid = "";
        for (int i = 1; i < data.Length - 1; i++)
        {
            mid += data[i] + " ";
        }
        MidName = mid.TrimEnd();
    }

    public override string ToString() => $"{FirstName} {MidName} {LastName}";
}

class Student : Person
{
    private static int amount = 1000;

    public string Id { get; set; }
    public string Major { get; set; }

    public Student()
    {
        Id = "ST" + amount++;
    }
    public Student(string id)
    {
        Id = string.IsNullOrEmpty(id) ? "ST" + amount++ : id;
    }
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
    public Student(string id, string name, int age, string addRess, string major) : this(id)
    {
        FullName = new FullName(name);
        Major = major;
        Age = age;
        AddRess = addRess;
    }
}
class Subject
{
    private static int amount = 1000;
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public int NumberOfCredit { get; set; }
    public Subject()
    {
        SubjectId = amount++;
    }
    public Subject(string subjectName, int numberOfCredit) : this()
    {
        SubjectName = subjectName;
        NumberOfCredit = numberOfCredit;
    }
}
class Course
{
    private static int autoId = 10000;
    public int CourseId { get; set; }
    public int NumberOfStudent { get; set; }
    public int NumberOfTranscript { get; set; }
    public Subject Subject { get; set; }
    public string Teacher { get; set; }
    public TranScript[] TranScript { get; set; }
    public Course()
    {
        CourseId = autoId++;
    }
    public Course(Subject subject, string teacher, int numberOfStudent) : this()
    {
        Subject = subject;
        Teacher = teacher;
        NumberOfStudent = numberOfStudent;
        TranScript = new TranScript[numberOfStudent];
        NumberOfTranscript = 0;
    }
}
class TranScript
{
    private static int amount = 1000;
    public int TranScriptId { get; set; }
    public Student Student { get; set; }
    public float Test1 { get; set; }
    public float Test2 { get; set; }
    public float Test3 { get; set; }
    public float TB { get; set; }

    public TranScript()
    {
        TranScriptId = amount++;
    }
    public TranScript(Student student, float test1, float test2, float test3) : this()
    {
        Student = student;
        Test1 = test1;
        Test2 = test2;
        Test3 = test3;
    }
    public float SumTest()
    {
        float he1 = Test1 * 0.1f;
        float he2 = Test2 * 0.3f;
        float he3 = Test3 * 0.6f;
        TB = (float)(he1 + he2 + he3);
        return TB;
    }
}
class Information
{
    public float NumberGood { get; set; }
    public float NumberBad { get; set; }
    public int StudentGood { get; set; }
    public int StudentBad { get; set; }
}
#endregion
