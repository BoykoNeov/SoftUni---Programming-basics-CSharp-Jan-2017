using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xplosht = double.Parse(Console.ReadLine());
            double Ydobiv = double.Parse(Console.ReadLine());
            double Znujda = double.Parse(Console.ReadLine());
            double rabotnici = double.Parse(Console.ReadLine());

            double grozdeZaVino = Xplosht * Ydobiv * 0.4d /2.5d;

            if (Znujda > grozdeZaVino)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Znujda - grozdeZaVino)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(grozdeZaVino)} liters.");
                Console.WriteLine($"{Math.Ceiling(grozdeZaVino - Znujda)} liters left -> {Math.Ceiling((grozdeZaVino - Znujda)/ rabotnici)} liters per person.");
            }
        }
    }
}
