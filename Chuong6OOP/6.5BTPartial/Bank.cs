using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6.BankAll
{
    internal partial class BankAccount
    {
        public BankAccount()
        {

        }

        public BankAccount(int id, string name, long monney, string bankName, string date, string pin)
        {
            BankID = id;
            Name = name;
            Monney = monney;
            BankName = bankName;
            Date = date;
            Pin = pin;
        }

        private static long _idAmount = (long)Math.Pow(10, 13);

        private long _id;
        private string _pin;

        public long BankID
        {
            get => _id;
            set
            {
                if (value == 0)
                {
                    _id = _idAmount++;
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string Name { get; set; }
        public long Monney { get; set; }
        public string BankName { get; set; }
        public string Date { get; set; }

        public string Pin
        {
            get => _pin;
            set
            {
                if (value.Length == 6)
                {
                    _pin = value;
                }
                else
                {
                    Console.WriteLine("Ma pin khong hop le! Ma pin duoc nap mac dinh la : 000000");
                    _pin = "000000";
                }
            }
        }

        public partial void ShowMonney();


        public partial void AddMonney(long monney);


        public partial void TakeMonney(long monney);


        public partial void SendMonney(BankAccount orther, long monney);

    }

    internal partial class BankAccount
    {
        public partial void ShowMonney()
        {
            Console.WriteLine($"So du stk {BankID} la : {Monney}");
        }

        public partial void AddMonney(long monney)
        {
            if (monney > 0)
            {
                Monney += monney;
                Console.WriteLine("Nap tien thanh cong! ");
            }
            else
            {
                Console.WriteLine("Nap tien that bai !");
            }
        }

        public partial void TakeMonney(long monney)
        {
            if (monney > 0 && monney < Monney - 50000)
            {
                Monney -= monney;
                Console.WriteLine("Rut tien thanh cong!");
            }
            else { Console.WriteLine("Rut tien that bai !"); }
        }

        public partial void SendMonney(BankAccount orther, long monney)
        {
            if (monney > 0 && monney < Monney - 50000)
            {
                Monney -= monney;
                orther.Monney += monney;
                Console.WriteLine("Chuyen tien thanh cong!");
            }
            else
            {
                Console.WriteLine("Chuyen tien that bai!");
            }
        }
    }
}
