using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace WordleRedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wordle Redo App");

            char redo;
            Random random = new Random();
           
            int turns = 0;
            string[] words = {"ANTSY","AMPLE","AGILE","AFTER","BLOCK","BLACK","BLOAT","BLANK","BOOTS","BOATS",
"BRINE","BRICK","BONES","BONEY","CLACK","CLOAK","COATS","COMBS","CHILL","CRIMP","CHIMP","CHAMP","CHOMP",
"DEALT","DYING","DEEMS","EXTRA","EXERT","FIGGY","FOOLS","GREAT","GHOUL","GHAST","GOATS","GRATE","GUMBO",
"HOOPS","HYMNS","HOLES","HOODS","INNER","INTER","INERT","JOKES","JAPES","JUKED","LUMPS","LOOPS",
"LEAPS","MOATS","MILES","MOONS","MOUNT","MEANS","MODES","MOOBS","MOODS","NEWSY","NOTCH","NICHE",};
            //probably will not keep this variable, but I'm using this to help me code the skeleton here
            //this time we are getting the words from file io, and if you win a round you get to add a new FIVE letter word
            do
            {
                //we need a for loop to iterate through the chosen word and match the letters at position
                //we need to change the colors depending on if that letter is in the right spot or not
                //it would be cool if we could straight up limit entering more or less than 5 letters
                bool victory = false;
                string guess;
                int pickedWord = random.Next(words.Length);
                string answer = words[pickedWord];
               while(victory == false && turns <= 6)
                {
                    Console.Write("\nYour guess: ");
                    guess = Console.ReadLine().ToUpper();

                    if(guess == answer)
                    {
                        Console.WriteLine("\n\nYOU WON!");
                        victory = true;
                    }

                   for(int i = 0; i < answer.Length; i++)
                    {
                        if (guess[i] == answer[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (answer.Contains(guess[i]) && guess[i] != answer[i])
                        {
                            Console.ForegroundColor= ConsoleColor.Yellow;
                        }

                        Console.Write($"" + guess[i].ToString() + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        turns++;
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
                if (victory == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWOAH! You won! Would you like to suggest a new 5 letter word to add? (y/n): ");
                }
                Console.Write("\n\nWould you like to play again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
