using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number0do100
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensMap = new[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int chislo = int.Parse(Console.ReadLine());

            if (chislo > -1 && chislo <= 100)
            {
                if (chislo < 20) Console.WriteLine(unitsMap[chislo]);

                if (chislo >= 20 && chislo < 100)
                {
                    Console.Write($"{tensMap[chislo / 10]}");
                    if (chislo % 10 != 0) Console.WriteLine($" {unitsMap[chislo % 10]}");
                    else Console.WriteLine();
                }
                if (chislo == 100) Console.WriteLine("one hundred");
            }
            else Console.WriteLine("Invalid number");

        }
    }
}
