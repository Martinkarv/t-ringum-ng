using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int cpuRoll = randomGenerator.Next(1, 7);
            Console.WriteLine("Viska täringut 1-6ni.");
            int userRoll = int.Parse(Console.ReadLine());

            if (userRoll > cpuRoll)
            {
                Console.WriteLine("Sa võitsid!");
            
            }

            else if (userRoll < cpuRoll)
            {
                Console.WriteLine("sa kaotasid.");
            }

            else
            {
                Console.WriteLine("Mäng jäi viiki.");
            }

            Console.ReadLine();












        }
    }
}
