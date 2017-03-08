using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchebna_zala
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal h = (decimal.Parse(Console.ReadLine()) * 100);
            decimal w = (decimal.Parse(Console.ReadLine()) * 100);
            w = w - 100m;

            int hi = (int)h;
            int wi = (int)w;
            

            hi = hi / 120;
            wi = wi / 70;

            Console.WriteLine(hi * wi - 3);
        }
    }
}
