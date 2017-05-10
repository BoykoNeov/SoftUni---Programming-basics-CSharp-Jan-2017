using System;


namespace Case6_sumoftwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationNumber = 0;
            bool magicFound = false;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinationNumber++;
                    if (i + j == magicNumber && magicFound == false)
                    {
                        magicFound = true;
                        Console.Write($"Combination N:{combinationNumber} ");
                        Console.WriteLine($"({i} + {j} = {i + j})");
                      
                    }
                }
            }

            if (magicFound == false)
            {
                Console.WriteLine($"{combinationNumber} combinations - neither equals {magicNumber}");
            }
        }
    }
}
