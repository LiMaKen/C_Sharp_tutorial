using Chuong6OOP.ExtensionMethodBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6OOP.ExtensionMethod
{
	class Run
	{
        static void Main()
        {
            string input = "Hello World xin chao cac ban minh ten la Tu";
            Console.WriteLine($"So luong tu la: {input.DemSoLanXuatHien()}");
            Console.WriteLine($"Sau khi viet hoa chu cai dau: {input.VietHoaChuCaiDauTien()}");
            Console.WriteLine($"Sau khi sap xep theo tu a -> z : {input.SapXepTuADenZ()}");
            Console.WriteLine($"Sau khi sap xep tang dan do dai tu: {input.SapXepTheoDoDai()}");
            Console.WriteLine($"Tim tu bat dau o vi tri K: {input.TimChuCaiBatDauTuK('w')}");
            Console.WriteLine($"Tim va tra ve do dai nhat cua tu: {input.TimDoDaiLonNhat()}");
            Console.WriteLine($"Tim do dai nho nhat: {input.TimDoDaiNhoNhat()}");
            Console.WriteLine($"Dao nguoc danh sach: {input.DaoNguoc()}");
            int x = 5000;
            Console.WriteLine($"Chuyen so sang binary: {x} => {x.SoSangNhiPhan()}");
            int y = 5000;
            Console.WriteLine($"Chuyen so sang hexa: {y} => {x.SoSangHexa()}");
            string binary = "10110101001010100";
            Console.WriteLine($"Chuyen binary sang int: {binary} => {binary.NhiPhanSangInt()}");
            string hexa = "6cadfe3";
            Console.WriteLine($"Chuyen hexa sang int: {hexa} => {hexa.HexaSangInt()}");


        }
    }
}
