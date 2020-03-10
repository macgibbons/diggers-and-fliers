namespace diggers_and_fliers
{
    public interface IWalk
    {
        int MaximumSpeed { get; set; }
        int NumberOfLegs { get; set; }
        void Walk ();
    }
}