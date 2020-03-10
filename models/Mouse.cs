using System;
namespace diggers_and_fliers
{
    public class Mouse : IWalk
    {
        public int MaximumSpeed { get; set; }
        public int NumberOfLegs { get; set; }
        public void Walk ()
        {
            Console.WriteLine ("The mouse scurries around.");
        }

    }
}