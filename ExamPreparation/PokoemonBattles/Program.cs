using System;


namespace PokoemonBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerPokemons = int.Parse(Console.ReadLine());
            int secondPlayerPokemons = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int currentBattles = 0;

            for (int i = 1; i <= firstPlayerPokemons; i++)
            {
                    for (int j = 1; j <= secondPlayerPokemons; j++)
                    {
                    if (currentBattles == maxBattles)
                    {
                        break;
                    }
                    currentBattles++;
                        Console.Write($"({i} <-> {j}) ");

                    }
            }
        }
    }
}
