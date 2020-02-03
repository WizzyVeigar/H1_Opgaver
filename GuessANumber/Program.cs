using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secwetNumbwer = random.Next(0, 101);
            while (true)
            {
                Console.WriteLine("Guess a number");
                int number = int.Parse(Console.ReadLine());
                #region ifstatements

                if (number > secwetNumbwer + 20)
                {
                    Console.WriteLine("Way lower");
                }

                else if (number > secwetNumbwer + 10)
                {
                    Console.WriteLine("lower....");
                }

                else if (number < secwetNumbwer - 20)
                {
                    Console.WriteLine("Higher sir!");
                }

                else if (number < secwetNumbwer - 10)
                {
                    Console.WriteLine("Just a bit more now, higher!");
                }

                else if (number < secwetNumbwer || number > secwetNumbwer)
                {
                    Console.WriteLine("You are right around it now");
                }

                else
                    Console.WriteLine("You got it! UwU");
                #endregion
                Console.ReadKey();
            }
        }
    }
}
