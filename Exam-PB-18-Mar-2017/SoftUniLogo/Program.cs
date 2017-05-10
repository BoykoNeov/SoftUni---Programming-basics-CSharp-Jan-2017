using System;


namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hatHeight = 4 * n - 2;
            int rowsLeftToDrawMiddle = hatHeight;
            int hatWidth = 12 * n - 5;

            int upperPointCount = 0;
            int upperHashCount = 0;

            for (int i = 0; i < n * 2; i++)
            {
                upperHashCount = 1 + 6 * i;
                upperPointCount = (hatWidth - upperHashCount)/ 2;
                string upperHash = new string('#',upperHashCount);
                string upperPoint = new string('.', upperPointCount);
                Console.WriteLine(upperPoint + upperHash + upperPoint);
            }
            rowsLeftToDrawMiddle = n -2;

            string middlePoint = "";
            string middleHash = "";
            for (int j = 0; j <= rowsLeftToDrawMiddle; j++)
            {
                int middlePointCount = 2 + 3 * j;
                int middleHashCount = hatWidth - (middlePointCount * 2) - 2;
                middlePoint = new string('.', middlePointCount);
                middleHash = new string('#', middleHashCount);
                Console.WriteLine($"|{middlePoint}{middleHash}{middlePoint}.");
            }

            for (int k = 0; k < n-2; k++)
            {
                Console.WriteLine($"|{middlePoint}{middleHash}{middlePoint}.");
            }
            Console.WriteLine($"@{middlePoint}{middleHash}{middlePoint}.");
        }
    }
}
