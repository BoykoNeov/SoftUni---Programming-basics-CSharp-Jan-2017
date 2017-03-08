using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_5_koledna_shapka
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string a1 = new string('.', 2 * N - 1);

            Console.WriteLine(a1 + @"/|\" + a1);
            Console.WriteLine(a1 + @"\|/" + a1);

            for (int x = 0; x< 2* N; x++)
            {
                string b1 = new string('.', 2 * N - x - 1);
                string b2 = new string('-', x);

                Console.WriteLine(b1 + "*" + b2 + "*" + b2 + "*" + b1);
            }

            string c1 = new string('*', 4 * N + 1);
            Console.WriteLine(c1);

            string c2 = "";
            for (int j =0; j < N * 2; j++)
            {
                c2 += "*.";
            }
            c2 = c2 + "*";
            Console.WriteLine(c2);
            Console.WriteLine(c1);

        }
    }
}
