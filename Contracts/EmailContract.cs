using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class EmailContract
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
