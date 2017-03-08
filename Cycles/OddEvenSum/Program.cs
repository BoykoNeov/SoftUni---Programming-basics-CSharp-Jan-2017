using System;


namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int sumDifference = 0;                                                     //defines odd, even and summ difference

            for (int cycle = 0; cycle < numbersToRead; cycle++)                        //cycle for summing 
            {
                if ((cycle % 2) != 0) oddSum += int.Parse(Console.ReadLine());         //add to the odd sum if the number is odd
                else evenSum += int.Parse(Console.ReadLine());                         //else add to the even sum
            }



            sumDifference = Math.Abs(oddSum - evenSum);                               //calculating the diffenrece
            if (sumDifference == 0) Console.WriteLine($"Yes, sum = {evenSum}");
            else Console.WriteLine($"No, diff = {sumDifference}");                      //displaying the rsult

        }
    }
}

