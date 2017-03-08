using System;


namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowelsWordInput = Console.ReadLine();
            int vowelsSum = 0;                                                           //define vowels sum
            for (int cycle = 0; cycle < vowelsWordInput.Length; cycle++)                 //cycle for vowels until lenght is reached
            {
                switch (vowelsWordInput[cycle])
                {
                    case 'a':
                        vowelsSum += 1;
                    break;

                    case 'e':
                        vowelsSum += 2;
                        break;

                    case 'i':
                        vowelsSum += 3;
                        break;

                    case 'o':
                        vowelsSum += 4;
                        break;

                    case 'u':
                        vowelsSum += 5;
                        break;
                }
            }
            Console.WriteLine(vowelsSum);                                               //display result
        }
    }
}
