namespace CommandsWithInterface
{
    internal class RemoveEverythingCommand : Command
    {
        
        public RemoveEverythingCommand(TodoApp todoApp)
        :base(todoApp, '-', "Fjerne alt")
        {
        }

        public override void Run()
        {
            _todoApp.RemoveAll();
        }
    }
}
