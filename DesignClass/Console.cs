using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace ConsoleLog.New
{
    public static class ConsoleNew
    {
        public static void Log(string status, string text , bool trace = true)
        {
            try
            {
                if (status == "Loi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text,ConsoleColor.Red);
                    if (trace == true)
                    {
                        DateTime localDate = DateTime.Now;
                        using (StreamWriter file = new StreamWriter(@"", true))
                        {
                            file.WriteLine("[" + localDate.ToString() + "]\n" + text + "\n");
                        }
                    }
                }
                else if (status == "Canh Bao")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(text, ConsoleColor.Yellow);
                }
                else if(status == "Thong Bao")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(text, ConsoleColor.Blue);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text, ConsoleColor.Green);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception) { }
        }
    }
}
