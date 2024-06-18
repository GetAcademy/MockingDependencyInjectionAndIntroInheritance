namespace CountLines.Source
{
    internal class KeyboardLineSource : ILineSource
    {
        public string GetLine()
        {
            var line = Console.ReadLine();
            if (line == "stopp") return null;
            return line;
        }
    }
}
