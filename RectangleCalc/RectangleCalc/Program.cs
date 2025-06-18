namespace RectangleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Calculator");
            
            char redo;
            char[] acceptChar = {'y','Y','n','N'};
            double[] entries = new double[2];
            string[] prompt = {"first", "second"};
           
            do
            {
                bool validchar = false;
                for(int i = 0; i < 2; i++)
                {
                    Console.Write($"Enter your {prompt[i]} number: ");
                    entries[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{entries[0]}  {entries[1]}");
                //double sum = entries[0] + entries[1];
                //double area = entries[0] * entries[1];
                //double difference = entries[0] - entries[1];
                //double divide = entries[0] / entries[1];
                Console.Write("\n\nWould you like to ADD, MULTIPLY, DIVIDE, or SUBTRACT: ");
                string functChoice = Console.ReadLine().ToUpper();
                switch (functChoice)
                {
                    case "ADD":
                        double sum = entries[0] + entries[1];
                        Console.WriteLine($"Your sum is: {sum}");
                        break;
                    case "SUBTRACT":
                        double difference = entries[0] - entries[1];
                        Console.WriteLine($"Your difference is: {difference}");
                        break;
                    case "MULTIPLY":
                        double area = entries[0] * entries[1];
                        Console.WriteLine($"Your area/product is: {area}");
                        break;
                    case "DIVIDE":
                        double divide = entries[0] / entries[1];
                        Console.WriteLine($"Your division result is: {divide}");
                        break;
                }
                do
                {
                    Console.Write("\n\nWould you like to go again? (y/n): ");
                    redo = Console.ReadKey().KeyChar;
                    if (acceptChar.Contains(redo))
                    {
                        Console.WriteLine("Accepted input, thank you.");
                        validchar = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input.\n\n");
                    }
                } while (!validchar);
            } while(redo == 'y' || redo == 'Y');

        }
    }
}
