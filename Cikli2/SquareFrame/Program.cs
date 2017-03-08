using System;


namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleCounter = int.Parse(Console.ReadLine());   //read how many cycles
            string firstAndLastLine ="+";
            string firstAndLastLinePylnej ="";
            for (int cycle = 0; cycle < cycleCounter -2; cycle++)           //constructing the first and last line
            {
                firstAndLastLinePylnej = firstAndLastLinePylnej + " -";
            }
            firstAndLastLine = "+" + firstAndLastLinePylnej + " +";
            Console.WriteLine(firstAndLastLine);

            
            string middleLine = "|";
            string middleLinePylnej = "";
            for (int cycle = 0; cycle < cycleCounter - 2; cycle++)          //constructing middle lines
            {
                middleLinePylnej = middleLinePylnej + " -";
            }
            middleLine = "|" + middleLinePylnej + " |";
            for (int cycle = 0; cycle < cycleCounter - 2; cycle++)
            {
                Console.WriteLine(middleLine);
            }
            Console.WriteLine(firstAndLastLine);
        }
    }
}
