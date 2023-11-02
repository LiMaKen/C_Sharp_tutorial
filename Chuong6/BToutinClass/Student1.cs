using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.StudentOutIn
{
    class StudentUtil
    {
        public static Student CreateStudent()
        {
            Console.Write("Nhap Ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap chuyen nganh: ");
            string major = Console.ReadLine();
            Console.Write("Nhap xa: ");
            string xa = Console.ReadLine();
            Console.Write("Nhap phuong: ");
            string phuong = Console.ReadLine();
            Console.Write("Nhap tinh: ");
            string tinh = Console.ReadLine();
            Console.Write("Nhap diem lap trinh C: ");
            double lapTrinhC = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ENG: ");
            double eng = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            double toan = double.Parse(Console.ReadLine());
            return new Student(name, major, xa, phuong, tinh, lapTrinhC, eng, toan);
        }

        public static void ShowStudent(Student[] students)
        {
            Console.WriteLine("******************************************************************************************************************************************************");
            Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-20} * {3,-15} * {4,-15} * {5,-15} * {6,-15} * {7,-15} *",
                                            "Msv", "Major", "Full Name", "Address", "LapTrinhC", "Eng", "Toan", "Diem TB"));
            Console.WriteLine("******************************************************************************************************************************************************");

            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-20} * {3,-15} * {4,-15} * {5,-15} * {6,-15} * {7,-15} *",
                    item.ID, item.Major, item.Name, item.Tinh, item.LaptrinhC, item.Eng, item.Toan, item.SumTest()));
                    Console.WriteLine("******************************************************************************************************************************************************");
                }
            }
        }

        public static void SortStudentBySumTest(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.SumTest() - s2.SumTest() != 0)
                {
                    if (s2.SumTest() - s1.SumTest() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return 0;
            }
            for (int i = 0; i < students.Length; i++)
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

        private static void Swap(ref Student student1, ref Student student2)
        {
            var tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        internal static void SortStudentByName(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.LastName.CompareTo(s2.LastName);
            }
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = index - 1; j > i; j--)
                {
                    if (Compare(students[j - 1],students[j]) > 0)
                    {
                        Swap(ref students[j - 1], ref students[j]);
                    }
                }
            }
        }

        internal static void SortStudentByAll(Student[] students, int index)
        {
            int Compare(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.SumTest() - s2.SumTest() != 0)
                {
                    if (s2.SumTest() - s1.SumTest() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return s1.LastName.CompareTo(s2.LastName);
            }
            for (int i = 0; i < students.Length; i++)
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

        internal static void SeachStudentByName(Student[] students, int index)
        {
            Console.Write("Nhap ten sinh vien : ");
            string tinh = Console.ReadLine();
            Student[] seachStudent = new Student[index];
            int size = 0;
            foreach (var item in students)
            {
                if (item != null && item.Tinh.CompareTo(tinh) == 0)
                {
                    seachStudent[size++] = item;
                }
            }
            ShowStudent(seachStudent);
        }

        internal static void SeachStudentByCity(Student[] students, int index)
        {
            Console.Write("Nhap tinh : ");
            string name = Console.ReadLine();
            Student[] seachStudent = new Student[index];
            int size = 0;
            foreach (var item in students)
            {
                if (item != null && item.LastName.CompareTo(name) == 0)
                {
                    seachStudent[size++] = item;
                }
            }
            ShowStudent(seachStudent);
        }

        internal static void DeleteStudent(Student[] students,ref int index)
        {
            Console.Write("Nhap id sinh vien can xoa : ");
            string id = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].ID.CompareTo(id) == 0)
                {
                    students[i] = null;
                    index--;
                    for (int j = i; i < students.Length - 1; i++)
                    {
                        students[j] = students[j + 1];
                    }
                }
            }
        }

        class Information
        {
            public string City { get; set; }
            public int Amount { get; set; }
        }

        public static void StatCity(Student[] students, int index)
        {
            bool Check(Information[] result, string city , int size)
            {
                for (int i = 0; i < size; i++)
                {
                    if (result[i].City.CompareTo(city) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            int Cout(string city, Student[] students)
            {
                int count = 0;
                foreach (var item in students)
                {
                    if (item != null && item.Tinh.CompareTo(city) == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            Information[] result = new Information[students.Length];
            int size = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (Check(result, students[i].Tinh , size))
                {
                    result[size] = new Information();
                    result[size].City = students[i].Tinh;
                    result[size].Amount = Cout(students[i].Tinh, students);
                    size++;
                }
            }
            var finalResult = new Information[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => p2.Amount - p1.Amount);
            foreach (var item in finalResult)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.City} co {item.Amount}");
                }
            }
        }

        internal static void EditLapTrinhC(Student[] students, int index)
        {
            Console.Write("Nhap id sinh vien can sua : ");
            string id = Console.ReadLine();
            var student = CheckId(students, id);
            if (student != null)
            {
                Console.Write("Nhap so diem can sua: ");
                double edit = double.Parse(Console.ReadLine());
                student.LaptrinhC = edit;
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien !");
            }
        }

        private static Student CheckId(Student[] students, string id)
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
    }
    internal class Run
    {
        /*static void Main()
        {
            Student[] students = new Student[100];
            int x;
            int index = 0;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
                "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
                "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
                "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
                "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
                "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
                "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
                "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
                "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
                "10) Liệt kê các sinh viên có điểm TB ở hệ 4 từ 3.20 trở lên.\r\n" +
                "11) Sửa điểm lập trình cho sinh viên theo mã sinh viên.\r\n" +
                "12) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        students[index++] = StudentUtil.CreateStudent();
                        Console.WriteLine($"Ma tinh vien cua ban la : {students[index - 1].ID}");
                        Console.WriteLine("Tao sinh vien thanh cong! ");
                        break;
                    case 2:
                        if (index > 0)
                        {
                            StudentUtil.ShowStudent(students);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            StudentUtil.SortStudentBySumTest(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            StudentUtil.SortStudentByName(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            StudentUtil.SortStudentByAll(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            StudentUtil.SeachStudentByName(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        if (index > 0)
                        {
                            StudentUtil.SeachStudentByCity(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 8:
                        if (index > 0)
                        {
                            StudentUtil.DeleteStudent(students,ref index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 9:
                        if (index > 0)
                        {
                            StudentUtil.StatCity(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 10:
                        if (index > 0)
                        {
                            StudentUtil.DeleteStudent(students, ref index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 11:
                        if (index > 0)
                        {
                            StudentUtil.EditLapTrinhC(students, index);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 12:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;
                }
            } while (x != 12);
        }
        */
    }
}
