using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
    #region Bai 1
    /*
    class Staff
    {
        public Staff(string mNV, string nAME, int pHONENUMBER, long wAGE)
        {
            MNV = mNV;
            NAME = nAME;
            PHONENUMBER = pHONENUMBER;
            WAGE = wAGE;
        }

        public string MNV { get; set; }
        public string NAME { get; set; }
        public int PHONENUMBER { get; set; }
        public long WAGE { get; set; }

        public override string ToString() => $"{MNV} - {NAME} - {WAGE} -";

        public void CheckIn(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} checkin luc {x}");
        }
        public void Checkout(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} checkout luc {x}");
        }
        public void DoWork(string x)
        {
            Console.WriteLine($"Nhan vien {NAME} dang lam {x}");
        }
        public double SumWage(double workingDay)
        {
            double bonus = (workingDay >= 22) ? 0.2*WAGE: 0;       
            return (WAGE * workingDay / 22) + bonus;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = CreateStaff();

            staff.CheckIn("8:30");
            staff.Checkout("17:30");
            staff.DoWork("Danh nhau voi code");
            Console.WriteLine("Tong luong: " + staff.SumWage(22)); 

        }

        public static Staff CreateStaff()
        {
            Console.Write("Moi ban nhap ma NV: ");
            string mnv = Console.ReadLine();
            Console.Write("Moi ban nhap ho va ten:");
            string name = Console.ReadLine();
            Console.Write("Moi ban nhap so dien thoai: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap muc luong: ");
            long wage = long.Parse(Console.ReadLine());
            return new Staff(mnv, name, phone, wage);

        }
    }
    */
    #endregion
    #region Bai 2
    /*
    class Matrix
    {
        public int Row { get; set; }
        public int Colum { get; set; }
        public int[,] data { get; set; }

        public Matrix(int row, int colum)
        {
            this.Row = row;
            this.Colum = colum;
            data = new int[row, colum];
        }

        public void GetData()
        {
            Console.WriteLine($"So hang {Row} x So cot {Colum}");
            for (int i = 0; i < Row; i++)
            {
                var element = Console.ReadLine().Split(' ');
                for (int j = 0; j < Colum; j++)
                {
                    data[i,j] = Convert.ToInt32(element[j]);
                }
                Console.WriteLine();
            }
        }

        public void ShowMaTrix()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j  = 0; j < Colum; j++)
                {
                    Console.Write(data[i,j]);
                }
                Console.WriteLine();
            }
        }
        public Matrix SumMatrix(Matrix other)
        {
            if (other == null || other.Row != this.Row || other.Colum != this.Colum)
            {
                return null; 
            }
            Matrix result = new Matrix(Row, Colum);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Colum; j++)
                {
                    result.data[i, j] = data[i, j] + other.data[i, j];
                }
            }
            return result;
        }
        public Matrix Mul(Matrix other)
        {
            if (Colum != other.Row)
            {
                return null;
            }
            Matrix result = new Matrix(Row, other.Colum);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < other.Colum; j++)
                {
                    for (int k = 0; k < Colum; k++)
                    {
                        result.data[i, j] += data[i, k] * other.data[k, j];
                    }
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixA = new Matrix(3, 4);
            Matrix matrixB = new Matrix(3, 4);
            Matrix matrixC = new Matrix(4, 3);
            Console.WriteLine("Nhap ma tran A: ");
            matrixA.GetData();
            Console.WriteLine("Nhap ma tran B: ");
            matrixB.GetData();
            Console.WriteLine("Nhap ma tran C: ");
            matrixC.GetData();
            Console.WriteLine("Ma tran A: ");
            matrixA.ShowMaTrix();
            Console.WriteLine("Ma tran B: ");
            matrixB.ShowMaTrix();
            Console.WriteLine("Ma tran C: ");
            matrixC.ShowMaTrix();
            Console.WriteLine("Tong cua 2 ma tran la:");
            Matrix result = matrixA.SumMatrix(matrixB);
            result.ShowMaTrix();
            var product = matrixA.Mul(matrixC);
            Console.WriteLine("Ma tran tich A x C: ");
            product.ShowMaTrix();
        }
    }
    */
    #endregion
    #region Bai 4

    class BankAccount
    {
        public int IDBANK { get; set; }
        public string NAME { get; set; }
        public long MONNEY { get; set; }
        public string BANKNAME { get; set; }
        public string DATE { get; set; }
        public int PIN { get; set; }

        public BankAccount(int idBank, string name, long monney, string bankName, string date, int pin)
        {
            IDBANK = idBank;
            NAME = name;
            MONNEY = monney;
            BANKNAME = bankName;
            DATE = date;
            PIN = pin;
        }

        public void AddMonney(long cash)
        {
            if (cash > 0)
            {
                MONNEY += cash;
            }
            
        }

        public string TakeMoney(long cash)
        {
            if (cash < MONNEY + 50000 && MONNEY > 0)
            {
                MONNEY -= cash;
                return "Rut tien thanh cong !";
            }
            else
            {
                return "Rut tien that bai !";
            }
        }

        public string SendMonney(BankAccount other, long cash)
        {
            if (cash < MONNEY + 50000 && MONNEY > 0)
            {
                MONNEY -= cash;
                other.MONNEY += cash;
                return "Chuyen tien thanh cong !";
            }
            else
            {
                return "Chuyen tien that bai, so du cua ban khong du !";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x;
            BankAccount[] account = new BankAccount[100];
            int index = 0;
            do
            {
                Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào mảng.\r\n" +
               "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
               "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
               "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút.\r\n" +
               "5) Chuyển tiền từ tài khoản x sang tài khoản y.\r\n" +
               "6) Hiển thị danh sách tài khoản ra màn hình.\r\n" +
               "7) Kết thúc chương trình.");
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        BankAccount account2 = GetData();
                        if (CheckID(account, account2.IDBANK, index))
                        {
                            account[index++] = account2;
                            Console.WriteLine("Tao tai khoan thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("So tai khoan da ton tai !");
                        }
                        break;
                    case 2:
                        if (index > 0)
                        {
                            bool check = ShowMonney(account, index);
                            if (!check)
                            {
                                Console.WriteLine("Khong tim thay thong tin tai khoan !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 3:
                        if (index > 0)
                        {
                            bool check = AddMonneyToID(account, index);
                            if (check)
                            {
                                Console.WriteLine("Da nap tien vao tai khoan thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay thong tin tai khoan !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 4:
                        if (index > 0)
                        {
                            bool check = TakeMoneyToID(account, index);
                            if (!check)
                            {
                                Console.WriteLine("Thong tin khong hop le !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 5:
                        if (index > 0)
                        {
                            bool check = SendMoneyToID(account, index);
                            if (!check)
                            {
                                Console.WriteLine("Thong tin khong hop le !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong rong !");
                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Sai lua chon !");
                        break;
                }
            } while (x != 7);
        }

        private static bool TakeMoneyToID(BankAccount[] account, int index)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap ma Pin :");
            int pin = int.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                if (account[i].IDBANK == id && account[i].PIN == pin)
                {
                    Console.Write("Moi ban nhap so tien can rut :");
                    long cash = int.Parse(Console.ReadLine());
                    Console.WriteLine(account[i].TakeMoney(cash));
                    return true;
                }
            }
            return false;
        }
    
            
        private static bool SendMoneyToID(BankAccount[] account, int index)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap ma Pin :");
            int pin = int.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                if (account[i].IDBANK == id && account[i].PIN == pin)
                {
                    Console.Write("Moi ban nhap so tai khoan ngoi thu huong :");
                    int idSend = int.Parse(Console.ReadLine());
                    Console.Write("Moi ban nhap so tien can chuyen :");
                    long cash = int.Parse(Console.ReadLine());
                    for (int j = 0; j < index; j++)
                    {
                        if (account[j].IDBANK == idSend)
                        {
                            Console.WriteLine(account[i].SendMonney(account[j], cash));
                            return true;
                        }                    
                    }
                }
            }
            return false;
        }

        private static bool AddMonneyToID(BankAccount[] account, int index)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap co tien muon nap: ");
            long cash = long.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                if (account[i].IDBANK == id)
                {
                    if (cash > 0)
                    {
                        account[i].AddMonney(cash);
                        return true;
                    }  
                }
            }
            return false;
        }

        private static bool ShowMonney(BankAccount[] account, int index)
        {
            Console.Write("Moi ban nhap so tai khoan :");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                if (account[i].IDBANK == id)
                {
                    Console.WriteLine($"So du cua ban la : {account[i].MONNEY}");
                    return true;
                }
            }
            return false;
        }

        public static bool CheckID(BankAccount[] acc, int id, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (acc[i].IDBANK == id)
                {
                    return false;
                }
            }
            return true;
        }
        public static BankAccount GetData()
        {
            while (true)
            {
                Console.Write("Nhap vao so tai khoan :");
                string checkID = Console.ReadLine();
                Console.WriteLine("Nhap vao ten tai khoan");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap vao so tien :");
                string checkMonney = Console.ReadLine();
                Console.WriteLine("Nhap vao ngan hang phat hanh");
                string bankName = Console.ReadLine();
                Console.WriteLine("Nhap vao thoi diem het hieu luc: ");
                string date = Console.ReadLine();
                Console.WriteLine("Nhap vao ma PIN: ");
                string checkPin = Console.ReadLine();
                if (checkID == "" || name == "" || checkMonney == "" || bankName == "" || date == "" || checkPin == "")
                {
                    Console.WriteLine("Nhap du cac thong tin");
                    continue;
                }
                else if (int.TryParse(checkID, out int id) == false || long.TryParse(checkMonney, out long monney) == false || int.TryParse(checkPin, out int pin) == false)
                {
                    Console.WriteLine("Sai dinh dang");
                    continue;
                }
                else if (monney < 0)
                {
                    Console.WriteLine("So tien phai lon hon 0");
                    continue;
                }
                else if (pin.ToString().Length != 6)
                {
                    Console.WriteLine("Ma pin phai du 6 so");
                    continue;
                }
                else
                {
                    return new BankAccount(id, name, monney, bankName, date, pin);
                }
            }
        }
    }

    #endregion
}
