using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber3
{
    public class SendViaEmail
    {
        public void SendEmail(string msg)
        {
            Console.WriteLine("Slanje mejlom: " + msg);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishMsg += SendEmail;
        }
    }
}
