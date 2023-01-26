using System;

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string number;
            int rollCount = 1;
            int dice1;
            int dice2;

            int[] rolls = new int[13];
            Random r = new Random(); //for random number generator

            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.WriteLine("How many times would you like to roll the dice?");
            number = Console.ReadLine();
            rollCount = Convert.ToInt32(number); //converts input to integer

            //Simulate number of rolls 
            for (int i = 1; i <= rollCount; i++)
            {
                dice1 = r.Next(1,7); //for random number generator
                dice2 = r.Next(1,7);

                rolls[dice1 + dice2]++;
            }

            //Show number stars for percentage of rolls
            for (int sum = 2; sum < rolls.Length; ++sum)
            {
                double starPercent = rolls[sum] / (rollCount * 0.01);
                int numStars = Convert.ToInt32(starPercent);

                char star = '*';
                string results = new string(star, numStars);
                Console.WriteLine($"{sum}: {results}");
            }

            Console.ReadLine();
            Console.WriteLine("Thanks for playing!");
        }
    }
}