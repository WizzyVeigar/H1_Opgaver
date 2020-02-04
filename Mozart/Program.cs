using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            Mozart mozart = new Mozart("Mozart");
            Piano piano = new Piano();
            Console.Title = "♪♪♪♪";
            mozart.MakeNewSong();
            mozart.Play(piano);
        }
    }
}
