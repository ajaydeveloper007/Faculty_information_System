using System;

namespace Faculty_Information_System_Application.Data
{
    public class Publication
    {
        public int PublicationId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public string PublicationTitle { get; set; }

        public string ArticleName { get; set; }

        public string PublisherName { get; set; }
        public DateTime CitationDate { get; set; }

    }
}