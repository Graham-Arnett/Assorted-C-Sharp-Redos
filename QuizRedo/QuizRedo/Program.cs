namespace QuizRedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Quiz App");

            string choice;
            string[] questions = {"What color is the sky? A:Red B:Blue C:Yellow ",
            "How many states are there in the United States? A:50 B:51 C:52 ",
            "How many fingers does the human body have? A:11 B:9 C:10 ",
            "Wordle is a word game owned by: A:New York Post B:Washington Post C:New York Times ",
            "Peppers are botanically: A:Fruits B:Vegetables C:Grains ",
            "My favorite color is: A:Yellow B:Green C:Blue ",
            "Pizza was invented in: A:New York B:Chicaco C:Italy ",
            "How long was this quiz? A:10 questions long B:7 questions long C:8 questions long "};
            char[] correctAnswers = {'B','A','C', 'C', 'A', 'A', 'C', 'C' };
            char[] answers = new char[8];
           
            do
            {
                int score = 0;
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.Write(questions[i]);
                    answers[i] = Console.ReadKey().KeyChar;
                    if (answers[i] == correctAnswers[i])
                    {
                        Console.WriteLine("\nCORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("\nINCORRECT!");
                    }
                }
                Console.WriteLine($"\nYour score was {score}/8.");
                switch (score)
                {
                    case 0:
                        Console.WriteLine("Ouch, try again.");
                        break;
                    case 1:
                        Console.WriteLine("It's better than nothing...");
                        break;
                    case 2:
                        Console.WriteLine("Still pretty bad though...");
                        break;
                    case 3:
                        Console.WriteLine("Nearly sort of okay!");
                        break;
                    case 4:
                        Console.WriteLine("Almost a passing grade!");
                        break;
                    case 5:
                        Console.WriteLine("You barely passed!");
                        break;
                    case 6:
                        Console.WriteLine("Hey, not bad!");
                        break;
                    case 7:
                        Console.WriteLine("You're good at this!");
                        break;
                    case 8:
                        Console.WriteLine("You are the master and everyone should bow before you.");
                        break;
                }
                Console.WriteLine("Would you like to play again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
