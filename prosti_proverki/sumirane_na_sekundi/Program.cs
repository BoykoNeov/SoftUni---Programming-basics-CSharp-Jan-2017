using System;


namespace sumirane_na_sekundi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minuti = 0;
            int sekundi = 0;

            sekundi = a + b + c;
            minuti = sekundi / 60;
            sekundi = sekundi % 60;

            Console.WriteLine($"{minuti:0}" + $":{sekundi:00}" );
        }
    }
}
