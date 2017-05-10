using System;


namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int drawnCombinations = 1;

            for (int i = firstNumber; i <= secondNumber; i++)
            {

                    for (int j = firstNumber; j <= secondNumber; j++)
                    {
                        if (drawnCombinations <= maxCombinations)
                        {
                            Console.Write($"<{i}-{j}>");
                            drawnCombinations++;
                        }
                        else break;
                }
            }
        }
    }
}
