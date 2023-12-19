using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening0.Models
{
    public class SentenceElementsCount
    {
        public static void AskSentence()
        {
            Console.WriteLine("Give me a sentence please: ");
            string userSentenceInput = Console.ReadLine();

            Console.WriteLine($"The sentence is: {userSentenceInput}");
            Console.WriteLine($"There is a total of {SentenceElementsCount.LetterCountWithSpaces(userSentenceInput)} characters in that sentence.");
            Console.WriteLine($"{SentenceElementsCount.LetterCountWithoutSpaces(userSentenceInput)} characters if you don't count spaces.");
            Console.WriteLine($"There is {SentenceElementsCount.WordsCount(userSentenceInput)} words in that sentence.");
        }

        private static int LetterCountWithSpaces(string userSentenceInput)
        {
            return userSentenceInput.Length;
        }
        private static int LetterCountWithoutSpaces(string userSentenceInput)
        {
            int count = 0;
            foreach (char c in userSentenceInput)
            {
                if (c != ' ')
                {
                    count++;
                }
            }
            return count;
        }
        private static int WordsCount(string userSentenceInput)
        {
            string[] stringSeparators = new string[] { };
            string[] stringArray;
            stringArray = userSentenceInput.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            return stringArray.Length;
        }

    }
}
