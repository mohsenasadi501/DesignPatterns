namespace DesignPatterns.Behavioral.Command
{
    internal class Button
    {
        private string label;
        private ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}
