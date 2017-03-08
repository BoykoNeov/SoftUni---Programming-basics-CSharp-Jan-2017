using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fallen_in_love
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string a1 = new string('~', i);
                string a2 = new string('.', (N * 2 - i * 2));
                string a3 = new string('.', i * 2);

                Console.WriteLine("#" + a1 + "#" + a2 + "#" + a3 + "#" + a2 + "#" + a1 + "#");
            }

             for (int i2 = 0; i2<N; i2++)
            {
                string b1 = new string ('.', i2 *2 +1);
                string b2 = new string ('~', N - i2);
                string b3 = new string ('.', N * 2 - i2 * 2);

                Console.WriteLine(b1 + "#" + b2 + "#" + b3 + "#" + b2 + "#" + b1);
                                
            }
            string c1 = new string('.', N * 2 + 1);
            Console.WriteLine(c1 + "####" + c1);

            for (int i3 = 0; i3<N; i3++)
            {
                string d1 = new string('.', N * 2 + 2);
                Console.WriteLine(d1 + "##" + d1);
            }
        }
    }
}
