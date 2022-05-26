using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber1
{
    public class Publisher
    {
        // definicija delegata
        public delegate void PublishMessageDel(string msg);

        // javna instanca delegata za koju mogu da se "zakače" osluškivači
        public PublishMessageDel publishMsg = null;
        
        // metoda za poziv delegata
        public void PublishMessage(string message)
        {
            publishMsg.Invoke(message);
        }
    }
}
