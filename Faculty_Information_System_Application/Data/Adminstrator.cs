using System;

namespace Faculty_Information_System_Application.Data
{
    public class Adminstrator
    {
        public int AdminstratorID { set; get; }
        public virtual User UserID { set; get; }
        public string AdminFullName { set; get; }

    }
}