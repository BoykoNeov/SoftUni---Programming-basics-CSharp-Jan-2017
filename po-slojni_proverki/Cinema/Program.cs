using System;


namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal prihodi = 0;

            switch (Console.ReadLine())
            {
                case "Premiere":
                    prihodi = 12m;
                    break;
                case "Normal":
                    prihodi = 7.5m;
                    break;
                case "Discount":
                    prihodi = 5m;
                    break;
            }
            Console.WriteLine($"{prihodi * decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine()):0.00} leva");
        }
    }
}
