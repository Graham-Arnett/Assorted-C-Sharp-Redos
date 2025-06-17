namespace riddlegameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my riddle game app!");

            Random random = new Random();

            string[] questions = {"What has a face and a tail but no body: ", "What has neither flesh, feather, nor bone, but has fingers and thumbs of it's own: "
            ,"What walks on four legs at dawn, and three at twlight: ","It rhymes with duck, you need me most of all: "};
            string[] answers = {"COIN","GLOVE","HUMAN","LUCK"};

            char redo;
            do
            {
                int randRiddle = random.Next(questions.Length);
                string rightAnswer = answers[randRiddle];
                Console.Write($"\n{questions[randRiddle]}");
                string entry = Console.ReadLine().ToUpper();
                if (entry == rightAnswer)
                {
                    Console.WriteLine("That is correct, good job!");
                }
                else
                {
                    Console.WriteLine("That is unfortunately not correct, we will be catapulting you into the sun, sorry.");
                }
                Console.Write("\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Thanks for playing!");
        }
    }
}
