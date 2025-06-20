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
                    Console.WriteLine("Please enter a sentence, note that a sentence is considered as complete if there is a punctuation mark at the end.");
                    string sentence = Console.ReadLine();
                    
                    if (sentence.EndsWith("!") || sentence.EndsWith("?") || sentence.EndsWith("."))
                    {
                        Console.WriteLine("That is a valid sentence, you can continue.");
                        validSent = true;
                    }
                    else
                    {
                        Console.WriteLine("That is invalid. Please try again.");
                    }
                }
                Console.Write("Would you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
