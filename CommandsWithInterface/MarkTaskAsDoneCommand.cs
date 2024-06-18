namespace CommandsWithInterface
{
    internal class MarkTaskAsDoneCommand : Command
    {
        public MarkTaskAsDoneCommand(TodoApp todoApp)
            : base(todoApp, 'x', "markere oppgave som gjort")
        {
        }

        public override void Run()
        {
            Console.WriteLine("Skriv inn rad nr. til oppgaven som er gjort: ");
            var taskNo = Convert.ToInt32(Console.ReadLine());
            _todoApp.MarkDone(taskNo);
        }
    }
}
