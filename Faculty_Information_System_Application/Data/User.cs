using System;
using System.Collections.Generic;


namespace Faculty_Information_System_Application.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<Adminstrator> Adminstrators { get; set; }
    }
}