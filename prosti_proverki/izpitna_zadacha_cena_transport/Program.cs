using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_cena_transport
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double krainaCena = 0;

            if ((dayNight == "day") && (n < 20))
            {
                krainaCena = n * 0.79 + 0.70;
            }
            else if ((dayNight == "night") && (n < 20))
            {
                krainaCena = n * 0.90 + 0.70;
            }
            else if ((n >= 20) && (n < 100))
            {
                krainaCena = n * 0.09;
            }
            else
            {
                krainaCena = n * 0.06;
            }
            Console.WriteLine($"{krainaCena}");

        }
    }
}
