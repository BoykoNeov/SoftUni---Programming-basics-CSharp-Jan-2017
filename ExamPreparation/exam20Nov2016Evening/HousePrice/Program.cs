using System;


namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSmallRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double priceSquareM = double.Parse(Console.ReadLine());

            double areaBathroom = 0.5 * areaSmallRoom;
            double areaSecondRoom = 1.1 * areaSmallRoom;
            double areaThirdRoom = 1.1 * areaSecondRoom;

            double totalArea = (areaBathroom + areaKitchen + areaSecondRoom + areaSmallRoom + areaThirdRoom) * 1.05;
            Console.WriteLine($"{totalArea * priceSquareM:f2}");
        }
    }
}
