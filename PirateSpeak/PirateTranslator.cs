using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateSpeak
{
    public class PirateTranslator
    {
        public bool ConfirmPirateSpeak(string wordToTranslate)
        {
            var pirateWords = new List<string>
            {
                "argh",
                "sport",
                "port",
                "plank"
            };

            char[] input = wordToTranslate.ToCharArray();
            Array.Sort(input);
            string sortedInput = new string(input);
            
            foreach(string word in pirateWords)
            {
                char[] pirateWord = word.ToCharArray();
                Array.Sort(pirateWord);
                string sortedPirateWord = new string(pirateWord);

                if (sortedInput == sortedPirateWord) return true;
            }
            return false;
        }

        public List<string> Translate(string wordToTranslate, List<string> possibleWords)
        {
            char[] input = wordToTranslate.ToCharArray();
            Array.Sort(input);
            string sortedInput = new string(input);

            List<string> suggestedWords = new List<string>();

            foreach (string word in possibleWords)
            {
                char[] pirateWord = word.ToCharArray();
                Array.Sort(pirateWord);
                string sortedPiratedWord = new string(pirateWord);

                if (sortedInput == sortedPiratedWord) suggestedWords.Add(word);
            }

            return suggestedWords.ToList();
        }
    }
}
