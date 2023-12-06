using System;
using System.IO;
using System.Text;
class Run
{
    static void Main()
    {
        // DirectoryInfo
        var parttern = @"C:\Users\Admin\Desktop\học tập\Csharp\FileIO\TestIO";
        DirectoryInfo dir = new DirectoryInfo(parttern);
        dir.Create();
        // FileInfo
        FileInfo file = new FileInfo(@"C:\Users\Admin\Desktop\học tập\Csharp\FileIO\TestIO\input.txt");
        file.Create();

        //Đọc dữ liệu bằng lớp File
        Console.OutputEncoding = Encoding.UTF8;
        var fileInput = @"C:\Users\Admin\Desktop\học tập\Csharp\FileIO\input.txt";
        if (File.Exists(fileInput))
        {
            var data1 = File.ReadAllLines(fileInput);
            foreach (var item in data1)
            {
                Console.WriteLine(item);
            }
        }
        else { Console.WriteLine("Khong co file"); }
        //Đọc dữ liệu bằng đối tượng Fileinfo
        FileInfo fileinput = new FileInfo("input.txt");
        using (var fs = file.Open(FileMode.Open, FileAccess.Read)) // đóng dữ liệu sau khi đọc xong
        {
            int numOfByteToRead = (int)file.Length;
            byte[] data2 = new byte[numOfByteToRead];
            int offset = 0;
            while (numOfByteToRead > 0)
            {
                int numOfByteRead = fs.Read(data2, offset, (int)file.Length);
                offset += numOfByteRead;
                numOfByteToRead -= numOfByteRead;
                Console.Write(Encoding.UTF8.GetString(data2));
            }
        }
        // đọc dữ liệu với lớp SteamReder
        // FileInfo file1 = new FileInfo("input.txt");
        using (var streamReader = new StreamReader(@"C:\Users\Admin\Desktop\học tập\Csharp\FileIO\input.txt", true)) // đọc xong đóng dữ liệu
        {
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line);

            }
        }
        //Ghi dữ liệu với lớp File
        var data3 = new string[] {
               "Đây là dòng dữ liệu thứ nhất.",
               "Đây là dòng dữ liệu thứ hai.",
               "Đây là dòng dữ liệu thứ ba.",
               "Đây là dòng dữ liệu thứ tư.",
               "Đây là dòng dữ liệu thứ năm.",
               "Dòng dữ liệu cuối cùng đây"
            };
        File.WriteAllLines("output.txt", data3);
        // Ghi dữ liệu với SteamWiter
        var data = new string[] {
                "Đây là dòng dữ liệu thứ nhất.",
                "Đây là dòng dữ liệu thứ hai.",
                "Đây là dòng dữ liệu thứ ba.",
                "Đây là dòng dữ liệu thứ tư.",
                "Đây là dòng dữ liệu thứ năm.",
                "Dòng dữ liệu cuối cùng đây"
            };
       // FileInfo file2 = new FileInfo("output2.txt");
        // cho phép tự động đóng file sau khi thực hiện thao tác xong
       // using (Stream stream = file.OpenWrite())
       
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\học tập\Csharp\FileIO\output.txt", true)) // ghi dữ liệu vào cuối dòng rồi tự động đóng file
            {
                foreach (var item in data)
                {
                    sw.WriteLine(item);
                }
            }
        
    }
}