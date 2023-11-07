using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.BankAll
{
    class BankUtil
    {
        public static BankAccount CreateAccount()
        {
            Console.Write("Nhap vao ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap vao so tien: ");
            long monney = long.Parse(Console.ReadLine());
            Console.Write("Nhap vao ten ngan hang: ");
            string bankName = Console.ReadLine();
            Console.Write("Nhap vao han su dung: ");
            string date = Console.ReadLine();
            Console.Write("Nhap vao ma pin: ");
            string pin = Console.ReadLine();
            return new BankAccount(0, name, monney, bankName, date, pin);
        }

        public static void ShowBankAccount(BankAccount[] account)
        {
            var titleID = "STK";
            var titleOwner = "Owner";
            var titleMonney = "Monney";
            var titleBankName = "Bank Name";
            var titleDate = "HSD";
            var titlePin = "Pin";
            Console.WriteLine($"{titleID,-15}{titleOwner,-15}{titleMonney,-15}{titleBankName,-15}{titleDate,-15}{titlePin,-15}");
            foreach (var item in account)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.BankID,-15}{item.Name,-15}{item.Monney,-15}{item.BankName,-15}{item.Date,-15}{item.Pin,-15}");
                }
            }
        }

        public static void ShowMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk can kiem tra: ");
            long id = long.Parse(Console.ReadLine());
            var acc = CheckAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine($"STK {acc.BankID} so du: {acc.Monney}");
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin tai khoan!");
            }

        }

        public static BankAccount CheckAccount(BankAccount[] bankAccounts, long id)
        {
            foreach (var item in bankAccounts)
            {
                if (item != null && item.BankID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void TakeMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk can rut tien : ");
            long id = long.Parse(Console.ReadLine());
            var acc = CheckAccount(bankAccounts, id);
            if (acc != null)
            {
                Console.WriteLine("Nhap ma pin: ");
                string pin = Console.ReadLine();
                if (acc.Pin.CompareTo(pin) == 0)
                {
                    Console.Write("Nhap so tien can rut: ");
                    long money = long.Parse(Console.ReadLine());
                    acc.TakeMonney(money);
                }
                else
                {
                    Console.WriteLine("Ma pin khong chinh xac !");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }

        public static void SendMonney(BankAccount[] bankAccounts)
        {
            Console.Write("Nhap vao stk : ");
            long id = long.Parse(Console.ReadLine());
            var acc1 = CheckAccount(bankAccounts, id);
            if (acc1 != null)
            {
                Console.WriteLine("Nhap ma pin: ");
                string pin = Console.ReadLine();
                if (acc1.Pin.CompareTo(pin) == 0)
                {
                    Console.Write("Nhap so tai khoan thu huong: ");
                    long id2 = long.Parse(Console.ReadLine());
                    var acc2 = CheckAccount(bankAccounts, id2);
                    if (acc2 != null)
                    {
                        Console.Write("Nhap so tien can chuyen: ");
                        long money = long.Parse(Console.ReadLine());
                        acc1.SendMonney(acc2, money);
                    }
                    else
                    {
                        Console.WriteLine("So tai khoan thu huong khong chinh xac!");
                    }
                }
                else
                {
                    Console.WriteLine("Ma pin khong chinh xac !");
                }
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
            }
        }
    }

    class Run
    {
       /* static void Main()
        {
            BankAccount[] bankAccounts = new BankAccount[100];
            int index = 0;
            int x;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
                    "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
                    "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
                    "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
                    "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 50k VNđ.\r\n" +
                    "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n7) Kết thúc chương trình.");
                Console.Write("Nhap vao lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        bankAccounts[index++] = BankUtil.CreateAccount();
                        break;
                    case 2:
                        if (index > 0)
                        {
                            BankUtil.ShowMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            BankUtil.ShowMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            BankUtil.TakeMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            BankUtil.SendMonney(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 6:
                        if (index > 0)
                        {
                            BankUtil.ShowBankAccount(bankAccounts);
                        }
                        else
                        {
                            Console.WriteLine("Trong!");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Sai lua chon!");
                        break;
                }
            } while (x != 7);
        }*/
    }
}
