// Chris Fowler
// Mission 2: Dice Rolling Simulator (Rolls two dice x number of times and displays results)

using System;
using Mission_2_Assignment;

public class Program
{
    // Asks the user for a number of dice rolls to do and returns that number
    internal int HowManyRolls()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numRolls = int.Parse(Console.ReadLine());

        return numRolls;
    }
    private static void Main(string[] args)
    {
        // Creates an instance of our program class so we can run the HowManyRolls method
        Program program = new Program();
        int numRolls = program.HowManyRolls();

        // Creates an instance of our DiceSimulator class so we can run the SimulateDiceRolls method
        DiceSimulator diceSimulator = new DiceSimulator();
        int[] diceRollCounts = diceSimulator.SimulateDiceRolls(numRolls);

        // Loops through our list of dice rolls and counts and lists a * for each percent that number was rolled out of 100
        for (int number = 2; number <= 12; number++)
        {
            int count = diceRollCounts[number - 2];

            Console.WriteLine($"{number}: {new string('*', count / (numRolls / 100))}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}