using System;
namespace diggers_and_fliers
{
    public class Gerbil : IWalk
    {
        public int MaximumSpeed { get; set; }
        public int NumberOfLegs { get; set; }
        public void Walk ()
        {
            Console.WriteLine ("The gerbil walks around it's cage.");
        }

    }
}