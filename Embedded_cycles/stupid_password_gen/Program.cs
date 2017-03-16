using System;


namespace stupid_password_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 < n; i1++)
            {
                for (int i2 = 1; i2 < n; i2++)
                {
                    for (int i3 = 97; i3 < L + 97; i3++)
                    {
                        for (int i4 = 97; i4 < L + 97; i4++)
                        {
                            int i5 = 1;
                            if (i5 < i1) i5 = i1;
                            if (i5 < i2) i5 = i2;
                            if (i5 == i1 || i5 == i2) i5++;
                            for (; i5 <= n; i5++)
                            {
                                char a3 = (char)i3;
                                char a4 = (char)i4;
                                Console.Write(i1);
                                Console.Write(i2);
                                Console.Write(a3);
                                Console.Write(a4);
                                Console.Write(i5);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
