using System;

public class DiceSimulator
{
    private Random random;

    public DiceSimulator()
    {
        random = new Random();
    }

    public void SimulateDiceRolls()
    {
        int numRolls = HowManyRolls();

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" + represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        // Uses an array to store the counts for dice roll number
        int[] diceRollCounts = new int[11];

        for (int i = 0; i < numRolls; i++)
        {
            int randomNumber = random.Next(2, 13);
            // Adjusts the index to start at 0 (since we aren't doing 0 or 1)
            diceRollCounts[randomNumber - 2]++; 
        }

        for (int number = 2; number <= 12; number++)
        {
            int count = diceRollCounts[number - 2];

            Console.WriteLine($"{number}: {new string('*', count / (numRolls / 100))}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    private int HowManyRolls()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numRolls = int.Parse(Console.ReadLine());

        return numRolls;
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        DiceSimulator diceSimulator = new DiceSimulator();
        diceSimulator.SimulateDiceRolls();
    }
}
