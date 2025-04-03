using System.Reflection.Metadata;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to fizzbuzz!");

            char choice;

            do
            {

                Console.Write("\nEnter a number please: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 5 == 0 && num % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (num % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("FIZZ");
                }
                else if(num % 3 == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine("That isn't fizz or buzz");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nWould you like to play again? (y/n): ");
                choice = Console.ReadKey().KeyChar;
            } while (choice == 'y' || choice == 'Y');//idk how to do the ignores case stuff to a char
        }
    }
}
