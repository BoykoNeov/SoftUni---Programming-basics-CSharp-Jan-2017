using System;


namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 1000; number++)
            {
                if (number % 10 == 7) Console.WriteLine(number);  //display the number if it is ending in 7
            }
        }
    }
}
