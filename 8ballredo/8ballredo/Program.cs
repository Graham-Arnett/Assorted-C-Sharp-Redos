namespace _8ballredo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Seek your fortune with the magic 8ball!");
            char choice;//the choice I use is always one character long so theres not much reason for it to be a string instead of a char
            string[] affirm = { "YES!", "YI say absolutely", "I see no reason to say no.", "Of course"};
            string[] middle = {"Yes... maybe?", "Perhaps...", "Hard to say.", "Who knows?", "Try again later"};
            string[] no = {"NO!", "Negative.", "Not in a million years.", "Do not count on it.", "This question disgusts me, absolutely not."};
            do
            {
               int ballChoice = random.Next(1,4);
                int affirmPick = random.Next(affirm.Length);
                int middlePick = random.Next(middle.Length);
                int noPick = random.Next(no.Length);
                Console.Write("\nPlease ask a question: ");
                string question = Console.ReadLine();
                switch (ballChoice)
                {
                    case 1:
                        Console.WriteLine(affirm[affirmPick]);
                        break;
                    case 2:
                        Console.WriteLine(middle[middlePick]);
                        break;
                    case 3:
                        Console.WriteLine(no[noPick]);
                        break;
                }

                Console.WriteLine("Would you like to ask the magical 8ball another question? (y/n): ");
            choice = Console.ReadKey().KeyChar;
            } while (choice == 'y');

        }
    }
}
