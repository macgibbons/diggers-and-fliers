using System;
namespace diggers_and_fliers
{
    public class Ant : IDig
    {
        public int NumberOfLegs { get; set; }
        public int Length { get; set; }
        public void Dig ()
        {
            Console.WriteLine ("The ant digs and digs.");
        }
    }
}