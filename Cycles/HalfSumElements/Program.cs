using System;


namespace HalfSumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());                                //how many numbers are to be read
            int sumOfAllNumbers = 0;                                                            //defines sum of all numbers
            int maxNumber = 0;                                                                  //defines current max number

            for (int cycle = 0; cycle < numberOfNumbers; cycle++)                               //cycle for reading and summing the numbers
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfAllNumbers += currentNumber;

                if (maxNumber <= currentNumber)                                                //find the maximum of all read numbers
                {
                    maxNumber = currentNumber;
                } 
            }

            if (maxNumber == (sumOfAllNumbers - maxNumber))                                    //Compare the max number to the sum of all other numbers
            {
                Console.WriteLine($"Yes Sum = {maxNumber}");
            }
            else                                                                               // else calculate and display the difference
            {
                Console.WriteLine($"No Diff = {Math.Abs((sumOfAllNumbers- maxNumber) - maxNumber)}");
            }

        }
    }
}
