using System;
using System.Threading;

namespace S02_Ex06_BirdWatchers
{
    public class Bird
    {
        public Action<string> BirdBehaviorChange;
        
        private string[] BirdBehavior =
        {
            "Bird flaps wings",
            "Bird sings",
            "Bird does mating dance"
        };

        public void RunBird()
        {
            Random random = new Random();
            
            while (true)
            {
                string newBirdBehavior = BirdBehavior[random.Next(0, BirdBehavior.Length)];

                Console.WriteLine(newBirdBehavior);
                BirdBehaviorChange.Invoke(newBirdBehavior);

                Thread.Sleep(random.Next(800, 1600));
            }
        }
    }
}