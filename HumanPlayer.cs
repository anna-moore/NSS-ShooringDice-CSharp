using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    //Next version if/then logic to prevent int outside of range
    public class HumanPlayer : Player
    {
        // Call roll for "this" object and for the "other" object
        public override void Play(Player other)
        {
            Console.Write("Type in your Name: ");
            string Name = Console.ReadLine();

            Console.Write("Type in a number 1-6: ");
            int reply = Int32.Parse(Console.ReadLine());

            // Call roll for "this" object and for the "other" object
            int myRoll = reply;
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}