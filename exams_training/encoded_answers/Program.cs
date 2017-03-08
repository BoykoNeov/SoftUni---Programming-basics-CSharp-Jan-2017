using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encoded_answers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint questions = uint.Parse(Console.ReadLine());

            uint a = 0;
            uint b = 0;
            uint c = 0;
            uint d = 0;

            uint x;
            string out_string = "";

            for (uint i = 0; i<questions; i++)
            {
                x = uint.Parse(Console.ReadLine()) % 4 ;
                switch (x)
                {
                    case 0:
                        a++;
                        out_string = out_string +("a ");
                        break;
                    case 1:
                        b++;
                        out_string = out_string + ("b ");
                        break;
                    case 2:
                        c++;
                        out_string = out_string + ("c ");
                        break;
                    case 3:
                        d++;
                        out_string = out_string + ("d ");
                        break;

                }





            }
            Console.WriteLine(out_string);
            Console.WriteLine($"Answer A: {a}");
            Console.WriteLine($"Answer B: {b}");
            Console.WriteLine($"Answer C: {c}");
            Console.WriteLine($"Answer D: {d}");


        }
    }
}
