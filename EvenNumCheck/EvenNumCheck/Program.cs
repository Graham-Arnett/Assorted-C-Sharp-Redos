namespace EvenNumCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my even number checker!");
            char redo;

            do
            {
                Console.Write("\nEnter a number please: ");
                double entry = double.Parse(Console.ReadLine());
                if (entry % 2 == 0)
                {
                    Console.WriteLine("Yeah, that's even.");
                }
                else
                {
                    Console.WriteLine("Nah, its odd.");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
