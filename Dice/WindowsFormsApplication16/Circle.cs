namespace WindowsFormsApplication16
{
    public class Circle
    {
        public int x { get; protected set; }
        public int y { get; protected set; }
        public int radius { get; protected set; }

        public Circle (int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
    }
}
