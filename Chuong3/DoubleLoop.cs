using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    internal class DoubleLoop
    {
        static void Main()
        {
            /* var data = Console.ReadLine().Split(' ');
             int width = int.Parse(data[0]);
             int height = int.Parse(data[1]);
             // vẽ hình chữ nhật đặc bằng các dấu *
             for (int i = 1; i & lt;= width; i++)
             {
                for (int j = 1; j & lt;= height; j++)
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }*/
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int k = int.Parse(data[2]);
            bool isExisted = false;
            // tìm số đầu tiên chia hết cho k trong đoạn [a, b]
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.WriteLine(i);
                    isExisted = true;
                    break; // để kết thúc vòng lặp hoặc sử dụng return để kết thúc tất cả các dòng ở sau nó ; Continue để bỏ qua lần lặp hiện tại để chuyển qua lần lặp kế tiếp
                }
            }
            if (!isExisted)
            {
                Console.WriteLine("Khong ton tai kêt qua thoa man");
            }
            Console.WriteLine("Cac lenh tiep theo...");
        }
    }
}
