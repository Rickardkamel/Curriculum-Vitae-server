using System;

namespace Models
{
    public class TimeStamp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }
    }
}