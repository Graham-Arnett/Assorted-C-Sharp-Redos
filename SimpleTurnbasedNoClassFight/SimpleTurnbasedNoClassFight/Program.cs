namespace SimpleTurnbasedNoClassFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn based fight sim");

            string choice;
            Random random = new Random();
            int playHealth = 100;
            int enemHealth = 100;
            int slashDam = 11;
            int zapDam = 16;
            int cureAmt = 20;
            char[] actions = {'S','C','Z'};
            do
            {
                Console.WriteLine("You wander into an abandoned castle, your hand hovering above the hilt of your shortsword at your side. As you ascend the cobalt carpeted stairs, the Bandit King leaps from his throne. Prepare to fight!");
                while(playHealth > 0 | enemHealth > 0)
                {

                }
                Console.Write("Would you like to go again? (y/n): ");
            choice = Console.ReadLine().ToLower();
            }
            while (true);
        }
    }
}
