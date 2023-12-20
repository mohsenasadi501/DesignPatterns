namespace DesignPatterns.Creational.AbstractFactory.Animal
{
    // Concrete Product B1
    public class Cow : IAnimal
    {
        public string Feed()
        {
            return "Feeding a cow.";
        }
    }
}
