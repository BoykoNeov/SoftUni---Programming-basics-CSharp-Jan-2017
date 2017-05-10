using System;


namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal budgetMultiplier = 0;
            decimal budgetCar;
            string season = Console.ReadLine();
            string carClass = "";
            string cabrioOrJeep = "Cabrio";

            if (season == "Winter" || budget > 500)
            {
                cabrioOrJeep = "Jeep";
            }

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (cabrioOrJeep == "Jeep")
                {
                    budgetMultiplier = 0.65m;
                }
                else
                {
                    budgetMultiplier = 0.35m;
                }
            }

            if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                if (cabrioOrJeep == "Jeep")
                {
                    budgetMultiplier = 0.80m;
                }
                else
                {
                    budgetMultiplier = 0.45m;
                }
            }

            if (budget > 500)
            {
                carClass = "Luxury class";
                budgetMultiplier = 0.9m;
            }

            budgetCar = budgetMultiplier * budget;
            Console.WriteLine(carClass);
            Console.WriteLine($"{cabrioOrJeep} - {budgetCar:f2}");
        }
    }
}
