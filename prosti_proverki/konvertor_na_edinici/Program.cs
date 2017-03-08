using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertor_na_edinici
{
    class Program
    {
        static void Main(string[] args)
        {
            double chisloZaPreobrazuvane = double.Parse(Console.ReadLine());
            string vhodnaEdinica = Console.ReadLine();
            string izhodnaEdinica = Console.ReadLine();

            double chisloVMetra;
            double chisloIzhod;

            switch (vhodnaEdinica)
            {
                case "mm":
                    chisloVMetra = chisloZaPreobrazuvane / 1000;
                    break;

                case "cm":
                    chisloVMetra = chisloZaPreobrazuvane / 100;
                    break;

                case "mi":
                    chisloVMetra = chisloZaPreobrazuvane / 0.000621371192d;
                    break;

                case "in":
                    chisloVMetra = chisloZaPreobrazuvane / 39.3700787d;
                    break;

                case "km":
                    chisloVMetra = chisloZaPreobrazuvane / 0.001;
                    break;

                case "ft":
                    chisloVMetra = chisloZaPreobrazuvane / 3.2808399d;
                    break;

                case "yd":
                    chisloVMetra = chisloZaPreobrazuvane / 1.0936133d;
                    break;

                default:
                    chisloVMetra = chisloZaPreobrazuvane;
                    break;
            }

            switch (izhodnaEdinica)
            {
                case "mm":
                    chisloIzhod = chisloVMetra * 1000;
                    break;

                case "cm":
                    chisloIzhod = chisloVMetra * 100;
                    break;

                case "mi":
                    chisloIzhod = chisloVMetra * 0.000621371192d;
                    break;

                case "in":
                    chisloIzhod = chisloVMetra * 39.3700787d;
                    break;

                case "km":
                    chisloIzhod = chisloVMetra * 0.001;
                    break;

                case "ft":
                    chisloIzhod = chisloVMetra * 3.2808399d;
                    break;

                case "yd":
                    chisloIzhod = chisloVMetra * 1.0936133d;
                    break;

                default:
                    chisloIzhod = chisloVMetra;
                    break;
            }


            Console.Write(chisloIzhod);
            Console.WriteLine($" {vhodnaEdinica}"); //tova izglejda greshno!! No taka go napravih po rykovodstvoto, trqbva da e drugata edinica
        }
    }
}
