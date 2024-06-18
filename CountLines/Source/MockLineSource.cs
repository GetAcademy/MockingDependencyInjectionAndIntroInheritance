namespace CountLines.Source
{
    internal class MockLineSource : ILineSource
    {
        private int _index;

        public string GetLine()
        {
            _index++;

            if (_index == 1) return "Hei";
            if (_index == 2) return "på";
            if (_index == 3) return "deg";

            return null;
        }
    }
}
