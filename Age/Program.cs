using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvem er du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            byte age = byte.Parse(Console.ReadLine());

            if (age < 3 )
            {
                Console.WriteLine(name + ", Du må ble");
            }
            else if (age >= 3 && age <= 15)
            {
                Console.WriteLine(name +", Du må nul");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine(name + " ,Du må drikke");
            }
            else
            {
                Console.WriteLine(name + ", Du må det hele, selv det ulovlige");
            }
            Console.ReadKey();
        }
    }
}
