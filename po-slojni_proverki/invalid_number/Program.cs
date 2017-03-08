using System;


namespace invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            if (((chislo >= 100) && (chislo <= 200)) || (chislo == 0))
            {

            }
            else Console.WriteLine("invalid");
        }
    }
}
