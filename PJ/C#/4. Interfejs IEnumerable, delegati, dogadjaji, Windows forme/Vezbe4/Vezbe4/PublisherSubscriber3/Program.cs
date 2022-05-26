using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // instanca publisher-a
            Publisher publisher = new Publisher();
            // i dve instance osluškivača
            SendViaEmail sendEmail = new SendViaEmail();
            SendViaSMS sendSMS = new SendViaSMS();
            // osluškivači se sami pretplaćuju na događaje publisher-a
            sendEmail.Subscribe(publisher);
            sendSMS.Subscribe(publisher);

            publisher.PublishMessage("Zdravo, imate nova obaveštenja.");
        }
    }
}
