using System;
using System.Collections.Generic;
using System.Text;

namespace bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            double tochkiNachalo = double.Parse(Console.ReadLine());
            double bonusTochki = 0;

            if (tochkiNachalo <= 100) bonusTochki = 5;
            if ((tochkiNachalo > 100) && (tochkiNachalo <= 1000)) bonusTochki = tochkiNachalo * 0.2d;
            if (tochkiNachalo > 1000) bonusTochki = tochkiNachalo * 0.1d;

            if (tochkiNachalo % 2 == 0) bonusTochki = bonusTochki + 1;

            if ((tochkiNachalo % 2 != 0) && (tochkiNachalo % 5 == 0)) bonusTochki = bonusTochki + 2;

            Console.WriteLine($"{bonusTochki}");
            Console.WriteLine($"{(bonusTochki + tochkiNachalo)}");

        }
    }
}
