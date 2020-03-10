using System;
namespace diggers_and_fliers
{
    public class Earthwoorm : IDig
    {

        public int NumberOfLegs { get; set; }
        public int Length { get; set; }
        public void Dig ()
        {
            Console.WriteLine ("The worm digs a hole.");
        }

    }
}