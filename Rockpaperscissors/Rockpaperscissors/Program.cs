namespace Rockpaperscissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Scissors");

            char redo;
            Random random = new Random();
            int playerScore = 0;
            int enemScore = 0;
            do
            {
                Console.Write("\nr for rock, s for scissors, p for paper: ");
                char choice = Console.ReadKey().KeyChar;
               int enemchoice = random.Next(1,4);
                if (choice != 'r' && choice != 's' && choice != 'p')
                {
                    Console.WriteLine("You need to say r, s, or p. Please no capital letters either.");
                   
                }
                else
                {
                    if ((choice == 'r' && enemchoice == 1) || (choice == 's' && enemchoice == 2) || (choice == 'p' && enemchoice == 3))
                    {
                        Console.WriteLine("\nIt is a DRAW");
                    }
                    else if ((choice == 'r' && enemchoice == 2) || (choice == 's' && enemchoice == 3) || (choice == 'p' && enemchoice == 1))
                    {
                        Console.WriteLine("\nYou win!");
                        playerScore++;
                    }
                    else if ((choice == 'r' && enemchoice == 3) || (choice == 's' && enemchoice == 1) || (choice == 'p' && enemchoice == 2))
                    {
                        Console.WriteLine("\nYou have lost!");
                        enemScore++;
                    }
                }
                    Console.Write($"\nTotal enemy score between all games is: {enemchoice} and total player score between all games is: {playerScore}." +
                    $"\nWould you like to play again? (y/n):");
                redo = Console.ReadKey().KeyChar;
            } while(redo == 'y' || redo == 'Y');
        }
    }
}
