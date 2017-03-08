using System;


namespace Kyshti4ka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string zvezdi = "";
            string chertichki = "";
            if (n % 2 == 0) zvezdi = "**";
            else zvezdi = "*";

       int pyrviRedDyljina = (n + 1) / 2;
            string pokrivRed = "";
            for (int c1 = 0; c1 < pyrviRedDyljina; c1++)
            {

                if (c1 > 0) zvezdi = zvezdi + "**";
                chertichki = new string('-', ((n - 1) / 2 - c1));

                 pokrivRed = chertichki + zvezdi + chertichki; 

                Console.WriteLine(pokrivRed);
 

            }

            string zvezdiOsnova = new string ('*', n - 2);
            for (int o1 = 0; o1 < (n/2); o1++)
            {
                Console.WriteLine("|" + zvezdiOsnova + "|");
            }
        }
    }
}
