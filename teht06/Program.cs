using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.02/100;
            double matka;
            double ainehinta=1.595;
            Console.Write("Anna matka > ");
            string line  =Console.ReadLine();
            matka = double.Parse(line);
            Console.WriteLine("Bensaa kuluu " +  String.Format("{0:.##}", (matka * kulutus)) + " litraa" + ", kustannukset " + String.Format("{0:.##}", (matka*kulutus*ainehinta)));

        }
    }
}
