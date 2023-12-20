namespace DesignPatterns.Creational.AbstractFactory.Plant
{
    // Concrete Product A1
    public class Potato : IPlant
    {
        public string Grow()
        {
            return "Growing a potato.";
        }
    }
}
