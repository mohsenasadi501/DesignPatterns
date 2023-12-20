using DesignPatterns.Creational.AbstractFactory.Animal;
using DesignPatterns.Creational.AbstractFactory.Plant;
namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract Factory
    public interface IFarmFactory
    {
        IPlant CreatePlant();
        IAnimal CreateAnimal();
    }
}
