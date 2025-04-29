namespace PasswordGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my password generator app!");

            Random random = new Random();
            char redo;

            char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            char[] numbers = {'0','1','2','3','4','5','6','7','8','9'};
            char[] symbols = {'{','[',',','.','/','}',']','!','@','#','$','%','^','^','&','*','(',')','<','>','?','-','_','=',
            '+','"',':'};
            do
            {
                Console.Write("\nHow long would you like the password to be: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write($"Your passcode is: ");
                for(int i = 0; i < length; i++)
                {
                    int type = random.Next(0, 3);
                    int letterChoice = random.Next(letters.Length);
                    int numChoice = random.Next(numbers.Length);
                    int symChoice = random.Next(symbols.Length);
                    if (type == 0)
                    {
                        Console.Write(letters[letterChoice]);
                    }
                    else if(type == 1)
                    {
                        Console.Write(numbers[numChoice]);
                    }
                    else
                    {
                        Console.Write(symbols[symChoice]);
                    }
                }

                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            }while(redo == 'y' || redo == 'Y');
        }
    }
}
