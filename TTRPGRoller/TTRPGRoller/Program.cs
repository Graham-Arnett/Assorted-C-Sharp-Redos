namespace TTRPGRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my ttrpg roller!");
            
            Random random = new Random();
            char redo;
            string[] stats = {"STRENGTH","DEXTERITY","INTELLIGENCE","WISDOM","CONSTITUTION","CHARISMA"};
            int[] scores = new int[6];
            string[] classes = { "HIGHWAYMAN", "BRIGAND", "WILD ONE", "DUELIST", "PUGILIST", "SURGEON", "GAMBLER", "PERFORMER", "COWARD" };
            string[] background = {"HERMIT","SOLDIER","SCHOLAR","MADMAN","APOTHECARY","ALCHEMIST","FOLK HERO","NAIVE IDEALIST","PRISONER",
            "WASHED UP HERO", "FALLEN PATRICIAN","PARIAH","EXCOMMUNICATED FROM THE CLOTH", "HAUNTED"};
            string[] race = { "ROOTLING", "HUMAN", "DWARF", "ELF", "HALFLING", "ORC", "BUGBEAR", "GOBLIN", "TIEFLING", "KOBOLD" };
            //plans for this
            //I want to have files with the classes, backgrounds, and races, so that when you roll a character you can ask to read the description of them
            //I'm thinking this will require a switch statement where you clarify what you want to read about (c for class, b for background, r for race and n for none)

            do
            {
                Console.WriteLine();
                for(int i = 0; i < 6; i++)
                {
                    int scoreResult = random.Next(1,21);
                    scores[i] = scoreResult;

                    Console.WriteLine($"" + stats[i] + ": " + scores[i]);
                }

                
                Console.Write("\nWould you like to roll a new character? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
