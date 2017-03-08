using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trybi_v_basein
{
    class Program
    {
        static void Main(string[] args)
        {
            int obemBasein = int.Parse(Console.ReadLine());
            int tryba1 = int.Parse(Console.ReadLine());
            int tryba2 = int.Parse(Console.ReadLine());
            double chasove = double.Parse(Console.ReadLine());

            
            if (((tryba1 * chasove) + (tryba2 * chasove)) > obemBasein)
                {
                double basein_overflow = (tryba1 * chasove) + (tryba2 * chasove) - obemBasein;
                    Console.WriteLine($"For {chasove} hours the pool overflows with {basein_overflow} liters.");
                }
            else
                {
                double basein_pylen =  (((tryba1 * chasove) + (tryba2 * chasove)) / obemBasein) * 100;
               

                double prinos_tryba_1 = ((tryba1 * chasove) * 100) / ((tryba1 * chasove) + (tryba2 * chasove));
                double prinos_tryba_2 = ((tryba2 * chasove) * 100) / ((tryba1 * chasove) + (tryba2 * chasove));
                Console.WriteLine($"The pool is {Math.Floor(basein_pylen)}% full. Pipe 1: {Math.Floor(prinos_tryba_1)}%. Pipe 2: {Math.Floor(prinos_tryba_2)}%.");
                }
        }
    }
}
