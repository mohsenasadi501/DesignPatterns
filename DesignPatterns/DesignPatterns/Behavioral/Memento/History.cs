namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// Care Taker Class
    /// </summary>
    public class History
    {
        public Stack<EditorState> States { get; set; } = new Stack<EditorState>();
    }
}
