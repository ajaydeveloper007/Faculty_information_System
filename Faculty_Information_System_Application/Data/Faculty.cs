using System;
using System.Collections.Generic;

namespace Faculty_Information_System_Application.Data
{
    public class Faculty
    {
        public int FacultyId { get; set; }

        public virtual User User { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }

        public string MobileNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }

        public string Dob { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }

        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
        public virtual ICollection<Degree> Degrees { get; set; }
        public virtual ICollection<Grant> Grants { get; set; }

    }
}