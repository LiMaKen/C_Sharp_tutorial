using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignClass.Base;
using ConsoleLog.New;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace DesignClass
{
    sealed public class Uitl
    {
        internal static Student CreateStudent()
        {
            Console.WriteLine("Nhap vao ten cua ban: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi: ");
            string addRess = Console.ReadLine();
            Console.WriteLine("Nhap vao tuoi: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao chuyen nganh: ");
            string major = Console.ReadLine();
            return new Student(null, name, addRess, age, major);
        }

        internal static Subject CreateSubject()
        {
            Console.WriteLine("Nhap vao ten mon hoc: ");
            string subjectName = Console.ReadLine();
            Console.WriteLine("Nhap vao so tin chi: ");
            int numberOfCredit = int.Parse(Console.ReadLine());
            return new Subject(subjectName, numberOfCredit);
        }

        internal static Course CreateCourses(Subject[] subjects)
        {
            Console.WriteLine("Nhap ma lop hoc phan can them: ");
            int subjectId = int.Parse(Console.ReadLine());
            var subject = Getsubject(subjects, subjectId);
            if (subject != null)
            {
                Console.WriteLine("Nhap vao so luong sinh vien: ");
                int numberOfStudent = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao giao vien: ");
                string teacher = Console.ReadLine();
                return new Course(numberOfStudent, teacher, subject);
            }
            else
            {
                Console.WriteLine("Khong tim thay lop hoc phan !");
            }
            return null;
        }

        private static Subject Getsubject(Subject[] subjects, int subjectId)
        {
            foreach (var item in subjects)
            {
                if (item != null && item.SubjectId == subjectId)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void CreateTranScript(Course[] courses, Student[] students, string studentId, int courseId)
        {
            try
            {
                var student = GetStudent(students, studentId);

                var course = GetCours(courses, courseId);

                if (student == null || course == null) return;

                if (course.NumberOfTranscrip > course.NumberOfStudent) return;

                if (CheckStudentByCourse(course.TranScript, student)) return;

                course.TranScript[course.NumberOfTranscrip++] = InputTranScript(student);
            }
            catch (Exception e) { ConsoleNew.Log("Loi", e.ToString()); }
        }

        private static TranScript InputTranScript(Student student)
        {
            TranScript tranScript = new TranScript();
            Console.WriteLine("Nhap vao diem test1: ");
            tranScript.Test1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem test2 : ");
            tranScript.Test2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem test3: ");
            tranScript.Test3 = float.Parse(Console.ReadLine());
            tranScript.SumTestTb();
            tranScript.Student = student;
            return tranScript;
        }

        private static bool CheckStudentByCourse(TranScript[] tranScript, Student student)
        {
            foreach (var item in tranScript)
            {
                if (item != null && student.Equals(item.Student))
                {
                    return true;
                }
            }
            return false;
        }

        private static Course GetCours(Course[] courses, int courseId)
        {
            foreach (var item in courses)
            {
                if (item != null && item.CourseId == courseId)
                {
                    return item;
                }
            }
            return null;
        }

        private static Student GetStudent(Student[] students, string studentId)
        {
            foreach (var student in students)
            {
                if (student != null && student.Id.CompareTo(studentId) == 0)
                {
                    return student;
                }
            }
            return null;
        }

        internal static void ShowStudent(Student[] students)
        {
            var titleId = "MSV";
            var titleFullName = "Ho Va Ten";
            var titleAge = "Tuoi";
            var titleMajor = "Chuyen Nganh";
            var titleAddRess = "Dia Chi";
            Console.WriteLine($"{titleId,-15}{titleFullName,-15}{titleAge,-15}{titleMajor,-15}{titleAddRess,-15}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-15}{item.FullName,-15}{item.Age,-15}{item.Major,-15}{item.AddRess,-15}");
                }
            }
        }

        internal static void ShowSubject(Subject[] subjects)
        {
            var titleId = "Ma Dang Ky";
            var titleName = "Ten HP";
            var titleNumberC = "So Tin Chi";
            Console.WriteLine($"{titleId,-15}{titleName,-15}{titleNumberC,-15}");
            foreach (var item in subjects)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.SubjectId,-15}{item.SubjectName,-15}{item.NumberOfCredit,-15}");
                }
            }
        }

        internal static void ShowCourses(Course[] courses)
        {
            var titleId = "Ma Bang Diem";
            var titleIdStudent = "MSV";
            var titleStudentName = "Ho Ten";
            var titleHe1 = "Diem He 1";
            var titleHe2 = "Diem He 2";
            var titleHe3 = "Diem He 3";
            var titleTb = "Diem TB";
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    Console.WriteLine($"ID lop {courses[i].CourseId} Ten mon hoc: {courses[i].Subject.SubjectName}");
                    Console.WriteLine($"{titleId,-15}{titleIdStudent,-15}{titleStudentName,-15}{titleHe1,-15}{titleHe2,-15}{titleHe3,-15}{titleTb,-15}");
                    foreach (var item in courses[i].TranScript)
                    {
                        if (item != null)
                        {
                            Console.WriteLine($"{item.TranScriptId,-15}{item.Student.Id,-15}{item.Student.FullName,-15}{item.Test1,-15}{item.Test2,-15}{item.Test3,-15}{item.SumTest,-15}");
                        }
                    }
                }
            }
        }

        internal static void SortStudentByName(Student[] students)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.FullName.LastName.CompareTo(s2.FullName.LastName);
            }
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (Compare(students[i], students[j]) > 0)
                    {
                        var tmp = students[i];
                        students[i] = students[j];
                        students[j] = tmp;
                    }
                }
            }
        }

        internal static void SeachStudent(Student[] students)
        {
            Console.WriteLine("Nhap vao ma sinh vien can tim: ");
            string id = Console.ReadLine();
            var student = GetStudent(students, id);
            if (student != null)
            {
                Console.WriteLine("Sinh vien can tim la : ");
                Console.WriteLine($"{student.Id} {student.FullName} {student.Age} {student.Major}");
            }
            else
            {
                Console.WriteLine("Khong tim thay ma sinh vien tuong ung!");
            }
        }

        internal static void DeleteStudent(Student[] students)
        {
            Console.WriteLine("Nhap vao ma sinh vien can xoa: ");
            string id = Console.ReadLine();
            bool Delete()
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                    {
                        students[i] = null;
                        return true;
                    }
                }
                return false;
            }
            Console.WriteLine(Delete() == true ? "Xoa thanh cong" : "Xoa that bai"); ;
        }

        internal static void ShortTranScrip(Course[] courses)
        {
            Console.WriteLine("Nhap vao ma lop hoc can sap xep: ");
            int idCourse = int.Parse(Console.ReadLine());
            var course = GetCours(courses, idCourse);
            if (course != null)
            {
                var newTranscript = new TranScript[course.NumberOfTranscrip];
                Array.Copy(course.TranScript, newTranscript, course.NumberOfTranscrip);
                Array.Sort(newTranscript);
                Array.Reverse(newTranscript);
                Console.WriteLine("Hoc phan da duoc sap xep !");
                course.TranScript = newTranscript;
            }
            else
            {
                Console.WriteLine("Khong tim thay lop hoc !");
            }
        }

        internal static void StatStudentHight(Course[] courses)
        {
            int Check(float tb, Information[] result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != null && result[i].NumberGood == tb)
                    {
                        return i;
                    }
                }
                return -1;
            }
            Information[] result = new Information[courses.Length];
            int size = 0;
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    foreach (var item in courses[i].TranScript)
                    {
                        if (item != null && item.SumTest >= 8)
                        {
                            var resultCheck = Check(item.SumTest, result);
                            if (resultCheck != -1)
                            {
                                result[resultCheck].StudentGood++;
                                continue;
                            }
                            else
                            {
                                result[size] = new Information();
                                result[size].NumberGood = item.SumTest;
                                result[size].StudentGood = 1;
                                size++;
                            }
                        }
                    }
                }
            }
            var finalResult = new Information[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => Convert.ToInt32(p2.NumberGood - p1.NumberGood));
            foreach (var item in finalResult)
            {
                Console.WriteLine($"Co {item.StudentGood} sinh vien dat diem {item.NumberGood}");
            }
        }

        internal static void StatStudentBad(Course[] courses)
        {
            int Check(float tb, Information[] result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != null && result[i].NumberBad == tb)
                    {
                        return i;
                    }
                }
                return -1;
            }
            Information[] result = new Information[courses.Length];
            int size = 0;
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    foreach (var item in courses[i].TranScript)
                    {
                        if (item != null && item.SumTest < 4)
                        {
                            var resultCheck = Check(item.SumTest, result);
                            if (resultCheck != -1)
                            {
                                result[resultCheck].StudentBad++;
                                continue;
                            }
                            else
                            {
                                result[size] = new Information();
                                result[size].NumberBad = item.SumTest;
                                result[size].StudentBad = 1;
                                size++;
                            }
                        }
                    }
                }
            }
            var finalResult = new Information[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => Convert.ToInt32(p2.NumberBad - p1.NumberBad));
            foreach (var item in finalResult)
            {
                Console.WriteLine($"Co {item.StudentBad} sinh vien truot mon voi so diem:  {item.NumberBad}");
            }
        }

        internal static void EditTest(Course[] courses, Student[] students)
        {
            Console.WriteLine("Nhap lop hoc phan: ");
            int idCourse = int.Parse(Console.ReadLine());
            var course = GetCours(courses, idCourse);
            if (course != null)
            {
                Console.WriteLine("Nhap vao ma sinh vien can sua diem: ");
                string id = Console.ReadLine();
                var student = GetStudent(students, id);
                if (student != null)
                {
                    for (int i = 0; i < course.TranScript.Length; i++)
                    {
                        if (course.TranScript[i] != null && student.Equals(course.TranScript[i].Student))
                        {
                            Console.WriteLine("Nhap vao so diem he 1: ");
                            float he1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so diem he 2: ");
                            float he2 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so diem he 3: ");
                            float he3 = float.Parse(Console.ReadLine());
                            var newTranScript = new TranScript(he1, he2, he3, student);
                            newTranScript.SumTestTb();
                            course.TranScript[i] = newTranScript;
                            Console.WriteLine("Sua thanh cong !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien!");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc phan !");
            }
        }

        internal static void SeachStudentByIdCourse(Course[] courses, Student[] students)
        {
            Console.WriteLine("Nhap vao ma lop: ");
            int idCourse = int.Parse(Console.ReadLine());
            var course = GetCours(courses, idCourse);
            if (course == null) return;
            
                Console.WriteLine("Nhap diem >= can tim : ");
                float x = float.Parse(Console.ReadLine());
                var seachStudent = new Student[students.Length];
                int size = 0;
                foreach (var item in course.TranScript)
                {
                    if (item != null && item.SumTest >= x)
                    {
                        seachStudent[size++] = item.Student;
                    }
                }
               var check = size > 0 ? (Action)(() => ShowStudent(seachStudent)) : () => Console.WriteLine("Khong co sinh vien nao dat diem nhu vay !");
               check();
        }

        internal static void DeleteTranScript(Course[] courses, Student[] students)
        {
            Console.WriteLine("Nhap ma lop : ");
            int idCourse = int.Parse(Console.ReadLine());
            var course = GetCours(courses, idCourse);
            if (course == null) return;
            Console.WriteLine("Nhap vao ma sinh vien can xoa bang diem: ");
            string idStudent = Console.ReadLine();
            var student = GetStudent(students, idStudent);
            bool Delete()
            {
                for (int i = 0; i < course.TranScript.Length; i++)
                {
                    if (course.TranScript[i] != null && course.TranScript[i].Student.Equals(student))
                    {
                        course.TranScript[i] = null;
                        return true;
                    }
                }
                return false;
            }
            Console.WriteLine(Delete() == true ? "Xoa thanh cong !" : "Xoa that bai!");
        }
    }
}