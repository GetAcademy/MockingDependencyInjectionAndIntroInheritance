using CommandsWithInterface;

var todoApp = new TodoApp();
var commands = new ICommand[]
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
    //if (cmdNo == "1")
    //{
    //    cmd1.Run();
    //}
    //else if (cmdNo == "2")
    //{
    //    cmd2.Run();
    //}

    //antipattern - mye scoping
    //foreach (var elA in list1)
    //{
    //    if ()
    //    {
    //        foreach (var elB in list2)
    //        {
    //            if ()
    //            {
    //                fy
    //            }
    //        }
    //    }
    //}
}

ICommand? FindCommand(ICommand[] commands1, string? s)
{
    foreach (var command in commands1)
    {
        if (command.Char == s[0])
        {
            return command;
        }
    }
    return null;
}