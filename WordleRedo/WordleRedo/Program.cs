namespace WordleRedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wordle Redo App");

            char redo;
            Random random = new Random();
            bool gameOver = false;
            bool victory = false;//probably will not keep this variable, but I'm using this to help me code the skeleton here
            //this time we are getting the words from file io, and if you win a round you get to add a new FIVE letter word
            do
            {
                //we need a for loop to iterate through the chosen word and match the letters at position
                //we need to change the colors depending on if that letter is in the right spot or not
                //it would be cool if we could straight up limit entering more or less than 5 letters
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
