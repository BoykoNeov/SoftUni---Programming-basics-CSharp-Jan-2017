using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungry_garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine())/rate;
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine())/rate;
            decimal sandwichPrice = decimal.Parse(Console.ReadLine())/rate;
            ulong pizzaQuantity = ulong.Parse(Console.ReadLine());
            ulong lasagnaQuantity = ulong.Parse(Console.ReadLine());
            ulong sandwichQuantity = ulong.Parse(Console.ReadLine());

            decimal moneyNeeded_total;
            decimal money_left;

            moneyNeeded_total = (pizzaPrice * pizzaQuantity) + (lasagnaPrice * lasagnaQuantity) + (sandwichPrice * sandwichQuantity);

            money_left = money - moneyNeeded_total;

           //  money_left = Math.Round(money_left, 2);

            

            if (money_left < 0)
            {
                money_left = money_left * -1;
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${money_left:0.00}.");
            }
            else
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${money_left:0.00}.");
            }


        }
    }
}
