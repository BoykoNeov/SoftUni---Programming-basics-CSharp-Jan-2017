using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());


            a = a * 180 / (decimal)Math.PI;
            Console.WriteLine(Math.Round(a));
        }
    }
}
