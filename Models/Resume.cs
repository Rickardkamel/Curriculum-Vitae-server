using System.Collections.Generic;

namespace Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public virtual IList<TimeStamp> TimeStamps { get; set; }
    }
}
