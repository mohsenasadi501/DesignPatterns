namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        public Stack<EditorState> States { get; set; } = new Stack<EditorState>();
    }
}
