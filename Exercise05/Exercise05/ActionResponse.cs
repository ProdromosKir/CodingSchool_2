using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class ActionResponse
    {
        public Guid RequestId { get; set; }
        public Guid ResponseId { get; set; }
        public string Output { get; set; }

        public ActionResponse()
        {
            RequestId = Guid.NewGuid();
            ResponseId = Guid.NewGuid();
        }

    }
}
