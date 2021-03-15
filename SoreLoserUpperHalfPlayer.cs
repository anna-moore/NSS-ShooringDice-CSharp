using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(3, 6) + 1;
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            try
            {
                int myRoll = Roll();
                int otherRoll = other.Roll();

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                //here is the place for expection
                else if (myRoll < otherRoll)
                {
                    throw new InvalidOperationException("**an error**");
                    // Console.WriteLine($"{other.Name} Wins!");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("**error**");
            }
        }


    }
}