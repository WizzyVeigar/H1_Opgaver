using System;
using System.Collections.Generic;

namespace MorseCode
{
    internal class MorseGenerator
    {
        List<MorseLetter> morseAlphabet = new List<MorseLetter>();

        public MorseGenerator()
        {
        }

        internal void GenerateMorse(string v)
        {
            
        }
        public void GenerateMorseLibrary()
        {
            MorseLetter letterA = new MorseLetter(".-", "A");   
            MorseLetter letterB = new MorseLetter("-...", "B");   
            MorseLetter letterC = new MorseLetter("-.-.", "C");   
            MorseLetter letterD = new MorseLetter("-..", "D");   
            MorseLetter letterE = new MorseLetter(".", "E");   
            MorseLetter letterF = new MorseLetter("..-", "F");   
            MorseLetter letterG = new MorseLetter("--.", "G");   
            MorseLetter letterH = new MorseLetter("....", "H");   
            MorseLetter letterI = new MorseLetter("..", "I");   
            MorseLetter letterJ = new MorseLetter(".---", "J");   
            MorseLetter letterK = new MorseLetter("-.-", "K");   
            MorseLetter letterL = new MorseLetter(".-..", "L");   
            MorseLetter letterM = new MorseLetter("--", "M");   
            MorseLetter letterN = new MorseLetter("-.", "N");   
            MorseLetter letterO = new MorseLetter("---", "O");   
            MorseLetter letterP = new MorseLetter(".--.", "P");   
            MorseLetter letterQ = new MorseLetter("--.-", "Q");   
            MorseLetter letterR = new MorseLetter(".-.", "R");   
            MorseLetter letterS = new MorseLetter("...", "S");   
            MorseLetter letterT = new MorseLetter("-", "T");   
            MorseLetter letterU = new MorseLetter("..-", "U");   
            MorseLetter letterV = new MorseLetter("...-", "V");   
            MorseLetter letterW = new MorseLetter(".--", "W");   
            MorseLetter letterX = new MorseLetter("-..-", "X");   
            MorseLetter letterY = new MorseLetter("-.--", "Y");   
            MorseLetter letterZ = new MorseLetter("--..", "Z");   
            MorseLetter letterÆ = new MorseLetter(".-.-", "Æ");   
            MorseLetter letterØ = new MorseLetter("---.", "Ø");   
            MorseLetter letterÅ = new MorseLetter(".--.-", "Å");   
        }
    }
}