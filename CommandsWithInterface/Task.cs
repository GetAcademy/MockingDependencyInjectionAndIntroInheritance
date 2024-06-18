namespace CommandsWithInterface
{
    internal class Task
    {
        public string Name { get;  }
        public DateTime DueDate { get; private set; }
        public bool IsDone { get; private set; }

        public Task(string name) : this(name, DateTime.Now.AddDays(7))
        {
        }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }

        /*
           public Task(string name, DateTime? dueDate = null)
           {
             Name = name;
             DueDate = dueDate ?? DateTime.Now.AddDays(7);
           }
         */

        public void MarkDone()
        {
            IsDone = true;
        }

        public string GetDescription()
        {
            return Name.PadRight(10) + DueDate.ToString("dd/MM/yy") + (IsDone ? $"    Ja" : "   Nei");
        }
    }
}
