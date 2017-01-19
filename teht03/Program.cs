using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Anna yksi luku > ");
            string line = Console.ReadLine();
            num1 = int.Parse(line);
            Console.Write("Anna toinen luku > ");
            line = Console.ReadLine();
            num2 = int.Parse(line);
            Console.Write("Anna kolmas luku > ");
            line = Console.ReadLine();
            num3 = int.Parse(line);
            int summa = num1 + num2 + num3;
            int ka = (num1 + num2 + num3) / 3;
            Console.WriteLine("Summa = " + summa);
            Console.WriteLine("Keskiarvo = " + ka);
            Console.ReadLine();
        }
    }
}
