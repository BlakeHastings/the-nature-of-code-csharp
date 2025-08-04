public class Walker
{
    public int X { get; set; }
    public int Y { get; set; }

    public Walker(int width, int height)
    {
        this.X = width / 2;
        this.Y = height / 2;
    }
}