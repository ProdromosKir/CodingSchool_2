using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class ActionRequest
    {
        public Guid RequestId { get; set; }
        public string Input { get; set; }
        public ActionEnum Action;

        public ActionRequest(ActionEnum anAction)
        {
            RequestId = Guid.NewGuid();
            Action = anAction;
        }
    }
}
