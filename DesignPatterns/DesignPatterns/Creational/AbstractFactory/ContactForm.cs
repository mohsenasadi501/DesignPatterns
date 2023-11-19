using DesignPatterns.Creational.AbstractFactory.Ant;
using DesignPatterns.Creational.AbstractFactory.Material;
using static DesignPatterns.Creational.AbstractFactory.Enums;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class ContactForm
    {
        public void Render(Theme theme)
        {
            if (theme == Theme.Ant)
            {
                new AntButton().Render();
                new AntTextBox().Render();
            }
            else if (theme == Theme.Material)
            {
                new MaterialButton().Render();
                new MaterialTextBox().Render();
            }
        }
    }
}
