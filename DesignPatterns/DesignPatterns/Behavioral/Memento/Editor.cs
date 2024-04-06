namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// Originator
    /// </summary>
    public class Editor
    {
        public string Content { get; set; }
        private History _history { get; set; }

        public Editor()
        {
            _history = new History();
        }

        public void CreateState(string content)
        {
            _history.States.Push(new EditorState() { Content = content });
        }
        public string Restore()
        {
            return _history.States.Pop().Content;
        }
    }
}
