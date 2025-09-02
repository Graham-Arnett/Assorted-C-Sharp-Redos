namespace TemperatureConvertApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion App");
            char redo;
            do
            {
                Console.Write("Enter a temperature in fahrenheit: ");
                double temp = double.Parse(Console.ReadLine());
                double celsius = (temp - 32) * 5/9;
                Console.WriteLine($"\nThat is {celsius} degrees!");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
