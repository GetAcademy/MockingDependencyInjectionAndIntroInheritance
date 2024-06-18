namespace CommandsWithInterface
{
    internal class AddTaskCommand : Command
    {
        public AddTaskCommand(TodoApp todoApp)
        : base(todoApp, '+', "legge til ny oppgave")
        {
        }

        public override void Run()
        {
            Console.Write("Hva er oppgaven? ");
            var taskText = Console.ReadLine();
            var task = new Task(taskText);
            _todoApp.AddTask(task);
        }
    }
}
