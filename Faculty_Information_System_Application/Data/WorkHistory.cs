using System;

namespace Faculty_Information_System_Application.Data
{
    public class WorkHistory
    {
        public int WorkHistoryId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public string Organisation { get; set; }
        public string JobTitle { get; set; }
        public DateTime JobBeginDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public string JobResponsibilities { get; set; }
        public string JobType { get; set; }

    }
}