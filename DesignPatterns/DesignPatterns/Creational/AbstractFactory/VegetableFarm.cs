using DesignPatterns.Creational.AbstractFactory.Animal;
using DesignPatterns.Creational.AbstractFactory.Plant;
namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Factory 1
    public class VegetableFarm : IFarmFactory
    {
        public IPlant CreatePlant()
        {
            return new Potato();
        }

        public IAnimal CreateAnimal()
        {
            return new Cow();
        }
    }
}
