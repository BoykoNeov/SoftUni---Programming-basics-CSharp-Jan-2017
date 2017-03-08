using System;



namespace triangle_of_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleCount = int.Parse(Console.ReadLine());      //read cycle count
            string dollars = "$";                                   //initial string set-up
            for (int cycle = 0; cycle < cycleCount; cycle++)        //cycle for displaying the required tasks
            {
                Console.WriteLine(dollars);
                dollars = dollars + " $";
            }

        }
    }
}
