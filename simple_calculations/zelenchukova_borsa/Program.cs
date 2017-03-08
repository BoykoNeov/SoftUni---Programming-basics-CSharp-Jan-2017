using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zelenchukova_borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal zelenchuci_cena = decimal.Parse(Console.ReadLine());
            decimal plodove_cena = decimal.Parse(Console.ReadLine());
            decimal zelenchuci_kolichestvo = decimal.Parse(Console.ReadLine());
            decimal plodove_kolichestvo = decimal.Parse(Console.ReadLine());

            double obshto_evro = (double)(((zelenchuci_cena * zelenchuci_kolichestvo) + (plodove_cena * plodove_kolichestvo)) / 1.94m);

            Console.WriteLine(obshto_evro);
        }
    }
}
