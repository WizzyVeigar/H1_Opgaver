using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseLetter
    {
        private string morseValue;

        public string MorseValue
        {
            get { return morseValue; }
            set { morseValue = value; }
        }

        private string letterValue;


        public string LetterValue
        {
            get { return letterValue; }
            set { value = letterValue; }
        }

        public MorseLetter(string morseValue, string letterValue)
        {
            MorseValue = morseValue;
            LetterValue = letterValue;
        }

    }
}
