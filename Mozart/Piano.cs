using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mozart
{
    class Piano
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        
        //plays audio through media player
        internal void PlayMusic(string song)
        {
                soundPlayer.SoundLocation = song;
                soundPlayer.Load();
                soundPlayer.PlaySync();
         
        }
    }
}
