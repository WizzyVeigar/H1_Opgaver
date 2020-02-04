using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            LottoTicket winnerTicket = new LottoTicket();
            LottoTicket userTicket = new LottoTicket();
            int numbersMatching = 0;

            for (int i = 0; i < winnerTicket.lottoNumbers.Length; i++)
            {
                foreach (int uNumber in userTicket.lottoNumbers)
                {
                    if (winnerTicket.lottoNumbers[i] == uNumber)
                    {
                        numbersMatching++;
                        break;
                    }
                }
            }

            switch (numbersMatching)
            {
                case 0:
                    Console.WriteLine("Wah wah waaaaaah");
                    break;
                case 1:
                    Console.WriteLine("Better luck next time");
                    break;
                case 2:
                    Console.WriteLine("You get the lowest price!");
                    break;
                case 3:
                    Console.WriteLine("Hey good job, kid");
                    break;
                case 4:
                    Console.WriteLine("Not bad, not bad");
                    break;
                case 5:
                    Console.WriteLine("You almost had it champ!");
                    break;
                case 6:
                    Console.WriteLine("You were so close!");
                    break;
                case 7:
                    Console.WriteLine("You lucky bastards");
                    break;
            }
            Console.ReadKey();
        }
    }
}
