using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            string inches_string = (Console.ReadLine());
            inches_string = inches_string.Replace(',', '.');   // replaces the',' in the string with '.'
            var inches = decimal.Parse(inches_string);  
            var cm = inches * 2.54m;
            Console.Write("Centimeters = ");
            Console.WriteLine(cm);


        }
    }
}
