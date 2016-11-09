using System.Collections.Generic;

namespace Contracts
{
    public class ResumeContract
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public IList<TimeStampContract> TimeStamps { get; set; }
    }
}
