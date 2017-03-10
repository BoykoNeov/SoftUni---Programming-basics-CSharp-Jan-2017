using System;


namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            Console.WriteLine(a);
        }
    }
}
