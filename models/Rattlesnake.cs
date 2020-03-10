using System;
namespace diggers_and_fliers
{
    public class Rattlesnake : IWalk
    {
        public int MaximumSpeed { get; set; }
        public int NumberOfLegs { get; set; }
        public void Walk ()
        {
            Console.WriteLine ("The rattlesnake slithers around the desert.");
        }

    }
}