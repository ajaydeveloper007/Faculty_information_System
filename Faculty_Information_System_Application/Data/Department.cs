using System;
using System.Collections.Generic;


namespace Faculty_Information_System_Application.Data
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}