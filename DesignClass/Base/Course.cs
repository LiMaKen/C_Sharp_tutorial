using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignClass.Base
{
    public class Course
    {
        private static int amount = 10000;
        public Course()
        {
            CourseId = amount++;
        }
        public Course(int numberOfStudent, string teacher, Subject subject) : this()
        {
            NumberOfStudent = numberOfStudent;
            Teacher = teacher;
            Subject = subject;
            NumberOfTranscrip = 0;
            TranScript = new TranScript[numberOfStudent];
        }

        public Subject Subject { get; set; }


        public int NumberOfStudent { get; set; }


        public string Teacher { get; set; }


        public TranScript[] TranScript { get; set; }


        public int NumberOfTranscrip { get; set; }


        public int CourseId { get; set; }
    }
}