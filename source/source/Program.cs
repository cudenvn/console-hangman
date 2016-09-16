using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordBank =
            {
                "abruptly",
                "affix",
                "askew",
                "axiom",
                "azure",
                "bagpipes",
                "bandwagon",
                "dwarves",
                "fixable",
                "jazzy",
                "jigsaw",
                "kilobyte",
                "oxidize",
                "oxygen",
                "quartz",
                "unworthy",
                "whiskey",
                "whomever",
                "zodiac",
                "zombie"
            };
            //properties
            int lives = 6;
            string wrong = "";
            int count;
            //welcome
            Console.WriteLine("welcome to this amazing hangman game written by Viet Ng");

            //choose a random word
            Random rnd = new Random();
            string randomWord = wordBank[rnd.Next(wordBank.Length - 1)];
            //Console.WriteLine("[" + randomWord + "]");
            char[] chosenWord = randomWord.ToCharArray();
            count = randomWord.Length;
            //display the number of letters in word
            for (int i = 0; i < chosenWord.Length; i++)
            {
                chosenWord[i] = '_';
                Console.Write(chosenWord[i] + " ");
            }

            while (lives != 0)
            {
                Console.WriteLine("\n\nenter your guess");
                char guess = Console.ReadLine().ToCharArray()[0];
                bool check = true;
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (guess == randomWord[i])
                    {
                        chosenWord[i] = guess;
                        count--;
                        check = false;
                    }
                } //guess loop ends
                for (int j = 0; j < chosenWord.Length; j++)
                {
                    Console.Write(chosenWord[j] + " ");
                }
                if (count == 0)
                {
                    break;
                }
                if (check)
                {
                    lives--;
                    wrong += guess + ", ";
                    Console.WriteLine("\nletters guessed : " + wrong);
                }
            } //while ends
            if (lives != 0)
            {
                Console.WriteLine("\n\nCongrat!");
            }
            else
            {
                Console.WriteLine("\n\nOver!");
            }
            Console.ReadKey();
        }
    }
}
