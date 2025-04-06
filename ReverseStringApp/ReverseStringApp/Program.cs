namespace ReverseStringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my reverse string app!");
            char redo;

            //string normal;
            //string reverse = string.Empty;

            do
            {
                string normal;
                string reverse = string.Empty;
                Console.Write("\n\nEnter your word: ");
                normal = Console.ReadLine();
                for(int i = normal.Length - 1; i >= 0; i--)
                {
                    reverse += normal[i];
                }
                if(reverse == normal)
                {
                    Console.WriteLine("This is also a palindrome!");
                }
                Console.WriteLine($"Your reversed string is {reverse}");


                Console.Write("Would you like to go again? (y/n): ");
            redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
