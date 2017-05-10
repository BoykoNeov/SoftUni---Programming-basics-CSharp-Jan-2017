using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_3_cvetq
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hrizantemi = decimal.Parse(Console.ReadLine());
            decimal rozi = decimal.Parse(Console.ReadLine());
            decimal laleta = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string praznik = Console.ReadLine();

            decimal cenaBuket = 0;      //obshta cena na buketa

            bool praznikLiE;
            if (praznik == "Y") praznikLiE = true;
            else praznikLiE = false;

            bool proletLiE = false;
            bool lqtoLiE = false;
            bool esenLiE = false;
            bool zimaLiE = false;

            if (sezon == "Spring") proletLiE = true;
            if (sezon == "Summer") lqtoLiE = true;
            if (sezon == "Autumn") esenLiE = true;
            if (sezon == "Winter") zimaLiE = true;

            decimal cenaHrizantemi = 0;
            decimal cenaRozi = 0;
            decimal cenaLaleta = 0;

            if (proletLiE | lqtoLiE)  //ceni prez prolet/lqto
            {
                cenaHrizantemi = 2;
                cenaRozi = 4.1m;
                cenaLaleta = 2.5m;
            }

            if (esenLiE | zimaLiE)   //ceni prez esen/zima
            {
                cenaHrizantemi = 3.75m;
                cenaRozi = 4.5m;
                cenaLaleta = 4.15m;
            }

            cenaBuket = hrizantemi * cenaHrizantemi + rozi * cenaRozi + laleta * cenaLaleta;

          //  Console.WriteLine($"cena_do_tuk {cenaBuket:0.00}");


            if (praznikLiE == true) cenaBuket = cenaBuket * 1.15m;

            if ((proletLiE == true) & (laleta > 7)) cenaBuket = cenaBuket - cenaBuket * 0.05m;

            if ((zimaLiE == true) & (rozi >= 10)) cenaBuket = cenaBuket - cenaBuket * 0.10m;

          //  Console.WriteLine($"cena_do_tuk {cenaBuket:0.00}");

            if ((rozi + hrizantemi + laleta) > 20) cenaBuket = cenaBuket - cenaBuket * 0.2m;

            cenaBuket = cenaBuket + 2;

            Console.WriteLine($"{cenaBuket:0.00}");

        }
    }
}
