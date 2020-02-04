using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozart
{
    class Mozart : Person, IPianist
    {
        string[] vals;
        string[,] miniuetteArr = new string[16, 11]
        {
            { "96","32","69","40","148","104","152","119","98","3","54" },
            { "22","6","95","17","74","157","60","84","142","87","130"},
            { "141","128","158","113","163","27","171","114","42","165","10"},
            { "41","63","13","85","45","167","53","50","156","165","10"},
            { "105","146","153","161","80","154","99","140","75","135","28"},
            { "122","46","55","2","97","68","133","86","129","47","37"},
            { "11","134","110","159","36","118","21","169","62","147","106"},
            { "30","81","24","100","107","91","127","94","123","33","5"},
            { "70","117","66","90","25","138","16","120","65","102","35"},
            { "121","39","139","176","143","71","155","88","77","4","20"},
            { "26","126","15","7","64","150","57","48","19","31","108"},
            { "9","56","132","34","125","29","175","166","82","164","92"},
            { "112","174","73","67","76","101","43","51","137","144","12"},
            { "49","18","58","160","136","162","168","115","38","59","124"},
            { "109","116","145","52","1","23","89","72","149","173","44"},
            { "14","83","79","170","93","151","172","111","8","78","131"}
        };
        string[,] TrioArr = new string[16, 6]
        {
            {"72","56","75","40","83","18"},
            {"6","82","39","73","3","45" },
            {"59","42","54","16","28","62" },
            {"25","74","1","68","53","38" },
            {"81","14","65","29","37","4" },
            { "41","7","43","55","17","27"},
            { "89","26","15","2","44","52"},
            { "13", "71", "80","61","70","94"},
            { "36","76","9","22","63","11"},
            { "5","20","34","67","85","92"},
            { "46","64","93","49","32","24"},
            { "79","84","48","77","96","86"},
            { "30","8","69","57","12","51"},
            { "95","35","58","87","23","60"},
            { "19","47","90","33","50","78"},
            { "66","88","21","10","91","31"}
        };


        public Mozart(string name) : base(name)
        {
            vals = new string[miniuetteArr.GetLength(0) + TrioArr.GetLength(0)];
        }


        public void MakeNewSong()
        {
            Random rnd = new Random();
            vals = new string[miniuetteArr.GetLength(0) + TrioArr.GetLength(0)];


            for (int i = 0; i < miniuetteArr.GetLength(0); i++)
            {
                vals[i] = miniuetteArr[i, rnd.Next(0, miniuetteArr.GetLength(1))];
            }

            for (int i = 0; i < TrioArr.GetLength(0); i++)
            {
                vals[i] = TrioArr[i, rnd.Next(0, TrioArr.GetLength(1))];
            }
        }

        //sends the audio files to the piano to play
        public void Play(Piano piano)
        {
            string songPath;

            for (int i = 0; i < vals.Length; i++)
            {
                //Run Miniuette
                if (i < 16)
                {
                    songPath = Directory.GetCurrentDirectory() + @"\SoundsFiles\M\M" + vals[i] + ".wav";
                    piano.PlayMusic(songPath);
                }
                //Run Trio
                else
                {
                    songPath = Directory.GetCurrentDirectory() + @"C:\Users\seje_\Source\Repos\WizzyVeigar\H1_Opgaver\Mozart\SoundsFiles\T\T" + vals[i] + ".wav";
                    piano.PlayMusic(songPath);
                }
            }
        }
    }
}
