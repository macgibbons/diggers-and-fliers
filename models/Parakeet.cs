using System;
namespace diggers_and_fliers
{
    public class Parakeet : IFly
    {

        public int WingSpan { get; set; }
        public bool IsPredator { get; set; }
        public void Fly ()
        {
            Console.WriteLine ("The Parakeet flys high.");
        }

    }
}