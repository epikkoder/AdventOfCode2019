using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fuelSum = 0;

            string[] lines = File.ReadAllLines(@"../../../input.txt");

            foreach (string line in lines)
            {
                fuelSum += GetTotalRequiredFuel(Convert.ToInt32(line));
            }

            Console.WriteLine(fuelSum);
        }

        public static int GetRequiredFuel(int module)
        {
            return (module / 3) - 2;
        }

        // For part 2. Needs to account for the fuel also needing fuel.
        public static int GetTotalRequiredFuel(int module)
        {
            int total = 0;
            int fuel = GetRequiredFuel(module);

            while (fuel > 0)
            {
                total += fuel;
                fuel = GetRequiredFuel(fuel);
            }

            return total;
        }
    }
}
