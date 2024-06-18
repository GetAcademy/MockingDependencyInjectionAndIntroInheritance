using CountLines;
using CountLines.Source;
using Moq;

namespace CountLLines.Test
{
    public class LindeCountServiceTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            var source = new StringArrayLineSource("Hei", "på", "deg");
            var lineCountService = new LineCountService(source);

            // act
            var searchText = "e";
            var stats = lineCountService.GetCounts(searchText);

            // assert
            Assert.AreEqual(3, stats.TotalLineCount);
            Assert.AreEqual(2, stats.MatchingLineCount);
            Assert.AreEqual(searchText, stats.SearchText);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var source = new StringArrayLineSource("Hei", "terje", "deg");
            var lineCountService = new LineCountService(source);

            // act
            var searchText = "TeRJe";
            var stats = lineCountService.GetCounts(searchText);

            // assert
            Assert.AreEqual(3, stats.TotalLineCount);
            Assert.AreEqual(1, stats.MatchingLineCount);
            Assert.AreEqual(searchText, stats.SearchText);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var mockService = new Mock<ILineSource>();
            mockService.SetupSequence(lineService => lineService.GetLine())
                .Returns("Hei")
                .Returns("på")
                .Returns("deg");
            var lineCountService = new LineCountService(mockService.Object);

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