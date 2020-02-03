using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Betingelser
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            while (true)
            {
                Console.WriteLine(dice.ThrowDice());
                Console.ReadKey();
            }
        }


        public class Dice
        {
            Random dice = new Random();

            public string ThrowDice()
            {
                int num = dice.Next(1, 7);

                switch (num)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        return "Du slog en etter";

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "Du slog en toer";

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return "Du slog en treer";

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        return "Du slog en firer";

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        return "Du slog en femmer";

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        return "Du slog en sekser";

                    default:
                        return "Whoops";
                }
            }
        }
    }
}
