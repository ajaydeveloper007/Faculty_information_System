using System;
using System.ComponentModel.DataAnnotations;

namespace Faculty_Information_System_Application.Data
{
    public class Degree
    {
        [Key]
        public int DegreeId { set; get; }
        public virtual Faculty Faculty { set; get; }
        public string DegreeName { set; get; }
        public DateTime DegreeYear { set; get; }
        public string Grade { set; get; }

    }
}