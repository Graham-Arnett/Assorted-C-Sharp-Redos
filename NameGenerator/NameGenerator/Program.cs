namespace NameGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my name generator app");

            char redo;
            string[] firstNames = {"Addison", "Bailey", "Blake", "Cameron", "Charlie", "Atlas", "Sam", "Robin", "Alex", "Adrian", };
            string[] lastNames = {"Smith", "Greene", "Johnson", "Johnsen", "Brown", "White", "Bauer", "Miller", "Skinner", "Fletcher", "Gilbert"};
            string[] jobs = {"lawyer", "officer", "builder", "carpenter", "engineer", "mechanic", "cab driver", "cashier", "nurse", "painter", "logger", "coach", "teacher"};
            Random random = new Random();
            do
            {
                int randFirst = random.Next(firstNames.Length);
                int randLast = random.Next(lastNames.Length);
                int randJob = random.Next(jobs.Length);
                Console.WriteLine($"\nYour name is {firstNames[randFirst]} {lastNames[randLast]} and you work as a {jobs[randJob]}.");
                Console.Write("\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
