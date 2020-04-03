using System;
using System.Collections.Generic;
using System.Text;

namespace JasonFinalExam.Pocos
{
    public class Enrollment : IPoco
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
