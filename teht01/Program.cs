﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask a number
            int number;
            Console.Write("Anna numero > ");
            string line = Console.ReadLine();  // "1"
            number = int.Parse(line); // "1" -> 1
            // Which number...
            switch (number)
            {
                case 1: Console.Write("yksi"); break;
                case 2: Console.Write("kaksi"); break;
                case 3: Console.Write("kolme"); break;
                default: Console.Write("joku muu luku");break;

            }
            Console.ReadLine();
        }
    }
}
