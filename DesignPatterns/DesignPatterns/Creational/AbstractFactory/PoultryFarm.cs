using DesignPatterns.Creational.AbstractFactory.Animal;
using DesignPatterns.Creational.AbstractFactory.Plant;
namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Factory 2
    public class PoultryFarm : IFarmFactory
    {
        public IPlant CreatePlant()
        {
            return new Tomato();
        }

        public IAnimal CreateAnimal()
        {
            return new Chicken();
        }
    }
}
