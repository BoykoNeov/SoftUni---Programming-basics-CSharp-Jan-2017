using System;


namespace N_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleCounter = int.Parse(Console.ReadLine());               //read how many times to repeat the string and how long it is ("cycle")
            string starRectangle = new string('*', cycleCounter);            //construct the string of "cycle" stars
            for (int cycle = 0; cycle < cycleCounter; cycle++)              //write it "cycle" times
            {
                Console.WriteLine(starRectangle);
            }
        }
    }
}
