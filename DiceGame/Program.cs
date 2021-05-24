using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Roll Total: {roll1} + {roll2} + {roll3} = {total}");

            if(total < 14)
            {
                Console.WriteLine("LOSER");
            }
            if(total >= 14)
            {
                Console.WriteLine("WINNER");
            }
        }
    }
}
