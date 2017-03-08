using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probe
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ab";
            string c = "a";
            c = c + "b";




            Console.WriteLine(a == c);
            Console.WriteLine((object)a == (object)c);


        }
    }
}
