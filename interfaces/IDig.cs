namespace diggers_and_fliers
{
    public interface IDig
    {
        int NumberOfLegs { get; set; }
        int Length { get; set; }
        void Dig ();
    }
}