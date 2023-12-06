using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Sql.setting
{
    internal class Setting
    {
        public static Setting _Setting;
        public string Host { get; set; }
        public string Username { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }
        internal static void LoadSetting()
        {
            var file = @"data.json";
            try
            {
                if (File.Exists(file))
                {
                    using (var reader = new StreamReader(file, true))
                    {
                        Console.WriteLine("[SETTING] LOADING...");
                        var jText = reader.ReadToEnd();
                        var setting = JObject.Parse(jText);
                        _Setting = setting.ToObject<Setting>();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[SETTING] Success");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[SETTING] ERROR");
                Console.WriteLine(e);
            }

        }
    }
}
