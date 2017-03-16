using System;


namespace magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 1; i2 < 10; i2++)
                {
                    for (int i3 = 1; i3 < 10; i3++)
                    {
                        for (int i4 = 1; i4 < 10; i4++)
                        {
                            for (int i5 = 1; i5 < 10; i5++)
                            {
                                for (int i6 = 1; i6 < 10; i6++)
                                {
                                    if (i1 * i2 *i3 *i4 *i5 *i6 == n)
                                    {
                                        Console.Write($"{i1}{i2}{i3}{i4}{i5}{i6} ");   
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
