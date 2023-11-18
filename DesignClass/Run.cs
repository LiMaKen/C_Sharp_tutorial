using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignClass.Base;

namespace DesignClass
{
   sealed class Run
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int Max = 100;
            Student[] students = new Student[Max];
            Subject[] subjects = new Subject[Max];
            Course[] courses = new Course[Max];
            int studentIndex = 0;
            int subjectIndex = 0;
            int coursesIndex = 0;
            int x;
            do
            {
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
              "2) Thêm mới môn học vào danh sách.\r\n" +
              "3) Thêm mới lớp học phần vào danh sách các lớp học phần.\r\n" +
              "4) Nhập bảng điểm cho các sinh viên trong một lớp học phần bằng cách nhập mã lớp, mã\r\nsinh viên và các đầu điểm hệ số 1, 2. 3. Bảng điểm của mỗi sinh viên với 1 môn học chỉ\r\nxuất hiện 1 lần trong danh sách bảng điểm.\r\n" +
              "5) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
              "6) Hiển thị danh sách môn học ra màn hình.\r\n" +
              "7) Hiển thị danh sách bảng điểm của từng lớp học phần\r\n" +
              "8) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
              "9) Tìm sinh viên theo mã sinh viên cho trước.\r\n" +
              "10) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
              "11) Sắp xếp danh sách bảng điểm của một lớp học phần theo thứ tự điểm TB môn giảm dần.\r\n" +
              "12) Liệt kê số lượng sinh viên đạt điểm TB loại giỏi(>= 8.0 ở hệ 10) trong các lớp học phần\r\ntheo thứ tự giảm dần.\r\n" +
              "13) Liệt kê số lượng sinh viên trượt môn trong từng lớp học phần(điểm TB < 4) theo thứ tự\r\nsố lượng sinh viên giảm dần.\r\n" +
              "14) Sửa điểm cho sinh viên theo mã lớp học phần và mã sinh viên.\r\n" +
              "15) Tìm các sinh viên có điểm >= x trong lớp học phần khi biết mã lớp.\r\n" +
              "16) Xóa bảng điểm của sinh viên có mã x trong lớp học phần mã p nào đó.\r\n" +
              "17) Kết thúc chương trình.");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        var student = Uitl.CreateStudent();
                        students[studentIndex++] = student;
                        Console.WriteLine($"Tao sinh vien thanh cong. Ma sinh vien cua ban la {student.Id}");
                        break;
                    case 2:
                        var subject = Uitl.CreateSubject();
                        subjects[subjectIndex++] = subject;
                        Console.WriteLine($"Tao mon hoc thanh cong. Ma mon hoc la : {subject.SubjectId}");
                        break;
                    case 3:
                        var course = Uitl.CreateCourses(subjects);
                        if (course != null)
                        {
                            courses[coursesIndex++] = course;
                            Console.WriteLine($"Tao lop hoc thanh cong. Ma lop hoc la : {course.CourseId}");
                        }
                        else
                        {
                            Console.WriteLine("Tao lop hoc that bai !");
                        }
                        break;
                    case 4:
                        if (coursesIndex > 0)
                        {
                            Console.WriteLine("Nhap vao ma sinh vien : ");
                            string studentId = Console.ReadLine();
                            Console.WriteLine("Nhap vao khoa hoc : ");
                            int courseId = int.Parse(Console.ReadLine());
                            Uitl.CreateTranScript(courses, students , studentId , courseId);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 5:
                        if (studentIndex > 0)
                        {
                            Uitl.ShowStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 6:
                        if (subjectIndex > 0)
                        {
                            Uitl.ShowSubject(subjects);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach mon hoc trong !");
                        }
                        break;
                    case 7:
                        if (coursesIndex > 0)
                        {
                            Uitl.ShowCourses(courses);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 8:
                        if (studentIndex > 0)
                        {
                            Uitl.SortStudentByName(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 9:
                        if (studentIndex > 0)
                        {
                            Uitl.SeachStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 10:
                        if (studentIndex > 0)
                        {
                            Uitl.DeleteStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 11:
                        if (coursesIndex > 0)
                        {
                            Uitl.ShortTranScrip(courses);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 12:
                        if (coursesIndex > 0)
                        {
                            Uitl.StatStudentHight(courses);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 13:
                        if (coursesIndex > 0)
                        {
                            Uitl.StatStudentBad(courses);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 14:
                        if (coursesIndex > 0)
                        {
                            Uitl.EditTest(courses, students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 15:
                        if (coursesIndex > 0)
                        {
                            Uitl.SeachStudentByIdCourse(courses, students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 16:
                        if (coursesIndex > 0)
                        {
                            Uitl.DeleteTranScript(courses, students);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach khoa hoc trong !");
                        }
                        break;
                    case 17:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon!");
                        break;
                }
            } while (x != 17);
        }
    }
}