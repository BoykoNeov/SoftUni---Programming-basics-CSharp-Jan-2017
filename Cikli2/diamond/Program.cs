using System;


namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string edgeDash = "";
            string centerDash = "";
            string leftPart = "";
            string rightPart = "";

            if (n % 2 == 0)                           //if the number is even
            {

                for (int x1 = 0; x1<n-1; x1++)
                {
                    edgeDash = new string('-', Math.Abs(n / 2 - 1 - x1));
                    leftPart = edgeDash + "*";
                    rightPart = "*" + edgeDash;
                    string leftAndRight = leftPart + rightPart;
                    Console.WriteLine(leftPart + new string ('-', n - leftAndRight.Length ) + rightPart);
                }
            }

            else                                      //if the number is odd
            {
                for (int x2 = 0; x2 < n; x2++)
                {
                    edgeDash = new string('-', Math.Abs((n -1) / 2 - x2));
                    leftPart = edgeDash + "*";
                    rightPart = edgeDash;
                    string leftAndRight = leftPart + rightPart;
                    if (leftAndRight.Length < n)
                    {
                        rightPart = new string('-', (n - leftAndRight.Length - 1)) + "*" + edgeDash;
                    }
                    Console.WriteLine(leftPart + rightPart);
                }
            }
        }
    }
}
