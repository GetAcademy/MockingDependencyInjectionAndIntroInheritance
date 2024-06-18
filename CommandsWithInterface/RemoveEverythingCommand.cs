namespace CommandsWithInterface
{
    internal class RemoveEverythingCommand : ICommand
    {
        private TodoApp _todoApp;
        public char Char { get; } = '-';
        public string _text = "Fjerne alt";

        public RemoveEverythingCommand(TodoApp todoApp)
        {
            _todoApp = todoApp;
        }

        public void Run()
        {
            _todoApp.RemoveAll();
        }

        public void ShowMenuItem()
        {
            Console.WriteLine(Char + ": " + _text);
        }
    }
}
