using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Assignment
{
    public class DiceSimulator
    {
        private Random random;

        public DiceSimulator()
        {
            random = new Random();
        }

        public int[] SimulateDiceRolls(int numRolls)
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" + represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.\n");

            // Uses an array to store the counts for dice roll number (each index refers to a number you roll between 2 and 12, adds 1 to that index when number is roleld)
            int[] diceRollCounts = new int[11];

            for (int i = 0; i < numRolls; i++)
            {
                // Rolls two dice and adds the result together
                int randomNumber = random.Next(1, 7) + random.Next(1, 7);

                // Adjusts the index to start at 0 (since we aren't doing rolls of 0 or 1)
                diceRollCounts[randomNumber - 2]++;
            }

            return diceRollCounts;
        }
    }

}
