using System;


namespace star_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string starRectangle = new string('*',10);            //construct the string of 10 stars
            for (int cycle = 0; cycle < 10; cycle++)              //write it 10 times
            {
                Console.WriteLine(starRectangle);
            }
        }
    }
}
