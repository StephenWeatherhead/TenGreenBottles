namespace TenGreenBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get number of green bottles
            int numberOfGreenBottles = 0;
            while(numberOfGreenBottles <= 0)
            {
                Console.WriteLine("Please enter the number of green bottles:");
                string greenBottlesString = Console.ReadLine();
                if (int.TryParse(greenBottlesString, out numberOfGreenBottles))
                {
                    if (numberOfGreenBottles <= 0)
                    {
                        Console.WriteLine("Please enter a positive number...");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Could not understand input. Please try again...");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            // print song
            Console.WriteLine($"{numberOfGreenBottles} Green Bottles");
            Console.WriteLine("----");
            for(int i = numberOfGreenBottles; i > 0; i--)
            {
                Console.WriteLine($"{i} green bottles hanging on the wall,");
                Console.WriteLine($"{i} green bottles hanging on the wall,");
                Console.WriteLine($"And if one green bottle should accidentally fall");
                int nextBottle = i - 1;
                if(nextBottle == 0)
                {
                    Console.WriteLine("There'll be no green bottles hanging on the wall.");
                }
                else
                {
                    Console.WriteLine($"There'll be {i} green bottles hanging on the wall.");
                }
                Console.WriteLine();
            }
            // wait for exit
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
