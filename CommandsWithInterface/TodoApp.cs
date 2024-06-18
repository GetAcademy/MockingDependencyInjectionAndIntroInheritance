namespace CommandsWithInterface
{
    internal class TodoApp
    {
        private readonly List<Task> _tasks = CreateTasks();

        public void Show()
        {
            Console.WriteLine("Oppgave:  Frist:    Fullført:");
            Console.WriteLine();
            for (var index = 0; index < _tasks.Count; index++)
            {
                var task = _tasks[index];
                var taskNo = index + 1;
                Console.Write(taskNo + ": ");
                if (task.IsDone) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(task.GetDescription());
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void MarkDone(int taskNo)
        {
            var index = taskNo - 1;
            var task = _tasks[index];
            task.MarkDone();
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
        private static List<Task> CreateTasks()
        {
            var taskA = new Task("Vaske", new DateTime(2023, 11, 22));
            var taskB = new Task("Rydde", new DateTime(2023, 11, 23));
            var taskC = new Task("Støvsuge", new DateTime(2023, 11, 24));
            return new List<Task> { taskA, taskB, taskC };
        }

        public void RemoveAll()
        {
            _tasks.Clear();
        }
    }
}
