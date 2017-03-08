using System;



namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());
            int leftSum = 0;                    
            int rightSum = 0;
            int sumDifference = 0;                                                     //defines left, rightsum and summ difference

                for (int cycle = 0; cycle < numbersToRead; cycle++)                    //cycle for summing the left sum
                    {
                        leftSum += int.Parse(Console.ReadLine());
                    }

                for (int cycle = 0; cycle < numbersToRead; cycle++)                    //cycle for the right sum
                    {
                        rightSum += int.Parse(Console.ReadLine());
                    }

            sumDifference = Math.Abs(leftSum - rightSum);                               //calculating the diffenrece
            if (sumDifference == 0) Console.WriteLine($"Yes, sum = {leftSum}");         
            else Console.WriteLine($"No, diff = {sumDifference}");                      //displaying the rsult

        }
    }
}
