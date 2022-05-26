using System;
using System.Text;

namespace DateTimeStruktura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Minimalna vrednost koju je moguće predstaviti:");
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine("Maksimalna vrednost koju je moguće predstaviti:");
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine();

            // Konstruktor koji postavlja godinu, mesec, datum, sate, minute i sekunde
            DateTime datum1 = new DateTime(2001, 2, 3, 7, 10, 24);
            Console.WriteLine("ToString: " + datum1);
            Console.WriteLine("ToShortDateString: " + datum1.ToShortDateString());
            Console.WriteLine("ToLongDateString: " + datum1.ToLongDateString());
            Console.WriteLine("ToShortTimeString: " + datum1.ToShortTimeString());
            Console.WriteLine("ToLongTimeString: " + datum1.ToLongTimeString());
            Console.WriteLine();

            // Kao i osnovni numerički tipovi podataka DateTime ima statičku Parse 
            // metodu za kreiranje instance DateTime parsiranjem stringa
            string datumString = "2/3/2001 7:10:24 AM";
            DateTime datum2 = DateTime.Parse(datumString);
            Console.WriteLine(datum2);
            Console.WriteLine();

            // Konstruktor bez argumenata kreira instancu iste vrednosti kao i 
            // statički property DateTime.MinValue
            DateTime prazanDatum = new DateTime();
            Console.WriteLine("Rezultat poziva konstruktora bez argumenata: " + prazanDatum);
            Console.WriteLine();

            // Konstruktor koji postavlja samo godinu, mesec i dan. Vremenska komponenta
            // je u tom slučaju 0:00 tj. 12:00 AM. 
            DateTime samoDatum = new DateTime(2002, 10, 18);
            Console.WriteLine("Datum kreiran bez vremena: " + samoDatum);
            Console.WriteLine();

            // Konstruktor koji prihvata broj tikova od 1.1.0001. u 0:00, 1 tick = 100ns
            // 10^8 tikova = 10 sekundi od DateTime.MinValue
            DateTime vremeIzTikova = new DateTime(100000000);
            Console.WriteLine("10^8 tikova od DateTime.MinValue: " + vremeIzTikova);
            Console.WriteLine();

            // Konstruktor koji postavlja godinu, mesec, datum, sate, minute, sekunde i milisekunde
            DateTime datumVremeSaMilisekundama = new DateTime(2010, 12, 15, 5, 30, 45, 100);
            Console.WriteLine(datumVremeSaMilisekundama);
            Console.WriteLine();

            // Statički property strukture DateTime.Now vraća trenutno datum-vreme
            // uzeto od operativnog sistema
            DateTime sada = DateTime.Now;
            Console.WriteLine("DateTime.Now: " + sada);
            // Statički property strukture DateTime.Today vraća samo trenutni datum
            // uzet od operativnog sistema
            DateTime danas = DateTime.Today;
            Console.WriteLine("DateTime.Today: " + danas);
            Console.WriteLine();

            // Razlika dva instance DateTime vraća strukturu TimeSpan
            TimeSpan ts = sada - danas;
            Console.WriteLine("TimeSpan od danas u 12:00 AM: " + ts);
            Console.WriteLine();

            Console.WriteLine("Sutra: " + danas.AddDays(1));
            Console.WriteLine("Danas: " + danas);
            Console.WriteLine("Juče: " + danas.AddDays(-1));
            Console.WriteLine("Danas - 1.37 dana: " + danas.AddDays(-1.37));
            // slično kao AddDays rade i 
            // danas.AddTicks
            // danas.AddMilliseconds
            // danas.AddSeconds
            // danas.AddMinutes
            // danas.AddHours
            // danas.AddMonths
            // danas.AddYears
            Console.WriteLine();

            Console.WriteLine("Dan u nedelji: " + sada.DayOfWeek);
            Console.WriteLine("Dan u mesecu: " + sada.Day);
            Console.WriteLine("Dan u godini: " + sada.DayOfYear);

        }
    }
}
