namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Concrete prototype
    /// </summary>
    internal class Circle : IComponent, ICloneable
    {
        public int Radius { get; set; }

        public object Clone()
        {
            return this.Clone();
        }

        public IComponent CloneObject()
        {
            Circle newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a Circle");
        }
    }
}
