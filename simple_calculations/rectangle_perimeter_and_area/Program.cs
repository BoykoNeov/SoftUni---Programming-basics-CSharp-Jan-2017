using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_perimeter_and_area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            decimal x = (decimal)Math.Abs(x1 - x2);
            decimal y = (decimal)Math.Abs(y1 - y2);

            Console.WriteLine(x * y);
            Console.WriteLine(2 * x + 2 * y);
        }
    }
}
