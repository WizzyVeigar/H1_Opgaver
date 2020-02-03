using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {           
            Loops_Task loops_Task = new Loops_Task();
            Console.WriteLine(loops_Task.LoopTo99ButWriteUntil50());
            Console.ReadKey();
        }
    }


}
