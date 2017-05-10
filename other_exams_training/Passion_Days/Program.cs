using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_purchases = 0;  //the number of purchases
            decimal money = decimal.Parse(Console.ReadLine()); // total money


            string read_string = Console.ReadLine();

            while (read_string != "mall.Exit")
            {
                read_string = Console.ReadLine(); //purchases



                int String_length = read_string.Length;  // dyljina na stringa (do 20)
                char[] working_char = new char[String_length];  //syzdavame char array s golemina duljinata na stringa

                for (int i = 0; i < String_length; i++)
                {
                    working_char[i] = read_string[i];  //prehvyrlqme stringa v char array
                }

                for (int j = 0; j < String_length; j++)
                {
                    decimal cena = 0;

                    if (working_char[j] != '%')
                    {

                        if (char.IsUpper(working_char[j]) == true)
                        {
                            cena = (decimal)working_char[j] * 0.5m;   //50% otstypka pri glavni bukvi
                        }

                        if (char.IsLower(working_char[j]) == true)
                        {
                            cena = (decimal)working_char[j] * 0.3m;   //70% otstypka pri glavni bukvi
                        }

                        if ((char.IsLower(working_char[j]) == false) && (char.IsUpper(working_char[j]) == false)) //ako ne e bukva
                        {
                            cena = (decimal)working_char[j];
                        }



                    }
                    else
                    {
                        money = money / 2;
                        cena = 0;
                    }

                    if (money - cena >= 0)
                    {
                        money = money - cena;
                        number_of_purchases++;
                    }



                }
             }

            {

                if (number_of_purchases == 0)
                {
                    Console.WriteLine($"No purchases. Money left: {money:0.00} lv.");
                }
                else
                {
                    Console.WriteLine($"{number_of_purchases} purchases. Money left: {money:0.00} lv.");
                }





            }
        }
    }
}