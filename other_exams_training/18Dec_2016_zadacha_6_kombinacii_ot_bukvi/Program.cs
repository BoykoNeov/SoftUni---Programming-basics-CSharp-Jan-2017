using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Dec_2016_zadacha_6_kombinacii_ot_bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            int bukva1 = char.Parse(Console.ReadLine());
            int bukva2 = char.Parse(Console.ReadLine());
            int bukva3 = char.Parse(Console.ReadLine());

            int broiOtpechataniKombinacii = 0;

            for (int nomerSimvol1 = bukva1; nomerSimvol1 <= bukva2; nomerSimvol1++)
            {
                if (nomerSimvol1 == bukva3) continue;
                                
                for (int nomerSimvol2 = bukva1; nomerSimvol2 <= bukva2; nomerSimvol2++)
                {
                    if(nomerSimvol2 == bukva3) continue;

                    for (int nomerSimvol3 = bukva1; nomerSimvol3 <= bukva2; nomerSimvol3++)
                    {
                        if (nomerSimvol3 == bukva3) continue;

                        Console.Write($"{Convert.ToChar(nomerSimvol1)}{Convert.ToChar(nomerSimvol2)}{(Convert.ToChar(nomerSimvol3))} ");
                    //    Console.Write(Convert.ToChar(nomerSimvol1));
                    //    Console.Write(Convert.ToChar(nomerSimvol2));
                    //    Console.Write(Convert.ToChar(nomerSimvol3));
                    //    Console.Write(" ");
                        broiOtpechataniKombinacii++;
                    }                 
                }
            }

            Console.Write(broiOtpechataniKombinacii);

        }
    }
}
