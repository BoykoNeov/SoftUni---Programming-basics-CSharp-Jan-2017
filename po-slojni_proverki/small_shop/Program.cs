using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] ceni = new double[,] {
                                 { 0.50, 0.80, 1.20, 1.45, 1.60},
                                 { 0.40, 0.70, 1.15, 1.30, 1.50},
                                 { 0.45, 0.70, 1.10, 1.35, 1.55}
            };
            string produkt_sring = Console.ReadLine();
            string grad_string = Console.ReadLine();

            int produkt = 0;
            int grad = 0;

            switch (produkt_sring)
            {
                case "coffee":
                    produkt = 0;
                    break;
                case "water":
                    produkt = 1;
                    break;
                case "beer":
                    produkt = 2;
                    break;
                case "sweets":
                    produkt = 3;
                    break;
                case "peanuts":
                    produkt = 4;
                    break;
            }

            switch (grad_string)
            {
                case "Sofia":
                    grad = 0;
                    break;
                case "Plovdiv":
                    grad = 1;
                    break;
                case "Varna":
                    grad = 2;
                    break;
            }

            double kolichestvo = double.Parse(Console.ReadLine());

            Console.WriteLine($"{kolichestvo * ceni[grad,produkt]}");


        }
    }
}
