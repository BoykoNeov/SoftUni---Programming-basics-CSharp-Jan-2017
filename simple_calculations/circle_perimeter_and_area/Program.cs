using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_perimeter_and_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
             a = a.Replace(',', '.');
            decimal ax = decimal.Parse(a);

            decimal Area = (decimal)Math.PI * ax * ax;
            decimal Perimeter = (decimal)Math.PI * 2 * ax;

            Console.WriteLine($"Area = {Area}");
            Console.WriteLine($"Perimeter = {Perimeter}");

        }
    }
}
