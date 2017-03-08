using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("square = ");
            Console.WriteLine(area);

        }
    }
}
