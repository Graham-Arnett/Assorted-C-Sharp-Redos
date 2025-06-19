namespace QuadraticCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation solver");
            char redo;
            double[] e = new double[3]; //e is short for ENTRIES, this is just less clunky because it comes up a bit
            string[] orders = {"first","second","third"};
            do
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.Write($"\nPlease enter your {orders[i]} number: ");
                    e[i] = double.Parse(Console.ReadLine());
                }

                double denominator = 2 * e[0];
                double squaredNumer = Math.Sqrt(Math.Abs((e[1] * e[1]) - (4 * e[0] * e[2])));
                double posResult = (-e[1] + squaredNumer) / denominator;
                double negResult = (-e[1] - squaredNumer) / denominator;

                Console.WriteLine($"" +
                    $"\tTHE RESULTS\n" +
                    $"===============================" +
                    $"\n{posResult}   ,   {negResult}");

                Console.Write("Would you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
