using System;


namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfNumbers = int.Parse(Console.ReadLine());           //reads from the console the number of numbers to compare
            int minNumber = 0;                                                  //defines the max number
            for (int counter = 0; counter < numbersOfNumbers; counter++)    //cycles reading until "numbersOfNumbers" is reached
            {
                int currentNumber = int.Parse(Console.ReadLine());          //reads a number from the console

                if (counter == 0) minNumber = currentNumber;                //sets the min number to the current number in the first cycle
                if (minNumber > currentNumber)
                {
                    minNumber = currentNumber;                          //sets the min number to current number if it is smaller
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
