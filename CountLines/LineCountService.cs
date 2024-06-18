namespace CountLines
{
    internal class LineCountService
    {
        private string _filename;

        public LineCountService(string filename)
        {
            _filename = filename;
        }

        public LineStats GetCounts(string searchText)
        {
            using var reader = new StreamReader(_filename);
            var matchingLineCount = 0;
            var totalLineCount = 0;
            var line = reader.ReadLine();
            while (line != null)
            {
                if (line.Contains(searchText))
                {
                    matchingLineCount++;
                }

                totalLineCount++;
                line = reader.ReadLine();
            }
            return new LineStats(matchingLineCount, totalLineCount, searchText);
        }

    }
}
