using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lotto
{
    class LottoTicket
    {
        public int[] lottoNumbers = new int[7];
        //stupid random
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        //Random rnd = new Random(DateTime.Now.Millisecond);

        public LottoTicket()
        {
            GenerateNumbers(this);
        }

        public void GenerateNumbers(LottoTicket ticket)
        {
            for (int i = 0; i < 7; i++)
            {
                ticket.lottoNumbers[i] = rnd.Next(1, 20);
            }
        }
    }
}
