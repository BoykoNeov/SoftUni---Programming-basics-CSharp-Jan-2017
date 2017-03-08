using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double ploshtadka_plosht = N * N;
            double plochka_plosht = W * L;
            double peika_plosht = M * O;

            double neobhodimi_plochki = (ploshtadka_plosht - peika_plosht) / plochka_plosht;

            Console.WriteLine(neobhodimi_plochki);
            Console.WriteLine(neobhodimi_plochki * 0.2);
        
        


        }
    }
}
