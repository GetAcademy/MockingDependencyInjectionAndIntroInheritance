namespace CommandsWithInterface
{
    internal class MarkTaskAsDoneCommand : ICommand
    {
        private TodoApp _todoApp;
        public char Char { get; } = 'x';
        public string _text = "markere oppgave som gjort";

        public MarkTaskAsDoneCommand(TodoApp todoApp)
        {
            _todoApp = todoApp;
        }


        public void Run()
        {
            Console.WriteLine("Skriv inn rad nr. til oppgaven som er gjort: ");
            var taskNo = Convert.ToInt32(Console.ReadLine());
            _todoApp.MarkDone(taskNo);
        }

        public void ShowMenuItem()
        {
            Console.WriteLine(Char + ": " + _text);
        }
    }
}
