using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public virtual IList<TimeStamp> TimeStamps { get; set; }
    }
}
