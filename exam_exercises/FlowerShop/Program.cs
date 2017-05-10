using System;


namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4;
            double rosePrice = 3.5;
            double cactiPrice = 8;

            double magnoliaQuantity = double.Parse(Console.ReadLine());
            double hyacinthQuantity = double.Parse(Console.ReadLine());
            double roseQuantity = double.Parse(Console.ReadLine());
            double cactiQuantity = double.Parse(Console.ReadLine());
            double prizePrice = double.Parse(Console.ReadLine());

            double totalFlowersCost = (magnoliaPrice * magnoliaQuantity) + (hyacinthPrice * hyacinthQuantity) + (rosePrice * roseQuantity) + (cactiPrice * cactiQuantity);

            totalFlowersCost = totalFlowersCost * 0.95;
            double prizeFlowerDifference = totalFlowersCost - prizePrice;

            if (prizeFlowerDifference < 0)
            {
                prizeFlowerDifference = Math.Ceiling(prizeFlowerDifference * -1);
                Console.WriteLine($"She will have to borrow {prizeFlowerDifference} leva.");
            }
            else
            {
                prizeFlowerDifference = Math.Floor(prizeFlowerDifference);
                Console.WriteLine($"She is left with {prizeFlowerDifference} leva.");
            }
        }
    }
}
