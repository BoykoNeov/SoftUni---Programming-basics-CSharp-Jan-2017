using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnevna_pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rabotni_dni = decimal.Parse(Console.ReadLine());
            decimal dnevni_pari = decimal.Parse(Console.ReadLine());
            decimal kurs_dolar = decimal.Parse(Console.ReadLine());

            decimal mesechna_zaplata = (rabotni_dni * dnevni_pari);
            decimal godishna_zaplata = (mesechna_zaplata * 14.5m * 0.75m);

            decimal sredno_pari = (godishna_zaplata / 365) * kurs_dolar;

           sredno_pari = Math.Round(sredno_pari,2);
            Console.WriteLine(sredno_pari);
        }
    }
}
