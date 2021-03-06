﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postage
{
    class PriceCalculator
    {
        //calculates the price of the package, depending on weight and where it is going
        public string CalculatePrice(Mail mail, CountryName country)
        {
            double price;

            switch (mail.Type)
            {
                case PackageType.Letter:
                    if (country == CountryName.Denmark)
                    {
                        price = mail.Weight / 5;
                        return "Prisen er sgu : " + price.ToString();
                    }

                    else if (country == CountryName.England)
                    {
                        price = mail.Weight / 5 + 10;
                        return "The amount of coins you need to retrieve out of your wallet is: " + price;
                    }

                    else
                    {
                        price = mail.Weight / 5 + 10;
                        return "THE GOD DAMN PRICE IS " + price + " OK?!";
                    }

                case PackageType.Package:
                    return "To be implemented :)";


            }

            return "Something went horrible wrong";
        }
    }
}
