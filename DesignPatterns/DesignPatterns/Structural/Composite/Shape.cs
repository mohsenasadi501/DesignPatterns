namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Leaf
    /// </summary>
    internal class Shape : Component
    {
        public void move()
        {
            Console.WriteLine("Mode Shape");
        }
        public void render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
