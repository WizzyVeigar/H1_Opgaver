using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Opgaver
{
    class ValutaOmregner
    {

        static void Main(string[] args)
        {
            DollarCalculator dollarCalculator = new DollarCalculator();
            BritishPoundCalculator poundCalculator = new BritishPoundCalculator();
            SwedishCrownCalculator crownCalculator = new SwedishCrownCalculator();


            Console.WriteLine("Insert how many Danish crowns you have");
            double input = double.Parse(Console.ReadLine());


            Console.WriteLine(dollarCalculator.Calculate(input));
            Console.WriteLine(poundCalculator.Calculate(input));
            Console.WriteLine(crownCalculator.Calculate(input));
            Console.ReadKey();
        }
    }
}
