using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


class Run
{
    static void Main()
    {
        Input();
        Output();
    }
    static void Input()
    {
        try
        {
            var file = @"data.json";
            if (File.Exists(file))
            {
                var data = File.ReadAllText(file);
                var jObject = JObject.Parse(data);
               var jArray = jObject["students"]; 
                List<Student> students = new List<Student>();
                foreach (var student in jArray)
                {
                    students.Add(student.ToObject<Student>());
                }
                foreach (var item in students)
                {
                    Console.WriteLine(item);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    static void Output()
    {
        try
        {
            var file = @"outputdata.json";
            if (File.Exists(file))
            {
               var students = CreateStudents();
                var root = new
                {
                    student = students,
                };
                var jObjectOutput = JsonConvert.SerializeObject(root, Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(file,true))
                {
                    sw.WriteLine(jObjectOutput);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    static Student[] CreateStudents()
    {
        return new Student[] {
                new Student("SV101", 20, "CNTT", 3.25f,
                    new FullName("Hoàng", "Nguyễn", "Đình"),
                    new AddRess("Trung Hòa", "Cầu Giấy", "Hà Nội")),
                new Student("SV102", 21, "CNTT", 3.45f,
                    new FullName("Lâm", "Văn", "Tiến"),
                    new AddRess("Nghĩa Đô", "Cầu Giấy", "Hà Nội")),
                new Student("SV103", 24, "CNTT", 3.75f,
                    new FullName("Mạnh", "Lưu", "Thế"),
                    new AddRess("Dịch Vọng", "Cầu Giấy", "Hà Nội")),
                new Student("SV104", 21, "CNTT", 3.15f,
                    new FullName("Bình", "Lưu", "Đức"),
                    new AddRess("Mai Dịch", "Cầu Giấy", "Hà Nội")),
                new Student("SV105", 20, "CNTT", 3.15f,
                    new FullName("Mai", "Đinh", "Thị"),
                    new AddRess("Quan Hoa", "Cầu Giấy", "Hà Nội"))
            };
    }
}

class Student
{
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("age")]
    public int Age { get; set; }
    [JsonProperty("major")]
    public string Major { get; set; }
    [JsonProperty("gpa")]
    public float Gpa { get; set; }
    [JsonProperty("fullname")]
    public FullName FullName { get; set; }
    [JsonProperty("address")]
    public AddRess AddRess { get; set; }
    public Student()
    {
       
    }
    public Student(string id , int age , string major , float gpa , FullName fullName, AddRess addRess)
    {
            Id = id;
        Age = age;
        Major = major;
        Gpa = gpa;
        FullName = fullName;
            AddRess = addRess;

    }
    public override string ToString() => $"{Id} {Age} {Major} {Gpa} {FullName} {AddRess}";
}
class FullName
{
    [JsonProperty("first")]
    public string FirstName { get; set; }
    [JsonProperty("mid")]
    public string MidName { get; set; }
    [JsonProperty("last")]
    public string LastName { get; set; }
    public FullName()
    {
         
    }
    public FullName(string f, string m, string l)
    {
        FirstName  = f;
        MidName = m;
        LastName = l;
    }
    public override string ToString() => $"{FirstName} {MidName} {LastName}";
    
}
class AddRess
{
    [JsonProperty("ward")]
    public string Ward { get; set; }
    [JsonProperty("district")]
    public string District { get; set; }
    [JsonProperty("city")]
    public string City { get; set; }
    public AddRess()
    {
        
    }
    public AddRess(string w, string d , string c)
    {
        Ward = w;
        District = d;
        City = c;
    }
    public override string ToString() => $"{Ward} {District} {City}";
}