using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
class Run
{
    #region Bai 1
    /*
    static void Main()
    {
       
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Test 1: ");
            Console.WriteLine("Nhập vào một dòng dữ liệu: ");
            var line = Console.ReadLine();
            Test(line);
    }
    static void Test(string line)
    {
        try
        {
            Console.WriteLine("Số từ trong câu: " + CountWords(line));
            Console.WriteLine("----------------------------------------------");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static int CountWords(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException("input không được phép null.");
        }
        var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    */
    #endregion
    #region Bai 2
    /*
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        var input = Console.ReadLine().Split(' ');
        int[] array = new int[input.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        Console.WriteLine("Nhap vi tri can tim: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine($"phan tu co tai vi tri {index} la: {Test(array, index)}");
        Console.WriteLine("----------------------------------------------"); 
    }
    static int Test(int[] input, int index)
    {
        try
        {
            return input[index];
        }
        catch (IndexOutOfRangeException e)
        {
            return input[0];
            throw new IndexOutOfRangeException("Gioi han", e);
        }
        
    }
    */
    #endregion
    #region Bai 3

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] names = new string[10];
        object x = 100;
        object y = "Tu";
        object z = new object();
        Console.WriteLine("Test 1: ");
        Test(names, x);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Test 2: ");
        Test(names, y);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Test 3: ");
        Test(names, z);
        Console.WriteLine("--------------------------");
    }

    private static void Test(string[] names, object x)
    {
        try
        {
            Add(names, x);
            Console.WriteLine("==> Thêm thành công.");
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine(e);
        }
    }


    private static void Add(string[] names, object x)
    {
        if (x.GetType() != typeof(string))
        {
            throw new InvalidCastException("Không thể ép kiểu tham số x sang string.");
        }
        string xStr = x as string;
        names[0] = xStr;
    }
}
    
    #endregion




