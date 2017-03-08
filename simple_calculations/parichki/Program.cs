using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parichki
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double euro = ((bitcoins * 1168) + (yuans * 0.15 * 1.76)) / 1.95;
            Console.WriteLine(euro - (euro * commision /100));
        }
    }
}
