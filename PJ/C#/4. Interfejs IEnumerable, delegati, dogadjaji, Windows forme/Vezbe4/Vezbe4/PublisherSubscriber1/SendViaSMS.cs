using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber1
{
    // Klasa za slanje obaveštenja SMS-om
    public class SendViaSMS
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Slanje SMS-om: " + msg);
        }
    }
}
