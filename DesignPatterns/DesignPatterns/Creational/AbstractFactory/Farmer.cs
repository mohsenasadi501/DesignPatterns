namespace DesignPatterns.Creational.AbstractFactory
{
    public class Farmer
    {
        public Farmer(IFarmFactory factory)
        {
            var plant = factory.CreatePlant();
            Console.WriteLine(plant.Grow());

            var animal = factory.CreateAnimal();
            Console.WriteLine(animal.Feed());
        }
    }
}
