using System;
using System.Collections.Generic;

namespace Faculty_Information_System_Application.Data
{
    public class Subject
    {
        public int SubjectID { set; get; }
        public string SubjectName { set; get; }

        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}