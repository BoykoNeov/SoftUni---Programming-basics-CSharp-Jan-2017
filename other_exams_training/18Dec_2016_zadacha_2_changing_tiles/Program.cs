using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_2_changing_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sybraniPari = decimal.Parse(Console.ReadLine());
            decimal shirochinaPod = decimal.Parse(Console.ReadLine());
            decimal dyljinaPod = decimal.Parse(Console.ReadLine());
            decimal stranaTriygylnik = decimal.Parse(Console.ReadLine());
            decimal visochinaTriygylnik = decimal.Parse(Console.ReadLine());
            decimal cenaPlochka = decimal.Parse(Console.ReadLine());
            decimal sumaMaistor = decimal.Parse(Console.ReadLine());

            decimal ploshtPod = shirochinaPod * dyljinaPod;
            decimal ploshtPlochka = 0.5m * stranaTriygylnik * visochinaTriygylnik;
            decimal neobhodimiPlochki = Math.Ceiling(ploshtPod / ploshtPlochka) + 5;

            decimal neobhodimiPari = neobhodimiPlochki * cenaPlochka + sumaMaistor;

            double ostavashtiPari = (double)sybraniPari - (double)neobhodimiPari;
            if (ostavashtiPari >= 0)
            {
                Console.WriteLine($"{ostavashtiPari:0.00} lv left.");
            }
            else
            {
                ostavashtiPari = ostavashtiPari * -1;
                Console.WriteLine($"You'll need {(decimal)ostavashtiPari:0.00} lv more.");
            }
       
        }
    }
}
