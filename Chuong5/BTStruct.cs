using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.CompilerServices;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using System.ComponentModel;

namespace Chuong5
{
    internal class BTStruct
    {
        #region Bai 1
        /*
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
        }
        struct AB
        {
            public AB(Point a, Point b)
            {
                A = a;
                B = b;
            }
            public Point A { get; set; }
            public Point B { get; set; }
            public static double Sum(Point a, Point b)
            {
                double m = Math.Pow(a.X - b.X, 2);
                double n = Math.Pow(a.Y - b.Y, 2);
                double MN = (double)Math.Sqrt(m + n);
                return MN;
            }
        }
        static void Main()
        {
            GetData(out Point pointpoint1, out Point pointpoint2);
            double result = AB.Sum(pointpoint1, pointpoint2);
            Console.WriteLine(result);
        }
        private static void GetData(out Point pointpoint1, out Point pointpoint2)
        {

            Point point1 = new Point();
            Point point2 = point1;
            Console.Write("Moi ban nhap diem A: ");
            var element1 = Console.ReadLine().Split(' ');
            point1.X = int.Parse(element1[0]);
            point1.Y = int.Parse(element1[1]);
            Console.Write("Moi ban nhap diem B: ");
            var element2 = Console.ReadLine().Split(' ');
            point2.X = int.Parse(element2[0]);
            point2.Y = int.Parse(element2[1]);
            pointpoint1 = point1;
            pointpoint2 = point2;
        }
        */
        #endregion
        #region Bai 2
        /*
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
        }
        struct HCN
        {
            public HCN(Point a,int width,int hight)
            {
                O = a;
                Whidth = width;
                Hight= hight;
                  
            }
            public Point O { get; set; }
            public int Whidth { get; set; }
            public int Hight { get; set; }
            public int S()
            {
                int s = Whidth * Hight;
                return s;
            }
            public int P()
            {
                int p = 2*(Whidth + Hight);
                return p;
            }
        }
        static void Main()
        {
            GetData(out HCN wh);
            double result = wh.S();
            double result2 = wh.P();
            Console.WriteLine("Dien tich hcn la: " + result);
            Console.WriteLine("Chu vi hcn la: " + result2);
        }
        private static void GetData(out HCN wh)
        {

            Point point = new Point();
            HCN hcn = new HCN();
            Console.Write("Moi ban nhap toa do tam cua HCN: ");
            var element1 = Console.ReadLine().Split(' ');
            point.X = int.Parse(element1[0]);
            point.Y = int.Parse(element1[1]);
            Console.Write("Moi ban nhap chieu dai va chieu rong cua HCN: ");
            var element = Console.ReadLine().Split(' ');
            hcn.O = point;
            hcn.Whidth = int.Parse(element[0]);
            hcn.Hight = int.Parse(element[1]);
            wh = hcn;
        }
        */
        #endregion
        #region Bai 3
        /*
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
            public override string ToString() => $"{X},{Y}";
        }
        struct ABC
        {
            public ABC(Point a, Point b, Point c)
            {
                A = a;
                B = b;
                C = c;

            }
            public Point A { get; set; }
            public Point B { get; set; }
            public Point C { get; set; }

            public double AB()
            {
                double a = Math.Pow(A.X - B.X, 2);
                double b = Math.Pow(A.Y - B.Y, 2);
                double AB = (double)Math.Sqrt(a + b);
                return AB;
            }
            public double AC()
            {
                double a = Math.Pow(A.X - C.X, 2);
                double c = Math.Pow(A.Y - C.Y, 2);
                double AC = (double)Math.Sqrt(a + c);
                return AC;
            }
            public double BC()
            {
                double b = Math.Pow(B.X - C.X, 2);
                double c = Math.Pow(B.Y - C.Y, 2);
                double BC = (double)Math.Sqrt(b + c);
                return BC;
            }
            public override string ToString() => $"({A}),({B}),({C})";
        }
        static void Main()
        {
            GetData(out ABC triAngke);
            Console.WriteLine(triAngke);
            double AB = triAngke.AB();
            double AC = triAngke.AC();
            double BC = triAngke.BC();
            Console.WriteLine("Dien tich tam giac la: " + P(AB, AC, BC));
            Console.WriteLine("Chu vi tam giac la: " + S(AB, AC, BC));
        }

        private static double P(double AB, double AC, double BC)
        {
            double p = AB + AC + BC;
            return p;
        }

        private static double S(double AB, double AC, double BC)
        {
            double p = 0.5 * (AB + AC + BC);
            double s = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            return s;
        }

        private static void GetData(out ABC triAngke)
        {
            Console.Write("Moi ban nhap toa do diem A: ");
            var elements1 = Console.ReadLine().Split(' ');
            Point point1 = new Point(int.Parse(elements1[0]), int.Parse(elements1[1]));

            Console.Write("Moi ban nhap toa do diem B: ");
            var elements2 = Console.ReadLine().Split(' ');
            Point point2 = new Point(int.Parse(elements2[0]), int.Parse(elements2[1]));

            Console.Write("Moi ban nhap toa do diem C: ");
            var elements3 = Console.ReadLine().Split(' ');
            Point point3 = new Point(int.Parse(elements3[0]), int.Parse(elements3[1]));

            triAngke = new ABC(point1, point2, point3);
        }
        */
        #endregion
        #region Bai 4
        /*
        struct DayOfWeek
        {
            public DayOfWeek(int day, string dayEng, string dayVn)
            {
                Day = day;
                DayEng = dayEng;
                DayVn = dayVn;
            }
            public int Day { get; set; }
            public string DayEng { get; set; }
            public string DayVn { get; set; }
        }
        static DayOfWeek[] Install()
        {
            return new DayOfWeek[]
            {
                new DayOfWeek(1,"MonDay","Thu 2"),
                new DayOfWeek(2,"Tuesday","Thu 3"),
                new DayOfWeek(3,"Wednesday","Thu 4"),
                new DayOfWeek(4,"Thursday","Thu 5"),
                new DayOfWeek(5,"Friday","Thu 6"),
                new DayOfWeek(6,"Saturday","Thu 7"),
                new DayOfWeek(7,"Sunday","Chu nhat"),
            };
        }
        static void Main()
        {
            while (true)
            {
                DayOfWeek[] DayArray = Install();
                Console.Write("Moi ban nhap day: ");
                int day = int.Parse(Console.ReadLine());
                if (day >= 1 && day <= 7)
                {
                    string result = CheckDay(DayArray, day);
                    Console.WriteLine(result);
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai. Vui long kiem tra lai");
                    continue;
                }
            }
        }

        private static string CheckDay(DayOfWeek[] days, int day)
        {
            foreach (var item in days)
            {
                if (item.Day == day)
                {
                    return $"{item.DayEng} - {item.DayVn}";
                }
            }
            return null;
        }
        */
        #endregion
        #region Bai 5
        /*
        struct Zodiac
        {
            public Zodiac(int inDay, int endDay, int inMonth, int endMonth, string nameZodiac)
            {
                InDay = inDay;
                EndDay = endDay;
                InMonth = inMonth;
                EndMonth = endMonth;
                NameZodiac = nameZodiac;
            }

            public int InDay { get; set; }
            public int EndDay { get; set; }
            public int InMonth { get; set; }
            public int EndMonth { get; set; }
            public string NameZodiac { get; set; }
        }
        static Zodiac[] Install()
        {
            return new Zodiac[]
            {
                new Zodiac(21,20,3,4,"Bach Duong"),
                new Zodiac(21,20,4,5,"Kim nguu"),
                new Zodiac(21,21,5,6,"Song Tu"),
                new Zodiac(22,22,6,7,"Cu Giai"),
                new Zodiac(23,22,7,8,"Su Tu"),
                new Zodiac(23,22,8,9,"Xu Nu"),
                new Zodiac(23,23,9,10,"Thien Binh"),
                new Zodiac(24,22,10,11,"Bo Cap"),
                new Zodiac(23,21,11,12,"Nhan Ma"),
                new Zodiac(22,19,12,1,"Ma Ket"),
                new Zodiac(20,18,1,2,"Bao Binh"),
                new Zodiac(19,20,2,3,"Song ngu"),
            };
        }

        private static string CheckZodiac(Zodiac[] zodiac, int day, int month)
        {
            foreach (var item in zodiac)
            {
                if (month == item.InMonth && day >= item.InDay)
                {
                    return item.NameZodiac;
                }
                if (month == item.EndMonth && day <= item.EndDay)
                {
                    return item.NameZodiac;
                }
            }
            return null;
        }

        static void Main()
        {
            while (true)
            {
                Zodiac[] zodiac = Install();
                var element = Console.ReadLine().Split(' ');
                int day = int.Parse(element[0]);
                int month = int.Parse(element[1]);
                string result = CheckZodiac(zodiac, day, month);
                Console.WriteLine(result);
                continue;
            }
        }
        */
        #endregion
        #region Bai 6
        /*
        struct FullName
        {
            public FullName(string name, string middleName, string surName)
            {
                NAME = name;
                MiddleName = middleName;
                SurName = surName;
            }
            public string NAME { get; set; }
            public string MiddleName { get; set; }
            public string SurName { get; set; }

            public override string ToString() => $"{SurName} {MiddleName} {NAME}";
        }
        struct AddRess
        {
            public AddRess(string ward, string disTrict, string city)
            {
                Ward = ward;
                DisTrict = disTrict;
                City = city;
            }
            public string Ward { get; set; }
            public string DisTrict { get; set; }
            public string City { get; set; }

            public override string ToString() => $"{Ward}, {DisTrict}, {City}";

        }
        struct Test
        {
            public Test(double tiengAnh, double toan, double lapTrinhC)
            {
                TiengAnh = tiengAnh;
                Toan = toan;
                LapTrinhC = lapTrinhC;
            }
            public double TiengAnh { get; set; }
            public double Toan { get; set; }
            public double LapTrinhC { get; set; }

            public double Sum()
            {
                double s = TiengAnh + Toan + LapTrinhC;
                return s;
            }
            public override string ToString() => $"{TiengAnh} , {Toan} , {LapTrinhC}";

        }
        struct Student
        {
            public Student(string MSV, FullName fullName, AddRess addRess, Test test, string major)
            {
                Msv = MSV;
                this.fullName = fullName;
                this.addRess = addRess;
                this.test = test;
                this.major = major;
            }
            public string Msv { get; set; }
            public FullName fullName { get; set; }
            public AddRess addRess { get; set; }
            public Test test { get; set; }
            public string major { get; set; }

            public override string ToString() => $"{Msv}- {major} - {fullName} - {addRess} - {test}  {test.Sum()}";

        }
        static void Main()
        {
            Student[] student = new Student[100];
            int indexStudent = 0;
            int x;
            do
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.");
                Console.WriteLine("2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn.Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.");
                Console.WriteLine("3) Sắp xếp danh sách sinh viên theo tổng điểm giảm dần.");
                Console.WriteLine("4) Sắp xếp danh sách sinh viên theo tên tăng dần.");
                Console.WriteLine("5) Sắp xếp danh sách sinh viên theo tổng điểm giảm dần, tên tăng dần, họ tăng dần.");
                Console.WriteLine("6) Tìm sinh viên theo tên.Hiển thị kết quả tìm được.");
                Console.WriteLine("7) Tìm sinh viên theo tỉnh.Hiển thị kết quả tìm được.");
                Console.WriteLine("8) Xóa sinh viên theo mã cho trước khỏi danh sách.");
                Console.WriteLine("9) Liệt kê số lượng sinh viên theo từng tỉnh.Sắp xếp giảm dần theo số lượng.");
                Console.WriteLine("10) Liệt kê số lượng sinh viên theo đầu điểm môn tiếng anh giảm dần.");
                Console.WriteLine("11) Sửa điểm môn lập trình C++cho sinh viên theo mã sinh viên.");
                Console.WriteLine("12) Kết thúc chương trình.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("Nhập lựa chọn của bạn: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Student studen = CreateStudent();
                        if (CheckMSV(student, studen , indexStudent))
                        {
                            Console.WriteLine("Ma sinh vien nay da ton tai !");
                        }
                        else
                        {
                            student[indexStudent++] = studen;
                        }
                        break;
                    case 2:
                        if (indexStudent > 0)
                        {
                            Console.WriteLine("Danh sach cac sinh vien :");
                            ShowStudent(student);

                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 3:
                        if (indexStudent > 0)
                        {
                            SortStudentToTest(ref student, indexStudent);
                            Console.WriteLine("Sinh vien da duoc sap xep theo vi tri giam dan theo tong diem !");
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 4:
                        if (indexStudent > 0)
                        {
                            SortStudentToName(ref student, indexStudent);
                            Console.WriteLine("Sinh vien da duoc sap xep theo vi tri  tang dan cua ten !");
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 5:
                        if (indexStudent > 0)
                        {
                            SortStudentToALl(ref student, indexStudent);
                            Console.WriteLine("Sinh vien da duoc sap xep theo vi tri giam dan theo tong diem va tang dan cua ten , ho !");
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 6:
                        if (indexStudent > 0)
                        {
                            Console.Write("Nhap ten sinh vien can tim: ");
                            string nameSeach = Console.ReadLine();
                            Student[] result = SeachStudent(student, indexStudent, nameSeach);
                            if (result[0].Msv == null)
                            {
                                Console.WriteLine("Khong co ket qua phu hop");
                            }
                            else
                            {
                                Console.WriteLine("Danh sach cac sinh vien can tim :");
                                ShowStudent(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 7:
                        if (indexStudent > 0)
                        {
                            Console.Write("Nhap tinh, thanh pho can tim: ");
                            string citySeach = Console.ReadLine();
                            Student[] result = SeachCity(student, indexStudent, citySeach);
                            if (result[0].Msv == null)
                            {
                                Console.WriteLine("Khong co ket qua phu hop");
                            }
                            else
                            {
                                Console.WriteLine("Danh sach cac sinh vien can tim :");
                                ShowStudent(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 8:
                        if (indexStudent > 0)
                        {
                            Console.Write("Nhap ma sinh vien can xoa: ");
                            string delete = Console.ReadLine();
                            bool check = DeleteStudent(student, ref indexStudent, delete);
                            if (check)
                            {
                                Console.WriteLine("Sinh vien da duoc xoa khoi danh sach !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim duoc MSV hop le !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 9:
                        if (indexStudent > 0)
                        {
                            ShowStudentCity(student, indexStudent);
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 10:
                        if (indexStudent > 0)
                        {
                            ShowStudenEng(student, indexStudent);
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 11:
                        if (indexStudent > 0)
                        {
                            Console.Write("Nhap ma sinh vien can sua diem Lap Trinh C: ");
                            string edit = Console.ReadLine();
                            bool check = EditTest(student, indexStudent, edit);
                            if (check)
                            {
                                Console.WriteLine("Diem lap trinh C da duoc thay doi !");
                            }
                            else
                            {
                                Console.WriteLine("MSV khong hop le !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du lieu rong~~~~");
                        }
                        break;
                    case 12:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng !");
                        break;
                    default:
                        Console.WriteLine("Sai lựa chọn !");
                        break;
                }
            }
            while (x != 12);

        }

        static bool CheckMSV(Student[] student, Student studen , int indexStudent)
        {
            for (int i = 0; i < indexStudent; i++)
            {
                if (student[i].Msv == studen.Msv)
                {
                    return true;
                }
            }
            return false;
        }

        static bool EditTest(Student[] student, int indexStudent, string edit)
        {
            for (int i = 0; i < indexStudent; i++)
            {
                if (student[i].Msv.CompareTo(edit) == 0)
                {
                    Console.Write("Nhap so diem can sua: ");
                    var a = double.Parse(Console.ReadLine());
                    student[i].test = new Test(student[i].test.TiengAnh, student[i].test.Toan,a);
                    return true;
                }
            }
            return false;
        }

        static void ShowStudenEng(Student[] student, int indexStudent)
        {
            Information[] statistic = new Information[student.Length];
            int statSize = 0;
            for (int i = 0; i < indexStudent; i++)
            {
                var statIndex = ContainerEng(statistic, statSize, student[i].test.TiengAnh);
                if (statIndex != -1)
                {
                    statistic[statIndex].amount++;
                    continue;
                }
                else
                {
                    statistic[statSize].testeng = student[i].test.TiengAnh;
                    statistic[statSize].amount = 1;
                    statSize++;
                }
            }
            SortStatisticEng(statistic, statSize);
            for (int i = 0; i < statSize; i++)
            {
                Console.WriteLine($"Diem tieng anh: {statistic[i].testeng} co {statistic[i].amount} sinh vien.");
            }
        }

        static void SortStatisticEng(Information[] statistic, int statSize)
        {
            for (int i = 0; i < statSize; i++)
            {
                for (int j = i + 1; j < statSize; j++)
                {
                    if (statistic[i].testeng < statistic[j].testeng)
                    {
                        Swap(ref statistic[i], ref statistic[j]);
                    }
                }
            }
        }

        static int ContainerEng(Information[] statistic, int statSize, double tiengAnh)
        {
            for (int i = 0; i < statSize; i++)
            {
                if (statistic[i].testeng == tiengAnh)
                {
                    return i;
                }
            }
            return -1;
        }

        public struct Information
        {
            public int amount { get; set; }
            public string city { get; set; }
            public double testeng { get; set; }
        }
        static void ShowStudentCity(Student[] student, int indexStudent)
        {
            Information[] statistic = new Information[indexStudent];
            int statSize = 0;
            for (int i = 0; i < indexStudent; i++)
            {
                var statIndex = ContainerIndex(statistic, statSize, student[i].addRess.City);
                if (statIndex != -1)
                {
                    statistic[statIndex].amount++;
                    continue;
                }
                else
                {
                    statistic[statSize].city = student[i].addRess.City;
                    statistic[statSize].amount = 1;
                    statSize++;
                }
            }
            SortStatistic(statistic, statSize);
            Console.WriteLine("Danh sach cac tinh thanh: ");
            for (int i = 0; i < statSize; i++)
            {
                Console.WriteLine($"{statistic[i].city} co {statistic[i].amount} sinh vien");
            }
        }

        static void SortStatistic(Information[] statistic, int statSize)
        {
            for (int i = 0; i < statSize; i++)
            {
                for (int j = i + 1; j < statSize; j++)
                {
                    if (statistic[i].amount < statistic[j].amount)
                    {
                        Swap(ref statistic[i], ref statistic[j]);
                    }
                }
            }
        }
        static int ContainerIndex(Information[] statistic, int statSize, string city)
        {
            for (int i = 0; i < statSize; i++)
            {
                if (statistic[i].city.ToLower().CompareTo(city.ToLower()) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool DeleteStudent(Student[] student, ref int indexStudent, string delete)
        {
            for (int i = 0; i < indexStudent; i++)
            {
                if (student[i].Msv.ToLower().CompareTo(delete.ToLower()) == 0)
                {
                    DeleteMSV(student, indexStudent, i);
                    indexStudent--;
                    return true;
                }
            }
            return false;
        }

        static void DeleteMSV(Student[] student, int indexStudent, int pos)
        {
            for (int i = pos; i < indexStudent; i++)
            {
                student[i] = student[i + 1];
            }
        }

        static Student[] SeachCity(Student[] student, int indexStudent, string citySeach)
        {
            Student[] checkCity = new Student[student.Length];
            int index = 0;
            for (int i = 0; i < indexStudent; i++)
            {
                if (student[i].addRess.City.ToLower().CompareTo(citySeach.ToLower()) == 0)
                {
                    checkCity[index++] = student[i];
                }
            }
            return checkCity;
        }

        static Student[] SeachStudent(Student[] student, int index, string nameSeach)
        {
            Student[] checkStudent = new Student[student.Length];
            int indexStudent = 0;
            for (int i = 0; i < index; i++)
            {
                if (student[i].fullName.NAME.ToLower() == nameSeach.ToLower())
                {
                    checkStudent[indexStudent++] = student[i];
                }
            }
            return checkStudent;
        }

        static void SortStudentToName(ref Student[] student, int indexStudent)
        {
            for (int i = 0; i < indexStudent; i++)
            {
                for (int j = i + 1; j < indexStudent; j++)
                {
                    var nameCompare = student[i].fullName.NAME.ToLower().CompareTo(student[j].fullName.NAME.ToLower());
                    if (nameCompare > 0)
                    {
                        Swap(ref student[i], ref student[j]);
                    }
                }
            }
        }

        static void Swap(ref Student a, ref Student b)
        {
            Student tmp = a;
            a = b;
            b = tmp;
        }

        static void Swap(ref Information a, ref Information b)
        {
            Information tmp = a;
            a = b;
            b = tmp;
        }

        static void SortStudentToALl(ref Student[] student, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    var s1 = student[i].test.Sum();
                    var s2 = student[j].test.Sum();
                    var nameCompare = student[i].fullName.NAME.ToLower().CompareTo(student[j].fullName.NAME.ToLower());
                    var fistNameCompare = student[i].fullName.SurName.ToLower().CompareTo(student[j].fullName.SurName.ToLower());
                    if (s1 < s2 || s1 == s2 && nameCompare > 0 || s1 == s2 && nameCompare == 0 && fistNameCompare > 0)
                    {
                        Swap(ref student[i], ref student[j]);
                    }
                }
            }
        }

        static void SortStudentToTest(ref Student[] student, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (student[i].test.Sum() < student[j].test.Sum())
                    {
                        Student tmp = student[i];
                        student[i] = student[j];
                        student[j] = tmp;
                    }
                }
            }
        }

        static void ShowStudent(Student[] student)
        {
            Console.WriteLine("****************************************************************************************************************************************************************");
            Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-15} * {3,-30} * {4,-15} * {5,-15} * {6,-15} * {7,-15} *",
                                            "Msv", "Major", "Full Name", "Address", "TiengAnh", "Toan", "LapTrinhC", "Tong diem"));
            Console.WriteLine("****************************************************************************************************************************************************************");
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].Msv == null)
                {
                    return;
                }
                Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-15} * {3,-30} * {4,-15} * {5,-15} * {6,-15} * {7,-15} *",
                student[i].Msv, student[i].major, student[i].fullName, student[i].addRess, student[i].test.TiengAnh, student[i].test.Toan, student[i].test.LapTrinhC, student[i].test.Sum()));
                Console.WriteLine("****************************************************************************************************************************************************************");
            }
        }

        static Student CreateStudent()
        {
            Student student = new Student();
            while (true)
            {
                Console.Write("Moi ban nhap ma sinh vien: ");
                string id = Console.ReadLine();
                Console.Write("Moi ban nhap chuyen nganh hoc: ");
                string major = Console.ReadLine();
                if (id == "" || major == "")
                {
                    Console.WriteLine("Hay nhap du thong tin !");
                    continue;
                }
                student.Msv = id;
                student.major = char.ToUpper(major[0]) + major.Substring(1);
                Console.Write("Moi ban nhap ho va ten: ");
                student.fullName = CreateFullName();
                Console.WriteLine("Moi ban nhap dia chi: ");
                student.addRess = CreateAddRess();
                Console.WriteLine("Moi ban nhap diem cac mon hoc: ");
                student.test = CreateTest();
                return student;
            }
        }

        static FullName CreateFullName()
        {
            while (true)
            {
                var element = Console.ReadLine().Split(' ');
                if (element.Length < 3)
                {
                    Console.WriteLine("Nhap lai ho ten:");
                    continue;
                }
                if (element[0] == "" || element[1] == "" || element[2] == "")
                {
                    Console.WriteLine("Nhap lai ho ten:");
                    continue;
                }
                else
                {
                    for (int i = 0; i < element.Length; i++)
                    {
                        element[i] = char.ToUpper(element[i][0]) + element[i].Substring(1);
                    }
                    FullName fullNameStudent = new FullName(element[2], element[1], element[0]);
                    return fullNameStudent;
                }
            }
        }

        static AddRess CreateAddRess()
        {
            while (true)
            {
                Console.Write("Moi ban nhap phuong(xa): ");
                string ward = Console.ReadLine();
                Console.Write("Moi ban nhap Quan(huyen): ");
                string disTrict = Console.ReadLine();
                Console.Write("Moi ban nhap Thanh pho(tinh): ");
                string city = Console.ReadLine();
                if (ward == "" || disTrict == "" || city == "")
                {
                    Console.WriteLine("Hay nhap du thong tin !");
                    continue;
                }
                else
                {
                    ward = char.ToUpper(ward[0]) + ward.Substring(1);
                    disTrict = char.ToUpper(disTrict[0]) + disTrict.Substring(1);
                    city = char.ToUpper(city[0]) + city.Substring(1);
                    AddRess address = new AddRess(ward, disTrict, city);
                    return address;
                }
            }
        }

        static Test CreateTest()
        {
            while (true)
            {
                Console.Write("Tieng Anh: ");
                string checkDiemTiengAnh = Console.ReadLine();
                Console.Write("Toan: ");
                string checkDiemToan = Console.ReadLine();
                Console.Write("Lap Trinh C: ");
                string checkDiemLapTrinhC = Console.ReadLine();

                if (double.TryParse(checkDiemTiengAnh, out double diemTiengAnh) == false || double.TryParse(checkDiemToan, out double diemToan) == false ||
                    double.TryParse(checkDiemLapTrinhC, out double diemLapTrinhC) == false)
                {
                    Console.WriteLine("Sai dinh dang !");
                    continue;
                }
                else if (diemTiengAnh > 10 || diemTiengAnh < 0 || diemToan > 10 ||
                    diemToan < 0 || diemLapTrinhC > 10 || diemLapTrinhC < 0)
                {
                    Console.WriteLine("Nhap sai diem vui long nhap lai !");
                    continue;
                }
                else
                {
                    return new Test(diemTiengAnh, diemToan, diemLapTrinhC);
                }
            }
        }
        */
        #endregion
        #region Bai 7
        /*
        struct AddString
        {
            public AddString(string STRING, int STRINGNUMBER)
            {
                this.STRING = STRING;
                this.STRINGNUMBER = STRINGNUMBER;
            }
            public string STRING { get; set; }
            public int STRINGNUMBER { get; set; }

            public override string ToString()
            {
                return $"{STRING} + {STRINGNUMBER}";
            }
        }
        static void Main()
        {
            var element = Console.ReadLine().Split(' ');
            AddString[] addStrings = new AddString[element.Length];
            int index = 0;
            CreateString(addStrings,ref index, element);
            ShowString(addStrings, index, element);
        }

        private static void ShowString(AddString[] addStrings, int index, string[] element)
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(addStrings[i]);
            }
        }

        private static int Cout(string key, string[] element)
        {
            int cout = 0;
            foreach (var item in element)
            {
                if (item.ToLower().CompareTo(key.ToLower()) == 0)
                {
                    cout++;
                }
            }
            return cout;
        }

        private static void CreateString(AddString[] addStrings, ref int index, string[] element)
        {
            for (int i = 0; i < element.Length; i++)
            {
                if (checkString(addStrings, index, element[i]))
                {
                    addStrings[index] = new AddString(element[i], Cout(element[i],element));
                    index++;
                }
            }
        }

        private static bool checkString(AddString[] addStrings, int index, string element)
        {
            for (int i = 0; i < index; i++)
            {
                if (addStrings[i].STRING.CompareTo(element) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        */
        #endregion
        #region Bai 9
        /*
        struct AddInt
        {
            public AddInt(int value , int amount) 
            {
                NUMBER= value;
                AMOUNT= amount;
            }
            public int NUMBER { get; set; }
            public int AMOUNT { get; set; }

            public override string ToString() => $"So {NUMBER} co {AMOUNT} xuat hien";
        }
        static void Main()
        {
            var element = Console.ReadLine().Split(' ');
            int[] number = new int[element.Length];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(element[i]);
            }
            AddInt[] addInts = new AddInt[element.Length];
            int index = 0;
            CreateNumber(addInts,ref index, number);
            SortArray(addInts, index);
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(addInts[i]);
            }

        }

        private static void SortArray(AddInt[] addInts, int index)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    if (addInts[i].AMOUNT < addInts[j].AMOUNT)
                    {
                        Swap(ref addInts[i], ref addInts[j]);
                    }
                }
            }
        }

        private static void Swap(ref AddInt addInt1, ref AddInt addInt2)
        {
            AddInt tmp = addInt1;
            addInt1 = addInt2;
            addInt2 = tmp;
        }

        private static void CreateNumber(AddInt[] addInts,ref int index, int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (CheckNumber(addInts, index, number[i]))
                {
                    addInts[index++] = new AddInt(number[i], Cout(number, number[i]));
                }
            }
        }

        private static int Cout(int[] number, int v)
        {
            int cout = 0;
            foreach (var item in number)
            {
                if (item == v)
                {
                    cout++;
                }
            }
            return cout;
        }

        private static bool CheckNumber(AddInt[] addInts, int index, int x)
        {
            for (int i = 0; i < index; i++)
            {
                if (addInts[i].NUMBER == x)
                {
                    return false;
                }
            }
            return true;
        }
        */
        #endregion
        #region Bai 12
        /*
        struct ATM
        {
            public ATM(int ID, int MONNEY, bool STATUS, int CARDMAIN)
            {
                this.ID = ID;
                this.MONNEY = MONNEY;
                this.STATUS = STATUS;
                this.CARDMAIN = CARDMAIN;
            }
            public int ID { get; set; }
            public long MONNEY { get; set; }
            public bool STATUS { get; set; }
            public int CARDMAIN { get; set; }

            public override string ToString() => $"{ID}-{MONNEY} - {(STATUS == true ? "Active" : "Banned")} - {CARDMAIN}";

            public string StatusCheck() => STATUS == true ? "Active" : "Lock";


        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ATM[] account = new ATM[100];
            int size = 0;
            int x;
            do
            {
                Console.WriteLine("1) Tạo mới tài khoản với các thông tin đầy đủ.\r\n" +
                    "2) Nạp tiền vào tài khoản.\r\n" +
                    "3) Truy vấn số dư.\r\n" +
                    "4) Rút tiền. Phí rút tiền 1100đ/lần.\r\n" +
                    "5) Chuyển tiền. Free chuyển khoản, hạn mức chuyển không quá 300tr/lần.\r\n" +
                    "6) Hiển thị danh sách tài khoản.\r\n" +
                    "7) Khóa tài khoản.\r\n" +
                    "8) Mở Khóa tài khoản.\r\n" +
                    "9) Kết thúc chương trình.");
                Console.Write("Moi ban lua chon: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        ATM acc = CreateACC();
                        if (CheckID(account, size, acc.ID))
                        {
                            Console.WriteLine("Tai khoan da ton tai !");
                        }
                        else
                        {
                            account[size++] = acc;
                            Console.WriteLine("Tai khoan cua ban da duoc kich hoat !");
                        }
                        break;
                    case 2:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CheckID(account, size, id))
                            {
                                AddMonney(account, size, id);
                                Console.WriteLine("Da nap tien vao tai khoan thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan hoac tai khoan cua ban da bi khoa!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CheckID(account, size, id))
                            {
                                ShowMoney(account, size, id);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan hoac tai khoan cua ban da bi khoa!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CheckID(account, size, id))
                            {
                                TakeMonney(account, size, id);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan hoac tai khoan cua ban da bi khoa!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CheckID(account, size, id))
                            {
                                SendMonney(account, size, id);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan hoac tai khoan cua ban da bi khoa!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            ShowAcc(account, size);
                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 7:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CheckID(account, size, id))
                            {
                                LockAcc(account, size, id);
                                Console.WriteLine("Da khoa tai khoan thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan hoac tai khoan cua ban da bi khoa!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 8:
                        if (size > 0)
                        {
                            Console.Write("Nhap so tai khoan: ");
                            int id = int.Parse(Console.ReadLine());
                            bool check = UnLockAcc(account, size, id);
                            if (check)
                            {
                                Console.WriteLine("Mo khoa tai khoan thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay tai khoan !");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Khong ton tai tai khoan nao !");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Tam biet va hen gap lai !");
                        break;
                    default:
                        Console.WriteLine("Lua chon sai !");
                        break;
                }
            }
            while (x != 9);
        }

        private static void SendMonney(ATM[] account, int size, int id)
        {
            Console.Write("Nhap so tai khoan nguoi nhan: ");
            int idSend = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tien (Han muc 300tr): ");
            long monneySend = int.Parse(Console.ReadLine());
            if (CheckID(account, size, idSend))
            {
                if (monneySend > 300000000)
                {
                    Console.WriteLine("So tien vut qua han muc !");
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (account[i].ID == id)
                        {
                            if (account[i].MONNEY < monneySend)
                            {
                                Console.WriteLine("So tien trong tai khoan khong du !");
                                return;
                            }
                            else
                            {
                                account[i].MONNEY -= monneySend;
                            }
                        }
                    }
                    for (int i = 0; i < size; i++)
                    {
                        if (account[i].ID == idSend)
                        {
                            account[i].MONNEY += monneySend;
                            Console.WriteLine("Chuyen khoan thanh cong!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan nguoi nhan");
            }
        }

        private static void TakeMonney(ATM[] account, int size, int id)
        {
            Console.Write("Nhap so tien muon rut: ");
            int takeMonney = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    if (account[i].MONNEY < takeMonney)
                    {
                        Console.WriteLine("So tien trong tai khoan khong du !");
                        return;
                    }
                    else
                    {
                        account[i].MONNEY = (account[i].MONNEY - 1100) - takeMonney;
                        Console.WriteLine("Rut tien thanh cong (phi 1100$)!");
                    }
                }
            }
        }

        private static void ShowMoney(ATM[] account, int size, int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    Console.WriteLine($"So du cua ban la: {account[i].MONNEY} $");
                }
            }
        }

        private static bool UnLockAcc(ATM[] account, int size, int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    account[i].STATUS = true;
                    return true;
                }
            }
            return false;
        }

        private static void LockAcc(ATM[] account, int size, int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    account[i].STATUS = false;
                }
            }
        }

        static void ShowAcc(ATM[] accoun, int index)
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-15} * {3,-15} *",
                                            "STK", "MONNEY", "Phi Duy Tri", "STATUS", "TiengAnh", "Toan", "LapTrinhC", "Tong diem"));
            Console.WriteLine("*************************************************************************");
            for (int i = 0; i < index; i++)
            {
                if (accoun[i].ID == 0)
                {
                    return;
                }
                Console.WriteLine(string.Format("* {0,-15} * {1,-15} * {2,-15} * {3,-15} *",
                accoun[i].ID, accoun[i].MONNEY, accoun[i].CARDMAIN, accoun[i].StatusCheck()));
                Console.WriteLine("*************************************************************************");
            }
        }

        private static bool CheckID(ATM[] account, int size, int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    if (account[i].STATUS == false)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        private static void AddMonney(ATM[] account, int size, int id)
        {
            Console.Write("Nhap so tien muon nap: ");
            int addMoney = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                if (account[i].ID == id)
                {
                    account[i].MONNEY += addMoney;
                }
            }
        }

        private static ATM CreateACC()
        {
            while (true)
            {
                Console.Write("Moi ban nhap so tai khoan: ");
                string checkID = Console.ReadLine();
                Console.Write("Nhap so tien: ");
                string checkMonney = Console.ReadLine();
                Console.Write("Phi duy tri the: ");
                string checkCardMain = Console.ReadLine();
                if (int.TryParse(checkID, out int id) == false || int.TryParse(checkMonney, out int monney) == false || int.TryParse(checkCardMain, out int cardMain) == false)
                {
                    Console.WriteLine("Sai dinh dang !");
                    continue;
                }
                bool status = true;
                return new ATM(id, monney, status, cardMain);
            }
        }
        */
        #endregion
    }
}
