using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber1
{
    // Klasa za slanje obaveštenja e-mail-om
    public class SendViaEmail
    {
        public void SendEmail(string msg)
        {
            Console.WriteLine("Slanje mejlom: " + msg);
        }
    }
}
