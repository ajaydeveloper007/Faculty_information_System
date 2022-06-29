using System;

namespace Faculty_Information_System_Application.Data
{
    public class Grant
    {
        public int GrantId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public string GrantTitle { get; set; }
        public string GrantDescription { get; set; }
    }
}