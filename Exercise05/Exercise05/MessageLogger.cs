using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class MessageLogger
    {
        public Message[] Messages;


        public void ReadAll()
        {
            foreach(var message in Messages)
                Console.WriteLine(message.Msg);
        }

        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
        }

        public void Write(string aMessage)
        {
            var messageObj = new Message(aMessage);
            Messages.Append(messageObj);
        }
    }
}
