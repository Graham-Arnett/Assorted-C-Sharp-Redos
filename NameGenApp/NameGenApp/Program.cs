namespace NameGenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name Generator App");
            char redo;
            Random random = new Random();
            string[] first = {"Mary","John","Jean","Jose","Bob","Hugh","Kevin","Kyle","Linus","Peter","Simon","Myriam","Eleanor","Evan" +
                    "Brian","Billy","Jenny"};
            string[] last = {"Johnson","Greene","Brown","Swanson","Smith","Whittle","Skinner","Chalmers"};
            do
            {
                int fChoice = random.Next(first.Length);
                int lChoice = random.Next(last.Length);
                Console.Write($"\n\nYour name is: {first[fChoice]} {last[lChoice]}" +
                    $"\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
