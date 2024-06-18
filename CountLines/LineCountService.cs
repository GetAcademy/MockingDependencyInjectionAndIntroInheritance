using CountLines.Source;

namespace CountLines
{
    public class LineCountService
    {
        private ILineSource _lineSource;

        public LineCountService(ILineSource lineSource)
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
                if (line.Contains(searchText, StringComparison.CurrentCultureIgnoreCase))
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
