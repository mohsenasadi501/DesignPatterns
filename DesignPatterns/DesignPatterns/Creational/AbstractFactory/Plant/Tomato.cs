namespace DesignPatterns.Creational.AbstractFactory.Plant
{
    // Concrete Product A2
    public class Tomato : IPlant
    {
        public string Grow()
        {
            return "Growing a tomato.";
        }
    }
}
