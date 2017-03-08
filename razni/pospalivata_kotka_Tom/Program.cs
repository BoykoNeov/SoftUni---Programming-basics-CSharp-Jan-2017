using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pospalivata_kotka_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivniDni = int.Parse(Console.ReadLine());
            int minutiIgra = (pochivniDni * 127) + ((365 - pochivniDni) * 63);
            
            if (minutiIgra > 30000)
            {
                int chasove = (minutiIgra - 30000) / 60;
                int minuti = (minutiIgra - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{chasove} hours and {minuti} minutes more for play");
            }
            else
            {
                int chasove = (30000 - minutiIgra) / 60;
                int minuti =  (30000 - minutiIgra) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{chasove} hours and {minuti} minutes less for play");
            }
        }
    }
}
