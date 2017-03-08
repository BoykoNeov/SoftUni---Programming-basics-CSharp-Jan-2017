using System;


namespace N_space_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleCounter = int.Parse(Console.ReadLine()) - 1;               //read how many times to repeat the string and how long it is ("cycle")
            string starRectangle = "*";
            for (int cycle = 0; cycle < cycleCounter; cycle++)
            {
                starRectangle = starRectangle + " " + "*";
                
            }
            //construct the string of "cycle" stars
            for (int cycle = 0; cycle <= cycleCounter; cycle++)              //write it "cycle" times
            {
                Console.WriteLine(starRectangle);
            }
        }
    }
}
