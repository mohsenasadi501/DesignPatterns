namespace DesignPatterns.Creational.AbstractFactory.Animal
{
    // Concrete Product B2
    public class Chicken : IAnimal
    {
        public string Feed()
        {
            return "Feeding a chicken.";
        }
    }
}
