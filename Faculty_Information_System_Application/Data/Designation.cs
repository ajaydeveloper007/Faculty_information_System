
using System;
using System.Collections.Generic;


namespace Faculty_Information_System_Application.Data
{
    public class Designation
    {
        public int DesignationId { set; get; }
        public string DesignationName { set; get; }

        public virtual ICollection<Faculty> Faculties { set; get; }
    }
}