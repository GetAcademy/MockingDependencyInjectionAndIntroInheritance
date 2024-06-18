namespace CommandsWithInterface
{
    internal interface ICommand
    {
        char Char { get; }

        void Run();
        void ShowMenuItem();
    }
}
