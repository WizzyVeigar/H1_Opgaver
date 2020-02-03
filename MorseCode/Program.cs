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
            MorseAlphabet morseAlphabet = new MorseAlphabet();
            

            Console.WriteLine("Write what you want converted: ");
            Console.WriteLine(morseAlphabet.TranslateToMorseCode(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
