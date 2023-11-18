using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignClass.Base
{
    public class Subject
    {
        private static int amount = 1000;
        public Subject()
        {
            SubjectId = amount++;
        }

        public Subject(string subjectName, int numberOfCredit) : this()
        {
            SubjectName = subjectName;
            NumberOfCredit = numberOfCredit;
        }

        public string SubjectName { get; set; }


        public int NumberOfCredit { get; set; }


        public int SubjectId { get; set; }

    }
}