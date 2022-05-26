using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber3
{
    public class Publisher
    {
        // definicija delegata
        public delegate void PublishMessageDel(string msg);

        // umesto obične instance delegata pravi se event 
        // za koji mogu da se "zakače" osluškivači
        public event PublishMessageDel publishMsg = null;
        
        // metoda za poziv delegata
        public void PublishMessage(string message)
        {
            if (publishMsg != null)
                publishMsg.Invoke(message);
        }
    }
}
