using System;


namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string evenRow = new string('*', n - 2);                        //construct the main parts used for the left and right wing of even and off rows
            string oddRow = new string('-', n - 2);

            for (int n1 = 0; n1 < n - 2; n1++)                              //upper part of the butterfly
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(evenRow + "\\" + " " + "/" + evenRow);
                }
                else
                {
                    Console.WriteLine(oddRow + "\\" + " " + "/" + oddRow);
                }
            }

            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));      //body of the butterfly

            for (int n1 = 0; n1 < n - 2; n1++)                              //lower part of the butterfly
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(evenRow + "/" + " " + "\\" + evenRow);
                }
                else
                {
                    Console.WriteLine(oddRow + "/" + " " + "\\" + oddRow);
                }
            }

        }
    }
}
