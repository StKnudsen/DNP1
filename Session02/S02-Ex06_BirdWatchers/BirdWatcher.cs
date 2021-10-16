using System;

namespace S02_Ex06_BirdWatchers
{
    public abstract class BirdWatcher
    {
        public string Name;

        public BirdWatcher(string name, Bird bird)
        {
            Name = name;
            bird.BirdBehaviorChange += ReactToBirdBehavior;
        }

        public virtual void ReactToBirdBehavior(string birdBehavior)
        {
            if (birdBehavior.Equals("Bird flaps wings"))
            {
                Console.WriteLine($"   {Name}: \"Ooh\"");
            }
            else if (birdBehavior.Equals("Bird sings"))
            {
                Console.WriteLine($"   {Name}: \"How nice\"");
            }
            else if (birdBehavior.Equals("Bird does mating dance"))
            {
                Console.WriteLine($"   {Name}: \"Would you look at that\"");
            }
        }
    }
}