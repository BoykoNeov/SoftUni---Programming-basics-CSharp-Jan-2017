using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usd_to_bgn
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = decimal.Parse(Console.ReadLine());
            string valuta_1 = Console.ReadLine();
            string valuta_2 = Console.ReadLine();



            switch (valuta_1)
            {
                case "USD":
                    a = a * 1.79549m;
                    break;
                case "EUR":
                    a = a * 1.95583m;
                    break;
                case "GBP":
                    a = a * 2.53405m;
                    break;
            }

            switch (valuta_2)
            {
                case "USD":
                    a = a / 1.79549m;
                    break;
                case "EUR":
                    a = a / 1.95583m;
                    break;
                case "GBP":
                    a = a / 2.53405m;
                    break;
            }
            Console.Write(Math.Round(a,2));
            Console.WriteLine($" {valuta_2}");
                


            //  1 USD = 1.79549 BGN
            // 1 EUR = 1.95583 BGN
            // 1 GBP = 2.53405 BGN
        }
    }
}
