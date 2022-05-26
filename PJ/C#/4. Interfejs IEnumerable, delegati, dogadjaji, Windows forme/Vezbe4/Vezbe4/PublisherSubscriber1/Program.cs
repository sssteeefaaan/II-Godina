using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber1
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
            // dodavanje osluškivača publisher-u
            publisher.publishMsg += sendEmail.SendEmail;
            publisher.publishMsg += sendSMS.SendMessage;
            // PROBLEM: osluškivači ne kontorlišu da li su pretplaćeni na 
            // događaj, druga klasa može da ih pretplati
            publisher.PublishMessage("Zdravo, imate nova obaveštenja.");
        }
    }
}
