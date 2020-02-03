using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Task
{
    class Program
    {
        public static void Main(string[] args)
        {
            Loops loops = new Loops();

            loops.loopEvent += Loops_loopEvent;

            loops.FromZeroToHundred();

        }

        private static void Loops_loopEvent(int value)
        {
            Console.WriteLine(value);
        }
    }


}
