using System;


namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTurns = int.Parse(Console.ReadLine());
            decimal currentNumber;
            decimal finalResult = 0;

            decimal zeroTo9 = 0;
            decimal tenTo19 = 0;
            decimal twentyTo29 = 0;
            decimal thirtyTo39 = 0;
            decimal fortyTo50 = 0;
            decimal invalidNumbers = 0;

            for (int i = 0; i < numberOfTurns; i++)
            {
                currentNumber = decimal.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    finalResult += currentNumber * 0.2m;
                    zeroTo9++;
                }

                if (currentNumber >= 10 && currentNumber <= 19)
                {
                    finalResult += currentNumber * 0.3m;
                    tenTo19++;
                }

                if (currentNumber >= 20 && currentNumber <= 29)
                {
                    finalResult += currentNumber * 0.4m;
                    twentyTo29++;
                }
                if (currentNumber >= 30 && currentNumber <= 39)
                {
                    finalResult += 50;
                    thirtyTo39++;
                }

                if (currentNumber >= 40 && currentNumber <= 50)
                {
                    finalResult += 100;
                    fortyTo50++;
                }
                if (currentNumber < 0 || currentNumber > 50)
                {
                    finalResult = finalResult / 2m;
                    invalidNumbers++;
                }
            }

            Console.WriteLine($"{ finalResult:f2}");
            Console.WriteLine($"From 0 to 9: {((zeroTo9 / numberOfTurns)*100):f2}%");
            Console.WriteLine($"From 10 to 19: {((tenTo19 / numberOfTurns) * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {((twentyTo29 / numberOfTurns) * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {((thirtyTo39 / numberOfTurns) * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {((fortyTo50 / numberOfTurns) * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {((invalidNumbers / numberOfTurns) * 100):f2}%");


            //            From 0 to 9: 10.00 %
            //From 10 to 19: 10.00 %
            //From 20 to 29: 20.00 %
            //From 30 to 39: 10.00 %
            //From 40 to 50: 30.00 %
            //Invalid numbers: 20.00 %

        }
    }
}
