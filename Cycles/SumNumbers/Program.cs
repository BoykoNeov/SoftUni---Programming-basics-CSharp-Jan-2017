using System;


namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int counter = 0; counter < numbersOfNumbers; counter++)
            {
                sum += int.Parse(Console.ReadLine());                           //reads and sums the numbers
            }
            Console.WriteLine(sum);
        }
    }
}
