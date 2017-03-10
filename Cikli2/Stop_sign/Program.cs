using System;


namespace Stop_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine (new string ('.', n + 1) + new string ('_',n + 4) + new string('.', n + 1)) ;

        }
    }
}
