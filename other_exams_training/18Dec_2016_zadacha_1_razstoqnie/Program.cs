using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_1_razstoqnie
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Skorost = decimal.Parse(Console.ReadLine());
            decimal minuti1 = decimal.Parse(Console.ReadLine()) /60;
            decimal minuti2 = decimal.Parse(Console.ReadLine()) /60;
            decimal minuti3 = decimal.Parse(Console.ReadLine()) /60;
            decimal izminatoRazstoqnie = 0;

            izminatoRazstoqnie = Skorost * minuti1; //izminava minuti 1
            Skorost = Skorost * 1.1m;
            izminatoRazstoqnie = izminatoRazstoqnie + (Skorost * minuti2); //uvelichava skorostta s 10% i izminava minuti 2

            Skorost = Skorost - Skorost * 0.05m;
            izminatoRazstoqnie = izminatoRazstoqnie + (Skorost * minuti3); //namalqva skorostta s 5% i izminava minuti 3

           // izminatoRazstoqnie = Math.Round(izminatoRazstoqnie, 2);
            Console.WriteLine($"{izminatoRazstoqnie:0.00}");
        }
    }
}
