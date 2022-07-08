using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class Message
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp;
        public string Msg { get; set; }

        public Message(string aMessage)
        {
            Id = Guid.NewGuid();   
            TimeStamp = DateTime.Now;
            Msg = aMessage;

        }


        public override string ToString()
        {
            return $"[{Id},{TimeStamp},{Msg}]";
        }
    }
}
