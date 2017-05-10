using System;


namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int foxWidth = 2 * n + 3;

            DrawFoxParts('*','-',n);

            for (int j = 0; j < n/3; j++)
            {
                int middleMiddleStarsCount = n - j*2;
                int middleEdgeStarsCount = (foxWidth - middleMiddleStarsCount - 4)/2;
                string middleMiddleStars = new string('*',middleMiddleStarsCount);
                string middleEdgeStars = new string('*',middleEdgeStarsCount);
                Console.WriteLine("|" + middleEdgeStars + "\\" + middleMiddleStars + "/" + middleEdgeStars + "|");
            }
            DrawFoxParts('-','*',n);
        }

        public static void DrawFoxParts(char a, char b, int n)
        {
                        for (int i = 0; i < n; i++)
            {
                string upperStars = new string(a,i+1);
                string upperDash = new string(b,(n*2 - (2*i))-1);
                Console.WriteLine(upperStars + "\\" + upperDash + "/" + upperStars);
            }
        }
    }
}
