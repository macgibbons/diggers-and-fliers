namespace diggers_and_fliers
{
    public interface ISwim
    {
        string FreshOrSaltWater { get; set; }
        int MaximumDepth { get; set; }
        void Swim ();
    }
}