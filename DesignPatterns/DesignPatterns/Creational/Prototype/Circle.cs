namespace DesignPatterns.Creational.Prototype
{
    internal class Circle : Component
    {
        public int Radius { get; set; }

        public Component Clone()
        {
            //Circle newCircle = new Circle();
            //newCircle.Radius = Radius;
            //return newCircle;

            return this.Clone();
        }

        public void Render()
        {
            Console.WriteLine("Rendering a Circle");
        }
    }
}
