using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Task
{
    class Loops
    {
        public delegate void LoopEventHandler(int value);
        public event LoopEventHandler loopEvent;

        public void FromZeroToHundred()
        {
            for (int i = 0; i <= 99; i++)
            {
                if (i < 50)
                {
                    loopEvent(i);
                }
            }
        }

        public void WhileZeroToHundred()
        {
            int i = 0;
            while (i <= 99)
            {
                loopEvent(i);
                i++;
            }
        }

        public void CountingDownZeroToHundred()
        {
            for (int i = 100; i > 0; i--)
            {
                loopEvent(i);
            }
        }
    }
}
