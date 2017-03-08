using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPairSum = 0;                                                //Sum of the current pair
            int previousPairSum = 0;                                               //Sum of the previous pair
            int maxDifference = 0;                                                //max difference between sum of two pairs
            bool isDifferenceSame = true;                                        //are all differences the same
            int firstNumber = 0;                                                  //first number of a given pair
            int secondNumber = 0;                                                  //second number of a given pair
            int numbersToBeRead = 0;                                               //how many numbers are to be read

            numbersToBeRead = int.Parse(Console.ReadLine());
            for (int cycleCount = 0; cycleCount < numbersToBeRead; cycleCount++)
            {
                firstNumber = int.Parse(Console.ReadLine());                             //read both numbers from the console
                secondNumber = int.Parse(Console.ReadLine());
                if (cycleCount == 0)
                {
                    previousPairSum = firstNumber + secondNumber;                           //calculate the pair sum
                }
                else
                {
                    currentPairSum = firstNumber + secondNumber;

                    if (currentPairSum != previousPairSum)
                    {
                        isDifferenceSame = false;                                        //there is difference between the pairs
                        maxDifference = Math.Abs(currentPairSum - previousPairSum);      // calculate the maximum difference
                        previousPairSum = currentPairSum;                                //move the sum of the current pair to the previous pair for the next cycle
                    }


                }
            }
            if (isDifferenceSame == true)                                               //display output
            {
                Console.WriteLine($"Yes, value={previousPairSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
