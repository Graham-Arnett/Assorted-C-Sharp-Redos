namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app is meant to count the number of words in a sentence");
            char redo;
            do
            {
                int wordCount = 0;
                bool validSent = false;
                while (!validSent)
                {
                    Console.WriteLine("\nPlease enter a sentence, note that a sentence is considered as complete if there is a punctuation mark at the end.");
                    string sentence = Console.ReadLine();

                    if (sentence.EndsWith("!") || sentence.EndsWith("?") || sentence.EndsWith("."))
                    {
                        Console.WriteLine("That is a valid sentence, you can continue.");
                        validSent = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThat is invalid. Please try again.");
                    }
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        if (sentence[i] == ' ' || sentence[i] == '.' || sentence[i] == '?' || sentence[i] == '!')
                        {
                            wordCount++; //the thought process is if you spot a space, you just got to the end of the word, and you always put the punctuation right after a word
                        }
                    }
                }
                Console.WriteLine($"Your sentence had {wordCount} words in it!");
                Console.Write("Would you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye, thanks for playing!");
        }
    }
}
