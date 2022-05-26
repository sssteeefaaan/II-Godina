using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber3
{
    public class SendViaSMS
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Slanje SMS-om: " + msg);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishMsg += SendMessage;
            // pub.publishMsg("PROBLEM REŠEN, pub.publishMsg je sada event i kompajler prijavljuje grešku u ovoj liniji");
            // pub.publishMsg = null; // event rešava i drugi problem
        }
    }
}
