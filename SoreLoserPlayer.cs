using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
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
                    Console.WriteLine($"{other.Name} Wins!");
                    Console.WriteLine("\"NOOO! THIS IS RIGGED!\"");
                    throw new Exception("sore loser");
                    // throw new InvalidOperationException("**an error**");
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