using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postage
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail mail = new Mail(40, 30, 100, PackageType.Letter);
            PriceCalculator priceCalculator = new PriceCalculator();
            Console.WriteLine(priceCalculator.CalculatePrice(mail, CountryName.Denmark));
            Console.ReadLine();
        }
    }
}
