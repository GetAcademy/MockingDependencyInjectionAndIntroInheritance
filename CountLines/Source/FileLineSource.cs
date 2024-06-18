namespace CountLines.Source
{
    internal class FileLineSource : ILineSource
    {
        private StreamReader _streamReader;

        public FileLineSource(string filename)
        {
            _streamReader = new StreamReader(filename);
        }
        public string GetLine()
        {
            return _streamReader.ReadLine();
        }
    }
}
