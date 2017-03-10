using System;


namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                          //draw the first line
           string line1Edge = ("/" + new string ('^',n/2) + "\\" ) ;
           string line1Test = line1Edge + line1Edge;                        //string for testing if center section will be necessary
            if (line1Test.Length - n * 2 < 0)
            {
                Console.WriteLine(line1Edge + new string('_', (n * 2 - line1Test.Length)) + line1Edge);
            }
            else
            {
                Console.WriteLine(line1Edge + line1Edge);
            }

            for (int middleCycle = 0; middleCycle < n-3; middleCycle++)     //draw the main section of the castle
            {
                Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
            }
            string lineLastEdge = ("\\" + new string('_', n / 2) + "/");

            if (line1Test.Length - n * 2 < 0)
            {
                Console.WriteLine("|" + new string (' ', line1Edge.Length - 1) + new string('_', (n * 2 - line1Test.Length)) + new string (' ',line1Edge.Length -1) + "|");
            }
            else
            {
                Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
            }

                string lineLastTest = lineLastEdge + lineLastEdge;                        //string for testing if center section will be necessary
                if (lineLastTest.Length - n * 2 < 0)
                {
                    Console.WriteLine(lineLastEdge + new string(' ', (n * 2 - lineLastTest.Length)) + lineLastEdge);
                }
                else
                {
                    Console.WriteLine(lineLastEdge + lineLastEdge);
                }

       }
    }
}
