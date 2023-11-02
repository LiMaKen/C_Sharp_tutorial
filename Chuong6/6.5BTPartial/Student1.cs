using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.StudentAll
{
    class StudentUitl
    {
        public static void EditTest(Student[] students, int index)
        {
            Console.Write("Nhap vao ma sinh vien can thay doi diem: ");
            string msv = Console.ReadLine();
            var student = CheckId(students, msv);
            if (student != null)
            {
                Console.Write("Nhap vao so diem can thay doi: ");
                double change = double.Parse(Console.ReadLine());
                student.Test = change;
            }
            else { Console.WriteLine("Khong tim thay sinh vien !"); }
        }

        class Information
        {
            public string Address { get; set; }
            public int Amount { get; set; }
        }

        public static void StatAddress(Student[] students, int index)
        {
            bool Check(string addRess, Information[] stats)
            {
                foreach (var item in stats)
                {
                    if (item != null && item.Address.CompareTo(addRess) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            int Cout(string addRess, Student[] student)
            {
                int cout = 0;
                foreach (var item in student)
                {
                    if (item != null && item.AddRess.CompareTo(addRess) == 0)
                    {
                        cout++;
                    }
                }
                return cout;
            }
            Information[] stat = new Information[students.Length];
            int size = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (Check(students[i].AddRess, stat))
                    {
                        stat[size] = new Information();
                        stat[size].Address = students[i].AddRess;
                        stat[size].Amount = Cout(students[i].AddRess, students);
                        size++;
                    }
                }
            }
            var finalResult = new Information[size];
            Array.Copy(stat, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => p2.Amount - p1.Amount);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Address} + {item.Amount}");
            }
        }

        public static void DeleteStudent(Student[] students, ref int index)
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string msv = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].ID.CompareTo(msv) == 0)
                {
                    students[i] = null;
                    index--;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];

                    }
                }
            }
        }

        public static void SeachStudentByAddRess(Student[] students, int index)
        {
            Console.Write("Nhap dia chi: ");
            string addRess = Console.ReadLine();
            var show = new Student[index];
            int cout = 0;
            for (int i = 0; i < index; i++)
            {
                if (students[i] != null && students[i].AddRess.CompareTo(addRess) == 0)
                {
                    show[cout++] = students[i];
                }
            }
            if (cout > 0)
            {
                ShowStudent(show);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao !");
            }
        }

        public static Student CheckId(Student[] students, string id)
        {
            foreach (var item in students)
            {
                if (item != null && item.ID.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        public static void SeachStudentById(Student[] students, int index)
        {
            Console.Write("Nhap ma sinh vien: ");
            string id = Console.ReadLine();
            var student = CheckId(students, id);
            var show = new Student[index];
            int cout = 0;
            if (student != null)
            {
                show[cout++] = student;
                ShowStudent(show);
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin sinh vien!");
            }
        }

        public static void SortStudentByAll(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.Test - s2.Test != 0)
                {
                    if (s2.Test > s1.Test)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return s1.Name.CompareTo(s2.Name);
                }
            }
            for (int i = 0; i < index - 1; i++)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1], students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }

        public static void SortStudentByName(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.Name.CompareTo(s2.Name);
            }
            for (int i = 0; i < index - 1; i++)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1], students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }

        public static void SortStudentByTest(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    for (int j = i + 1; j < students.Length; j++)
                    {
                        if (students[j] != null && students[i].Test < students[j].Test)
                        {
                            Swap(ref students[i], ref students[j]);
                        }
                    }
                }
            }
        }

        public static void Swap(ref Student student1, ref Student student2)
        {
            Student tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        public static Student CreateStudent()
        {
            Console.Write("Nhap ten cua ban: ");
            var name = Console.ReadLine().Split(' ');
            Console.Write("Nhap dia chi: ");
            string addRess = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            double test = double.Parse(Console.ReadLine());
            Console.Write("Nhap chuyen nganh: ");
            string major = Console.ReadLine();
            return new Student(null, name[2], name[1], name[0], addRess, test, major);
        }

        public static void ShowStudent(Student[] student)
        {
            var titleMSV = "MSV";
            var titleName = "Ho Ten";
            var titleCity = "Dia chi";
            var titleTest = "Diem TB";
            var titleMajor = "Chuyen Nganh";
            Console.WriteLine($"{titleMSV,-15}{titleName,-20}{titleCity,-15}{titleTest,-15}{titleMajor,-15}");
            foreach (var item in student)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.ID,-15}{item.SurName + " " + item.MiddleName + " " + item.Name,-20}{item.AddRess,-15}{item.Test,-15}{item.Major,-15}");
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Run
    {
        /*static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[100];
            int index = 0;
            int x;
            do
            {
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
               "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn.Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
               "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
               "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
               "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
               "6) Tìm sinh viên theo tên.Hiển thị kết quả tìm được.\r\n" +
               "7) Tìm sinh viên theo tỉnh.Hiển thị kết quả tìm được.\r\n" +
               "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
               "9) Liệt kê số lượng sinh viên theo từng tỉnh.Sắp xếp giảm dần theo số lượng.\r\n" +
               "10) Liệt kê số lượng sinh viên theo đầu điểm môn tiếng anh giảm dần.\r\n" +
               "11) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
               "12) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        students[index] = StudentUitl.CreateStudent();
                        Console.WriteLine($"Them sinh vien thanh cong! Ma sinh vien cua ban la {students[index].ID}");
                        index++;
                        Console.WriteLine();
                        break;
                    case 2:
                        if (index > 0)
                        {
                            StudentUitl.ShowStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            StudentUitl.SortStudentByTest(students);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            StudentUitl.SortStudentByName(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            StudentUitl.SortStudentByAll(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            StudentUitl.SeachStudentById(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        if (index > 0)
                        {
                            StudentUitl.SeachStudentByAddRess(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 8:
                        if (index > 0)
                        {
                            StudentUitl.DeleteStudent(students, ref index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 9:
                        if (index > 0)
                        {
                            StudentUitl.StatAddress(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 10:
                        if (index > 0)
                        {
                            StudentUitl.EditTest(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Tam biet !");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;

                }
            } while (x != 11);
        }*/
    }
}
