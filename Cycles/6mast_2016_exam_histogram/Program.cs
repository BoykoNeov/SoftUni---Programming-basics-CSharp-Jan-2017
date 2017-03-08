using System;


namespace _6mast_2016_exam_histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToBeRead = int.Parse(Console.ReadLine());                                    //read the number of numbers to be read
            double p1=0, p2=0, p3=0, p4=0, p5=0;                                                    //different percentages
            for (int cycleCounter = 0; cycleCounter < numbersToBeRead; cycleCounter++)              //cycle for reading the numbers
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200) p1++;                                                      //assigning numbers to different groups
                else if (currentNumber <= 399) p2++;
                else if (currentNumber <= 599) p3++;
                else if (currentNumber <= 799) p4++;
                else p5++;
            }

            Console.WriteLine($"{((p1/numbersToBeRead)*100):##.00}%");                              //displaying the results
            Console.WriteLine($"{((p2 / numbersToBeRead) * 100):##.00}%");
            Console.WriteLine($"{((p3 / numbersToBeRead) * 100):##.00}%");
            Console.WriteLine($"{((p4 / numbersToBeRead) * 100):##.00}%");
            Console.WriteLine($"{((p5 / numbersToBeRead) * 100):##.00}%");
        }
    }
}
