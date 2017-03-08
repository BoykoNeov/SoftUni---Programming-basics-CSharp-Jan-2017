using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            

            a = a *9/5 + 32;
            Console.WriteLine(Math.Round(a, 2));
        }
    }
}
