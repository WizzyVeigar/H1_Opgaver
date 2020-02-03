using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Volume_Task volume_Task = new Volume_Task();
            volume_Task.CreateBox(10, 5, 10);
            Console.WriteLine(volume_Task.CalculateVolume());
            Console.ReadKey();
        }
    }
}
