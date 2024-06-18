using CountLines.Source;

namespace CountLines
{
    internal class LineCountService2
    {
        private ILineSource _lineSource;

        public LineCountService2(ILineSource lineSource)
        {
            _lineSource = lineSource;
        }

        public LineStats GetCounts(string searchText)
        {
            var matchingLineCount = 0;
            var totalLineCount = 0;
            var line = _lineSource.GetLine();
            while (line != null)
            {
                if (line.Contains(searchText))
                {
                    matchingLineCount++;
                }

                totalLineCount++;
                line = _lineSource.GetLine();
            }
            return new LineStats(matchingLineCount, totalLineCount, searchText);
        }
    }
}
