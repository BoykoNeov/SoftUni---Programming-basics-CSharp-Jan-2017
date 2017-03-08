using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excellent_result
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50d) Console.WriteLine("Excellent!");
            else Console.WriteLine("Not Excellent.");
        }
    }
}
