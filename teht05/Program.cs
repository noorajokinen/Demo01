using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sek, min, hour, luku;
            Console.Write("Anna sekunnit > ");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            hour = luku / (60*60);
            min = luku / 60 - hour*60;
            sek = luku % 60;
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + hour + " tuntia " + min + " minuuttia " + sek + " sekuntia ");

        }
    }
}
