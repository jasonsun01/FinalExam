using System;
using System.Collections.Generic;
using System.Text;

namespace JasonFinalExam.Pocos
{
    public class Course : IPoco
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
