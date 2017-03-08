using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace hungry_garfield
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong proba1 = ulong.MaxValue;
            Console.WriteLine(proba1);

            proba1 = (ulong)(proba1 << 63) - (ulong)Math.Pow(2, 63);
            Console.WriteLine(proba1);





        }
    }
}
