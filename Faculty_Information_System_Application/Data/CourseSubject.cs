using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Faculty_Information_System_Application.Data
{
    public class CourseSubject
    {
        [Key]
        public int CourseSubjectId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }     
    }
}