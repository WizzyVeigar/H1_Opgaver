using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MorseGenerator morseGenerator = new MorseGenerator();
            Console.WriteLine("Write what you want converted: ");
            morseGenerator.GenerateMorse(Console.ReadLine());
        }
    }
}
