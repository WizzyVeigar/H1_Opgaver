using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            GUIMenu menu = new GUIMenu();                      

            while (true)
            {
                menu.StartMenu();
                Console.ReadKey();
            }
        }
    }
}
