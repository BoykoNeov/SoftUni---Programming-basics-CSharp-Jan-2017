using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lica_na_figuri
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipFigura = Console.ReadLine();
            double plosht = 0;
            switch (tipFigura) 
            {
                case "square":
                    double strana = double.Parse(Console.ReadLine());
                    plosht = strana * strana;
                    break;
                case "rectangle":
                    double stranaA = double.Parse(Console.ReadLine());
                    double stranaB = double.Parse(Console.ReadLine());
                    plosht = stranaA * stranaB;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    plosht = Math.PI * radius * radius;
                    break;
                case "triangle":
                    double stranaTriygylnik = double.Parse(Console.ReadLine());
                    double visochinaTriygylnik = double.Parse(Console.ReadLine());
                    plosht = stranaTriygylnik * visochinaTriygylnik / 2;
                    break;
            }
            plosht = Math.Round(plosht, 3);
            Console.WriteLine(plosht);
        }
    }
}
