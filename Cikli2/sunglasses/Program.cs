using System;


namespace sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    //read the n number for the sunglasses drawing
            string rowStars = new string('*',2 * n);
            string rowSpaces = new string(' ', n);
            string rowGlasses = "*" + new string('/', 2 * n - 2) + "*";
            string rowVertical = new string('|', n);

            Console.Write(rowStars);
            Console.Write(rowSpaces);
            Console.WriteLine(rowStars);

            for (int cycle = 2; cycle < n; cycle++)
            {
                Console.Write(rowGlasses);
                if (Math.Ceiling(Convert.ToDouble(n) / 2) == cycle) Console.Write(rowVertical);
                else Console.Write(rowSpaces);
                Console.WriteLine(rowGlasses);
            }
            Console.Write(rowStars);
            Console.Write(rowSpaces);
            Console.WriteLine(rowStars);

        }
    }
}
