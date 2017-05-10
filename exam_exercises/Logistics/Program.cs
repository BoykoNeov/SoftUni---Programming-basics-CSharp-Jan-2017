using System;


namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int busTonnage = 0;
            int truckTonnage = 0;
            int trainTonnage = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int currentTonnage = int.Parse(Console.ReadLine());

                if (currentTonnage <= 3)
                {
                    busTonnage += currentTonnage;
                }

                if (currentTonnage >= 4 && currentTonnage <= 11)
                {
                    truckTonnage += currentTonnage;
                }

                if (currentTonnage > 11)
                {
                    trainTonnage += currentTonnage;
                }
            }

            double totalTonnage = busTonnage + truckTonnage + trainTonnage;
            double meanPrice = (busTonnage * 200 + truckTonnage * 175 + trainTonnage * 120) / (totalTonnage);

            Console.WriteLine($"{meanPrice:f2}");
            Console.WriteLine($"{(busTonnage/totalTonnage)*100:f2}%");
            Console.WriteLine($"{(truckTonnage / totalTonnage) * 100:f2}%");
            Console.WriteLine($"{(trainTonnage / totalTonnage) * 100:f2}%");
        }
    }
}
