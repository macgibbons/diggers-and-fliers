using System;
namespace diggers_and_fliers
{
    public class BettaFish : ISwim
    {

        public string FreshOrSaltWater { get; set; }
        public int MaximumDepth { get; set; }
        public void Swim ()
        {
            Console.WriteLine ("The betta fish swims around it's cage.");
        }

    }
}