namespace DesignPatterns.State
{
    internal class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
