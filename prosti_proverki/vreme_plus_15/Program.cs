using System;
namespace vreme_plus_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuti = int.Parse(Console.ReadLine()) * 60 + int.Parse(Console.ReadLine()) + 15;
            if (minuti / 60 > 23) Console.WriteLine($"{minuti / 60 - 24}:{minuti % 60:00}");
            else Console.WriteLine($"{minuti / 60 }:{minuti % 60:00}");
        }
    }
}
