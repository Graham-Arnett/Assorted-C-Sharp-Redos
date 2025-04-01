namespace WordLengthApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my wordlength app!");
            char choice;//this is for the do/while
            do
            {
                int wordlength = 0; //initialize at zero, I realized this wasn't necessary at all but whatever
                Console.Write("\nPlease enter a word: ");
                string word = Console.ReadLine();

                Console.WriteLine($"Your word is {word.Length} letters long!");
                Console.Write("\nWould you like to go again? (y/n): ");
                choice = Console.ReadKey().KeyChar;
            }while(choice == 'y' || choice == 'Y');
        }
    }
}
