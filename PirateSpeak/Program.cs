using System;
using System.Collections.Generic;
using System.Linq;

namespace PirateSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordToTranslate = "ortsp";
            char[] input = wordToTranslate.ToCharArray();
            Array.Sort(input);
            string sortedInput = new string(input);

            List<string> suggestedWords = new List<string>();
            List<string> possibleWords = new List<string>()
            {
                "sport","parrot","ports","matey"
            };

            foreach (string word in possibleWords)
            {
                char[] pirateWord = word.ToCharArray();
                Array.Sort(pirateWord);
                string sortedPiratedWord = new string(pirateWord);

                if (sortedInput == sortedPiratedWord) suggestedWords.Add(word);
            }

            //suggestedWords.ForEach(Console.WriteLine);
            Console.WriteLine(suggestedWords.ToList());
        }
    }
}
