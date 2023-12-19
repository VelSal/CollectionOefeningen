using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1.Models
{
    public class WordsList
    {
        public static void AskWord()
        {
            bool isRunning = true;
            List<string> words = new List<string>();

            while (isRunning)
            {
                Console.Write("Give me a word: ");
                string wordUserInput = Console.ReadLine().ToLower();

                if (!words.Contains(wordUserInput) && wordUserInput != "end")
                {
                    Console.WriteLine($"{WordsList.GreenAdded()}");
                    Console.ResetColor();
                    words.Add(wordUserInput);
                }
                else if (words.Contains(wordUserInput) && wordUserInput != "end")
                {
                    Console.WriteLine($"{WordsList.RedNotAdded()}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Ending Program.\nThe words in your list are: ");
                    string listString = string.Join(", ", words);
                    foreach (var item in listString)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(item);
                        Console.ResetColor();
                    }
                    isRunning = false;
                }
            }
        }
        static string GreenAdded()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "Added";
        }
        static string RedNotAdded()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "Not Added";
        }
    }
}
