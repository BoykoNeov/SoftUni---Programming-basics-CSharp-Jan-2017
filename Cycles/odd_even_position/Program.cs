using System;


namespace odd_even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());                   // read the number of numbers to be read

            double oddSum = 0;
            double oddMin = 0;
            double oddMax = 0;
            double evenSum = 0;
            double evenMax = 0;
            double evenMin = 0;                                                 //define the sought values

            if (numbersCount == 0)                                              //the case with no input numbers
                {
                Console.WriteLine($"OddSum=0,");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum=0,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");

            }
            else if (numbersCount == 1)                                        //the case with 1 input number
                {
                double readNumber = double.Parse(Console.ReadLine());
                Console.WriteLine($"OddSum={readNumber},");
                Console.WriteLine($"OddMin={readNumber},");
                Console.WriteLine($"OddMax={readNumber},");
                Console.WriteLine($"EvenSum=0,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }

            else
            {
                for (int cycles = 1; cycles <= numbersCount; cycles++)           //cycle for reading and processing the numbers
                {
                    double readNumber = double.Parse(Console.ReadLine());       // read a number and parse it
                    if (cycles % 2 != 0)                                        //processing of odd numbers
                    { 
                        if (cycles == 1)                                       // set the min/max values to the first odd number
                        {
                            oddMax = readNumber;                                //set min and max values for the first odd number
                            oddMin = readNumber;
                        }
                    
                                oddSum += readNumber;                               //process the first odd number
                                if (readNumber >= oddMax)
                                {
                                    oddMax = readNumber;
                                }
                                if (readNumber <= oddMin)
                                {
                                    oddMin = readNumber;
                                }
                    }

                    if (cycles % 2 == 0)
                    {
                        if (cycles == 2)                                            
                        {   
                            evenMax = readNumber;                                       //set min and max for the first even number
                            evenMin = readNumber;
                        }
                                evenSum += readNumber;                                  //processing of even numbers
                                if (readNumber >= evenMax)
                                {
                                    evenMax = readNumber;
                                }
                                if (readNumber <= evenMin)
                                {
                                    evenMin = readNumber;
                                }
                    }

                }
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");


            }

        }
    }
}
