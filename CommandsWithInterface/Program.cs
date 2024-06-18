using CommandsWithInterface;

var todoApp = new TodoApp();
var commands = new Command[]
{
    new AddTaskCommand(todoApp),
    new MarkTaskAsDoneCommand(todoApp),
    new RemoveEverythingCommand(todoApp),
};
while (true)
{
    Console.Clear();
    todoApp.Show();
    Console.WriteLine("Hva vil du gjøre? ");
    foreach (var command in commands)
    {
        command.ShowMenuItem();
    }
    var cmd = Console.ReadLine();
    var theCommand = FindCommand(commands, cmd);
    theCommand?.Run();
}

Command? FindCommand(Command[] cmds, string? selectedComand)
{
    foreach (var command in cmds)
    {
        if (command.Char == selectedComand[0])
        {
            return command;
        }
    }
    return null;
}