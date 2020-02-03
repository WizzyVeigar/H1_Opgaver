using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseAlphabet
    {
        Dictionary<string,string> alphabet = new Dictionary<string, string>();

        public MorseAlphabet()
        {
            AddToAlphabet();
        }

        public void AddToAlphabet()
        {
            alphabet.Add(".-", "A");
            alphabet.Add("-...", "B");
            alphabet.Add("-.-.", "C");
            alphabet.Add("-..", "D");
            alphabet.Add(".", "E");
            alphabet.Add("..-.", "F");
            alphabet.Add("--.", "G");
            alphabet.Add("....", "H");
            alphabet.Add("..", "I");
            alphabet.Add(".---", "J");
            alphabet.Add("-.-", "K");
            alphabet.Add(".-..", "L");
            alphabet.Add("--", "M");
            alphabet.Add("---", "O");
            alphabet.Add(".--.", "P");
            alphabet.Add("--.-", "Q");
            alphabet.Add(".-.", "R");
            alphabet.Add("...", "S");
            alphabet.Add("-", "T");
            alphabet.Add("..-", "U");
            alphabet.Add("...-", "V");
            alphabet.Add("-.--", "Y");
            alphabet.Add("--..", "Z");
            alphabet.Add(".-.-", "Æ");
            alphabet.Add("---.", "Ø");
            alphabet.Add(".--.-", "Å");
        }


        public string TranslateToMorseCode(string stringToTranslate)
        {
            string morseCode = string.Empty;

            for (int i = 0; i < stringToTranslate.Length; i++)
            {
                foreach (KeyValuePair<string,string> entry in alphabet)
                {
                    if(entry.Value.ToLower() == stringToTranslate[i].ToString())
                    {
                        morseCode += entry.Key + " ";
                    }
                }
            }
            return morseCode;
        }
    }
}
