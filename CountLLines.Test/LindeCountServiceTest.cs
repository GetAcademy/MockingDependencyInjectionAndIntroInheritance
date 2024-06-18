using CountLines;
using CountLines.Source;

namespace CountLLines.Test
{
    public class LindeCountServiceTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            var source = new MockLineSource();
            var lineCountService = new LineCountService(source);

            // act
            var searchText = "e";
            var stats = lineCountService.GetCounts(searchText);

            // assert
            Assert.AreEqual(3, stats.TotalLineCount);
            Assert.AreEqual(2, stats.MatchingLineCount);
            Assert.AreEqual(searchText, stats.SearchText);
        }
    }
}