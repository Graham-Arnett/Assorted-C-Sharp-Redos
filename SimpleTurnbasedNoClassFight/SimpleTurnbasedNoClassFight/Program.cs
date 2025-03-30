namespace SimpleTurnbasedNoClassFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn based fight sim");

            string choice;
            Random random = new Random();
           
            char[] actions = {'s','c','z'};
            char act;
            do
            {
                //int enemRoll = random.Next(1,4);
                int playHealth = 100;
                int enemHealth = 100;
                int slashDam = 11;
                int zapDam = 16;
                int cureAmt = 20;
                Console.WriteLine("You wander into an abandoned castle, your hand hovering above the hilt of your shortsword at your side. As you ascend the cobalt carpeted stairs, the Bandit King leaps from his throne. Prepare to fight!" +
                    "\nPress s to slash, c to cure, or z to zap");
                while(playHealth > 0 && enemHealth > 0)
                {
                    Console.Write($"Your turn. Your health is currently {playHealth}/100. What will you do? ");
                    act = Console.ReadKey().KeyChar;
                    int enemRoll = random.Next(1, 4);
                    switch (act)
                    {
                        case 's':
                            Console.WriteLine($"You take your shortsword and expertly slash at the brigand. You deal {slashDam} damage! The enemy has {enemHealth}/100");
                            enemHealth = enemHealth - slashDam;
                            if(enemHealth <= 0)
                            {
                                Console.WriteLine("YOU WIN, YOUR ENEMY IS VANQUISHED!");
                            }
                            break;

                        case 'c':
                            Console.WriteLine($"You take a small blue potion from your satchel and down the whole thing. You recover {cureAmt} health and are now at {playHealth}/100!");
                            playHealth = playHealth + cureAmt;
                            break;

                        case 'z':
                            Console.WriteLine($"You press your thumb and index fingers together and make a deafening snap. You deal {zapDam} damage!");
                            enemHealth = enemHealth - zapDam;
                            break;
                    }
                 
                    Console.Write("The enemy's turn now");
                    switch (enemRoll)
                    {
                        case 0:
                            Console.WriteLine($"Your foe steps forward and slashes wildly! They deal {slashDam} damage to you, you now have {playHealth}/100!");
                            playHealth -= slashDam;
                            break;
                        case 1:
                            Console.WriteLine($"Your foe pulls out an oddly shaped bottle and smashes it against their forehead. They heal for {cureAmt} health!");
                            enemHealth += cureAmt;
                            break;
                        case 2:
                            Console.WriteLine($"Your enemie claps his hands together loud enough to create a thunderous shockwave! You take {zapDam} damage!");
                            playHealth -= zapDam;
                            break;
                    }
                    
                }
                if(playHealth <= 0)
                {
                    Console.WriteLine("You have perished.");
                }
                else if(enemHealth <= 0)
                {
                    Console.WriteLine("You are victorious!");
                }
                Console.Write("Would you like to go again? (y/n): ");
            choice = Console.ReadLine().ToLower();
            }
            while (true);
        }
    }
}
