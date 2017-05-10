using System;


namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal greenPaintExppediture = 3;
            decimal redPaintExpediture = 5;

            decimal sideWall = decimal.Parse(Console.ReadLine());
            decimal houseHeight = decimal.Parse(Console.ReadLine());
            decimal a = sideWall;
            decimal b = houseHeight;

            decimal houseSidesArea = a * (a / 2) * 2;
            decimal backWall = (a / 2) * (a / 2) + ((a / 2) * (b -(a / 2)) / 2);
            decimal frontwall = backWall - ((a / 5) * (a / 5));
            decimal roofArea = a * (a / 2) * 2;

            decimal greenPaintTotal = (houseSidesArea + backWall + frontwall) / greenPaintExppediture;
            decimal redPaintTotal = (roofArea) / redPaintExpediture;

            Console.WriteLine($"{greenPaintTotal:f2}");
            Console.WriteLine($"{redPaintTotal:f2}");

        }
    }
}
