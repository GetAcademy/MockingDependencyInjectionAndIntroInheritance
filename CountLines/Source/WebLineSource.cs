using System.Net;
using System.Reflection.PortableExecutable;

namespace CountLines.Source
{
    internal class WebLineSource : ILineSource
    {
        private readonly StreamReader _reader;

        public WebLineSource(string url)
        {
            var webClient = new WebClient();
            var fileStream = webClient.OpenRead(url);
            _reader = new StreamReader(fileStream);
        }

        public string GetLine()
        {
            return _reader.ReadLine();
        }
    }
}
