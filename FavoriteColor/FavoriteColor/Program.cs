namespace FavoriteColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite color?");
            char redo;
            do
            {
                Console.Write("\nWhat is your favorite color? ");
                string choice = Console.ReadLine().ToLower().Trim();
                switch (choice)
                {
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The color of vast oceans, good choice!");
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ah the color of blood and passion, good choice!");
                        break;
                    case "pink":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The color of love, good choice!");
                        break;
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("My personal favorite.");
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The color of shiny emeralds and vast forests, nice choice.");
                        break;
                }
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("\nWould you like to try again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            }while (redo == 'y' || redo == 'Y');
        }
    }
}
