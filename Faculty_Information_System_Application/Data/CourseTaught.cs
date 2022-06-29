using System;

namespace Faculty_Information_System_Application.Data
{
    public class CourseTaught
    {
        public int CourseTaughtId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Subject Subject { get; set; }

        public DateTime FirstDateTaught { get; set; }

    }
}