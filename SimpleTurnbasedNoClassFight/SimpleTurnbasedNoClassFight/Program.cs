namespace SimpleTurnbasedNoClassFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn based fight sim");

            string choice;

            int playHealth = 100;
            int enemHealth = 100;
            int slashDam = 11;
            int zapDam = 16;
            int healAmt = 20;

            do
            {
                Console.Write("Would you like to go again? (y/n): ");
            choice = Console.ReadLine().ToLower();
            }
            while (true);
        }
    }
}
