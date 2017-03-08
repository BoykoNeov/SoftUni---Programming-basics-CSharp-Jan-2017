using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result;
            string date_format = "dd-MM-yyyy";
            string date = Console.ReadLine();
            result = DateTime.ParseExact(date, date_format, provider);
            result = result.AddDays(999);
            Console.WriteLine(result.ToString(date_format));
        }
    }
}
