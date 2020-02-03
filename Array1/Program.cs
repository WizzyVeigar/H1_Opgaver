using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarr = new int[9];

            for (int i = 0; i < intarr.Length; i++)
            {
                intarr.SetValue(i + 1, i);
                Console.WriteLine(intarr[i]);
            }

            for (int i = 0; i < intarr.Length; i++)
            {
                if (i == 5)
                    Console.WriteLine(intarr[i]);
            }

            for (int i = 0; i < intarr.Length; i++)
            {
                if (i == 5)
                    intarr[i] = intarr[i - 1] * 2;
            }
            Console.ReadKey();
        }
    }
}
