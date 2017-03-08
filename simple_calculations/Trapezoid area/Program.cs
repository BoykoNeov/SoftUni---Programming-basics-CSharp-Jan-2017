using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string h = Console.ReadLine();
            a = a.Replace(',', '.');   // replaces the',' in the string with '.'
            b = b.Replace(',', '.');   // replaces the',' in the string with '.'
            h = h.Replace(',', '.');   // replaces the',' in the string with '.'

            decimal ax = decimal.Parse(a);
            decimal bx = decimal.Parse(b);
            decimal hx = decimal.Parse(h);

            decimal area = (ax + bx) * hx / 2m;

            Console.WriteLine("Trapezoid area = {0}", area);
           //  (b1 + b2) * h / 2.
        }
    }
}
