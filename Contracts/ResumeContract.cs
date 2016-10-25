using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ResumeContract
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public IList<TimeStampContract> TimeStamps { get; set; }
    }
}
