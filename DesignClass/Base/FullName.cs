using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignClass.Base
{
    public class FullName
    {
        public FullName()
        {

        }
        public FullName(string name)
        {
            SetFullName(name);
        }

        public string FristName { get; set; }


        public string LastName { get; set; }

        public string MidName { get; set; }

        public void SetFullName(string name)
        {
            var data = name.Split(' ');
            FristName = data[0];
            LastName = data[1];
            var mid = "";
            for (int i = 1; i < data.Length - 1; i++)
            {
                mid += data[i] + " ";
            }
            MidName = mid.TrimEnd();
        }
        public override string ToString() => $"{FristName} {MidName} {LastName}";


    }
}