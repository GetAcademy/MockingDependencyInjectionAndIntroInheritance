using System.Collections;
using CountLines.Source;

namespace CountLLines.Test
{
    internal class StringArrayLineSource : ILineSource
    {
        private IEnumerator _enumerator;


        public StringArrayLineSource(params string[] strings)
        {
            _enumerator = strings.GetEnumerator();
        }
        public string GetLine()
        {
            var moveNext = _enumerator.MoveNext();
            if (!moveNext) return null;
            return (string)_enumerator.Current;
        }
    }
}
