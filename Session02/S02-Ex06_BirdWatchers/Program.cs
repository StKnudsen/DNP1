using System;

namespace S02_Ex06_BirdWatchers
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            BirdWatcher bw1 = new NormalBirdWatcher("Bent", bird);
            BirdWatcher bw2 = new BlindBirdWatcher("Heino", bird);
            BirdWatcher bw3 = new DeafBirdWatcher("Kurt", bird);
            
            bird.RunBird();
        }
    }
}