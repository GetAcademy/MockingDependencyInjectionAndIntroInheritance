namespace CommandsWithInterface
{
    internal abstract class Command 
    {
        public char Char { get;  }
        private string _text;
        protected TodoApp _todoApp;

        protected Command(TodoApp todoApp, char aChar, string text)
        {
            Char = aChar;
            _text = text;
            _todoApp = todoApp;
        }

        public abstract void Run();

        public void ShowMenuItem()
        {
            Console.WriteLine(Char + ": " + _text);
        }
    }
}
