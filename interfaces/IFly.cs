namespace diggers_and_fliers
{
    public interface IFly
    {
        int WingSpan { get; set; }
        bool IsPredator { get; set; }
        void Fly ();
    }
}