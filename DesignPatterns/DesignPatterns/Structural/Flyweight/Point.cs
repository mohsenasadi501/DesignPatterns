namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight
    /// </summary>
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointIcon Icon { get; set; }
        public void Draw()
        {
            Console.WriteLine($"{Icon.Type} at  ({X},{Y})");
        }
    }
}
