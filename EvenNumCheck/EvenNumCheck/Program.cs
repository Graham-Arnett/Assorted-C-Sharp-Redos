namespace EvenNumCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my even number checker!");
            char redo;
            char[] acceptChars = {'y','Y','n','N'};
            double entry = 0;
            do
            {
                Console.Write("\nEnter a number please: ");
                //double entry = double.Parse(Console.ReadLine());
                while(!double.TryParse(Console.ReadLine(), out entry))
                {
                    Console.WriteLine("Invalid format, please enter a number!");
                    Console.Write("\nEnter a number please: ");
                }
                if (entry % 2 == 0)
                {
                    Console.WriteLine("Yeah, that's even.");
                }
                else
                {
                    Console.WriteLine("Nah, its odd.");
                }
                bool validChar = false;
                do { 
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
                    if (acceptChars.Contains(redo))
                    {
                       validChar = true;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease try and enter a valid input again.\n");
                    }
                }while(!validChar);
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye, thanks for playing!");
        }
    }
}
