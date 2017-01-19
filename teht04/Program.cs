using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Anna ikasi: ");
            string line = Console.ReadLine();
            age = int.Parse(line);
            if (age < 18) Console.WriteLine("Alaikainen");
            else if (age >= 18 && age <= 65) Console.WriteLine("aikuinen");
            else if (age > 65) Console.WriteLine("seniori");
            Console.ReadLine();
        }
       
    }
}
