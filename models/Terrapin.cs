using System;
namespace diggers_and_fliers
{
    public class Terrapin : ISwim
    {

        public string FreshOrSaltWater { get; set; }
        public int MaximumDepth { get; set; }
        public void Swim ()
        {
            Console.WriteLine ("The terrapin swims across the pond.");
        }

    }
}