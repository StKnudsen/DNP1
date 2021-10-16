using System;

namespace S02_Ex06_BirdWatchers
{
    public class DeafBirdWatcher : BirdWatcher
    {
        public DeafBirdWatcher(string name, Bird bird) : base(name, bird)
        {
        }
        
        public override void ReactToBirdBehavior(string birdBehavior)
        {
            if (birdBehavior.Equals("Bird flaps wings"))
            {
                Console.WriteLine($"   {Name}: \"How awesome\"");
            }
            else if (birdBehavior.Equals("Bird sings"))
            {
                Console.WriteLine($"   {Name}: \"...\"");
            }
            else if (birdBehavior.Equals("Bird does mating dance"))
            {
                Console.WriteLine($"   {Name}: \"Did you see that\"");
            }
        }
    }
}