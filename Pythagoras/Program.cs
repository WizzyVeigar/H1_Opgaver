using System;=
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert a second number");
            double secondNum = double.Parse(Console.ReadLine());
            
            if (firstNum > secondNum)
                Console.WriteLine("The first number is bigger than the second");
            else
                Console.WriteLine("The second number is bigger than the first");

            double result = firstNum * firstNum + secondNum * secondNum;
            result /= result;

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }
    }
}
