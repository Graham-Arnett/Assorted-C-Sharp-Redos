namespace UnfairCoinFlipRedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unfair coinflip app" +
               "\nYou were walking home from work and decided to take the scenic route. " +
               "\nWhen you were at the foot of the last bridge to cross, a hideous troll approached and demanded you played a game with it." +
               "\nA coinflip, heads means you pass, but tails means you have to listen to the insufferable creature.");

            char redo;
            string[] responses = {"Huh? How did you win that fast?", "You're terrible at this!", "You smell of fish and insecurity!", "Your friends keep you around to look better by proxy!"
            ,"Your parents change the conversation when your name comes up!"};
            Random random = new Random();
            bool heads = false;
            
            do
            {
                int timesFlip = 0;
                int coinChance = random.Next(1, 5);

                if(coinChance == 1)
                {
                    Console.WriteLine(responses[0]);
                }
                timesFlip++;
                //while (heads == false)
                //{
                //    Console.WriteLine("Lets flip the coin!");
                //    if (coinChance == 1)
                //    {
                //        Console.WriteLine(responses[0]);
                //        heads = true;
                //    }
                //    else
                //    {
                //        Console.WriteLine(timesFlip);
                //    }
                //    timesFlip++;
                //}

                Console.Write("Would you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
