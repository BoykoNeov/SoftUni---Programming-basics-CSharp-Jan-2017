using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            double chasove = double.Parse(Console.ReadLine());
            double dni = double.Parse(Console.ReadLine());
            double slujiteli = double.Parse(Console.ReadLine());

           double redovenTrud = dni * 0.9d * 8d;

            double izynredenTrud = slujiteli * 2 * dni;

            double obshtoTrud = Math.Floor(redovenTrud + izynredenTrud);

            if (obshtoTrud >= chasove)
            {
                Console.WriteLine($"Yes!{obshtoTrud - chasove} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{chasove - obshtoTrud} hours needed.");
            }
        }
    }
}
