using System;


namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorCompetitors = int.Parse(Console.ReadLine());
            int seniorCompetitors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();
            decimal totalMoney = 0;

            switch (raceType)
            {
                case "trail":
                    totalMoney = (juniorCompetitors * 5.50m) + (seniorCompetitors * 7m);
                    break;
                case "cross-country":
                    totalMoney = (juniorCompetitors * 8m) + (seniorCompetitors * 9.5m);
                    if (juniorCompetitors + seniorCompetitors >= 50)
                    {
                        totalMoney = totalMoney * 0.75m;
                    }
                    break;
                case "downhill":
                    totalMoney = (juniorCompetitors * 12.25m) + (seniorCompetitors * 13.75m);
                    break;
                case "road":
                    totalMoney = (juniorCompetitors * 20m) + (seniorCompetitors * 21.5m);
                    break;

            }
            totalMoney = totalMoney * 0.95m;
            Console.WriteLine($"{ totalMoney:f2}");
        }
    }
}
