using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber2
{
    public class SendViaSMS
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Slanje SMS-om: " + msg);
        }

        public void Subscribe(Publisher pub)
        {
            // pub.publishMsg += SendMessage;
            // pub.publishMsg("PROBLEM, subscriber okida kreiranje slanje poruke!!!");
            // pub.publishMsg = null; // DRUGI PROBLEM, delegat se postavlja na null
                                 // brišu se svi prethodni subscriber-i
                                 // i dobija se null reference izuzetak
        }
    }
}
