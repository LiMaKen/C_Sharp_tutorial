using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignClass.Base
{
    public class TranScript : IComparable<TranScript>
    {
        private static int amount = 1000;
        public TranScript()
        {
            TranScriptId = amount++;
        }
        public TranScript(float test1, float test2, float test3, Student student)
        {
            Test1 = test1;
            Test2 = test2;
            Test3 = test3;
            Student = student;
        }

        public Student Student { get; set; }


        public int TranScriptId { get; set; }


        public float Test1 { get; set; }


        public float Test2 { get; set; }


        public float Test3 { get; set; }


        public float SumTest { get; set; }

        public int CompareTo(TranScript other)
        {
            if (other.SumTest == this.SumTest) return 0;
            else if (SumTest < other.SumTest) return -1;
            else return 1;
        }

        public float SumTestTb()
        {
            float he1 = Test1 * 0.1f;
            float he2 = Test2 * 0.3f;
            float he3 = Test3 * 0.6f;
            SumTest = (float)(he1 + he2 + he3);
            return SumTest;
        }
    }
}