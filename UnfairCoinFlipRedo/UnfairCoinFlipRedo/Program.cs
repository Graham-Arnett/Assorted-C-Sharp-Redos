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
                    timesFlip++;
                    Console.WriteLine($"\nGood job, you got heads and won the game! You've flipped the coin {timesFlip} times\n" + responses[0]);
                    heads = true;
                }
                else if (coinChance <= 4 && coinChance > 1 && timesFlip <=4)
                {
                    timesFlip++;
                    Console.WriteLine($"\nYou lost, you got tails\n " + responses[timesFlip]);
                }
                else if(timesFlip >= 4)
                {
                    timesFlip++;
                    Console.WriteLine("\nListen, it was funny after the first couple times but I don't care anymore just cross the bridge and leave.");
                }
                //timesFlip++;
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

                Console.Write("\n\nWould you like to go flip again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
