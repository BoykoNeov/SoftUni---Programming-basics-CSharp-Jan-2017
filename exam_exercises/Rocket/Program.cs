using System;


namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rocketLength = n * 3;

            for (int i = 0; i < n; i++)
            {
                int upperWhiteSpacesCount = 2 * i;
                int upperDotsCount = (rocketLength - upperWhiteSpacesCount - 2) / 2;

                string upperDots = new string('.',upperDotsCount);
                string upperWhiteSpaces = new string(' ',upperWhiteSpacesCount);

                Console.WriteLine (upperDots+ "/" + upperWhiteSpaces + "\\" + upperDots);
            }

            string middleDots = new string('.',(n /2));
            int middleStarsLenght = rocketLength - (n / 2) * 2;
            string middleStars = new string('*',(middleStarsLenght));
            Console.WriteLine(middleDots + middleStars + middleDots);

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(middleDots + "|" + new string('\\', middleStarsLenght - 2) + "|" + middleDots);
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string ('.',middleDots.Length-i) + "/" + new string ('*',(middleStarsLenght -2) + 2*i) + "\\" + new string ('.', middleDots.Length - i)) ;
            }
        }
    }
}
