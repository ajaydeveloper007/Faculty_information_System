using System;
using System.Collections.Generic;


namespace Faculty_Information_System_Application.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseCredits { get; set; }

        public virtual Department DeptId { get; set; }

        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }


    }
}