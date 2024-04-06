namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// Context
    /// </summary>
    internal class Canvas
    {
        private ITool _tool { get; set; }
        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        public void MouseDown()
        {
            _tool.MouseDown();
        }
        public void MouseUp()
        {
            _tool.MouseUp();
        }
    }
}

