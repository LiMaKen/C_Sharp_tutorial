using Database.Sql;
using Database.Sql.setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BTStaff
{
    internal class Run
    {
        public static List<Staff> staffs = new List<Staff>();
        static void Main()
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=====Chương trình đang được khởi động=====");
            Console.ForegroundColor = ConsoleColor.White;
            Setting.LoadSetting();
            DatabaseConnect.InitConnection();
            int x;
            do
            {
                staffs = StaffData.SelectAllData();
                Console.WriteLine("1) Thêm mới một nhân viên vào danh sách nhân viên. Mã nhân viên là duy nhất, không được\r\nphép lặp lại.\r\n" +
               "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
               "3) Tính lương của các nhân viên trong danh sách.\r\n" +
               "4) Sắp xếp danh sách nhân viên theo mức lương thực lĩnh giảm dần.\r\n" +
               "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng giảm dần.\r\n" +
               "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
               "7) Tìm  và hiển thị thông tin nhân viên theo mức lương.\r\n" +
               "8) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
               "9) Xóa bỏ nhân viên có mã cho trước.\r\n" +
               "10) Tính tổng lương các nhân viên có trong danh sách.\r\n" +
               "11) Thoát chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        var checkCreate = UiltStaff.Create();
                        if  (checkCreate != null)
                        {
                            StaffData.InsertData(checkCreate);
                        }
                        break;
                    case 2:
                        if (staffs.Count == 0)
                        {
                            Console.WriteLine("Trong");
                        }
                        else
                        {
                            UiltStaff.ShowStaff(staffs);
                        }
                        break;
                    case 3:
                        UiltStaff.SumSalaryAll();
                        break;
                    case 4:
                        UiltStaff.SortStaffBySalary();
                        break;
                    case 5:
                        UiltStaff.SortStaffByWrokingDay();
                        break;
                    case 6:
                        UiltStaff.SeachStaffByStaffId();
                        break;
                    case 7:
                        UiltStaff.SeachStaffBySalary();
                        break;
                    case 8:
                        UiltStaff.UpdateSalary();
                        break;
                    case 9:
                        UiltStaff.DeleteStaffByStaffId();
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon!");
                        break;
                }
            } while (x != 11);


        }
    }
}
