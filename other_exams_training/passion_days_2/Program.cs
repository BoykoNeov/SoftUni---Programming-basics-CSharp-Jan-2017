using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passion_days_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyBeginning = 0;
            decimal moneyLeft = 0;
            int purchasesMade = 0;
            decimal currentPrice = 0;
            string currentString = "";

            moneyBeginning = decimal.Parse(Console.ReadLine()); //reads the starting money ammount from the console
            moneyLeft = moneyBeginning;

            

            while (currentString != "mall.Enter")
            {
               currentString = Console.ReadLine();  //reads the initial start statement
            }
            

            for (; true;)
            {
                currentString = Console.ReadLine();

                if (currentString == "mall.Exit") break;   //stop process and exit mall if the this command statement is encountered


                for (int j = 0; j < currentString.Length; j++)
                {
                    if (char.IsUpper(currentString[j]) == true)
                    {
                        currentPrice = ((decimal)currentString[j]) * 0.5m;   //50% otstypka pri glavni bukvi
                    }

                    if (char.IsLower(currentString[j]) == true)
                    {
                        currentPrice = ((decimal)currentString[j]) * 0.3m;   //70% otstypka pri malki bukvi
                    }

                    if (currentString[j] == '%')
                    {
                        currentPrice = moneyLeft / 2;
                    }

                    if ((char.IsLower(currentString[j]) == false) && (char.IsUpper(currentString[j]) == false) && (currentString[j] != '%') && (currentString[j] !='*'))   //ako ne e bukva
                    {
                        currentPrice = (decimal)currentString[j];
                    }

                    if (((moneyLeft - currentPrice) >= 0) && (currentString[j] != '*'  ) && (currentPrice != 0))
                    {
                        moneyLeft = moneyLeft - currentPrice;
                        purchasesMade++;
                    }

                    if (currentString[j] == '*')
                    {
                        moneyLeft = moneyLeft + 10;
                    }
                }
            }
        
            if (purchasesMade == 0)
                {
                    Console.WriteLine($"No purchases. Money left: {moneyLeft:0.00} lv.");
                }
                else
                    {
                     Console.WriteLine($"{purchasesMade} purchases. Money left: {moneyLeft:0.00} lv.");
                    }
            



        }
    }
}
