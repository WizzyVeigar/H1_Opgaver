using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Opgaver
{
    class Loops_Task
    {
        public int i = 0;

        public string LoopTo99ButWriteUntil50()
        {
            string temp = string.Empty;

            for (int i = 0; i < 99; i++)
            {
                if (i < 50)
                {
                    temp += i.ToString() + "\n";
                }
            }

            return temp;
            return "Something more happen";
        }

        public string WhileLoopUntil99()
        {
            int i = 1;
            while (i < 99)
            {
                i++;
                return i.ToString();
            }

            return "The knights who say NI";
        }

        public string LoopFrom100To0()
        {
            for (int i = 100; i > 0; i--)
            {
                return i.ToString();
            }
            return "Not True";
        }
    }
}
