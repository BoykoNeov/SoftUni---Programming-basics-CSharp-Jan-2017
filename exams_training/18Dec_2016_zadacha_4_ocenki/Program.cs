using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_4_ocenki
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiStudenti = int.Parse(Console.ReadLine());
           
            decimal[] ocenki = new decimal[broiStudenti];

            decimal topStudents = 0;
            decimal between4and499students = 0;
            decimal between3and399students = 0;
            decimal failStudents = 0;
            decimal sborUspeh = 0;

            for (int i =0; i < broiStudenti; i ++)
            {
                ocenki[i] = decimal.Parse(Console.ReadLine());
                
                if (ocenki[i] >= 5.00m)
                {
                    topStudents++;
                }

                if (4.00m <= ocenki[i] && ocenki[i] <= 4.99m)
                {
                    between4and499students++;
                }

                if (ocenki[i] >= 3.00m && ocenki[i] <= 3.99m)
                {
                    between3and399students++;
                }

                if (ocenki[i] < 3.00m)
                {
                    failStudents++;
                }

                sborUspeh = sborUspeh + ocenki[i];
            }

            

            Console.WriteLine($"Top students: {(topStudents / broiStudenti * 100):0.00}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(between4and499students / broiStudenti * 100):0.00}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(between3and399students / broiStudenti * 100):0.00}%");
            Console.WriteLine($"Fail: {(failStudents / broiStudenti * 100):0.00}%");
            Console.WriteLine($"Average: {(sborUspeh / broiStudenti):0.00}");


        }
    }
}
