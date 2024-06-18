namespace CommandsWithInterface
{
    internal class AddTaskCommand : ICommand
    {
        private TodoApp _todoApp;
        public char Char { get; } = '+';
        public string _text = "legge til ny oppgave";


        public AddTaskCommand(TodoApp todoApp)
        {
            _todoApp = todoApp;
        }

        public void Run()
        {
            Console.Write("Hva er oppgaven? ");
            var taskText = Console.ReadLine();
            var task = new Task(taskText);
            _todoApp.AddTask(task);
        }
        public void ShowMenuItem()
        {
            Console.WriteLine(Char + ": " + _text);
        }
    }
}
