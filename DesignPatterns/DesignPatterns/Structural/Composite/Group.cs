namespace DesignPatterns.Structural.Composite
{
    internal class Group : Component
    {
        private List<Component> components = new List<Component>();

        public void add(Component component)
        {
            components.Add(component);
        }

        public void move()
        {
            foreach (Component component in components)
                component.move();
        }

        public void render()
        {
            foreach (Component component in components)
                component.render();
        }
    }
}
