using System;


namespace probe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int y = 1, z = 1;;y--, z+=2)
            {
                
                Console.WriteLine(x++ + " " + y + " " + z);
                
            }
        }
    }
}
