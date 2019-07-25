using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MoviesOnFlightUnitTest
    {
        public MoviesOnFlight MoviesOnFlight { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MoviesOnFlight = new MoviesOnFlight();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var movies_duration = new[] { 90, 85, 75, 60, 120, 150, 125 };
            var d = 250;

            var actual = MoviesOnFlight.LongestMovies(movies_duration, d);
            var expected = new[] { 90, 125 };
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(actual, expected));
        }

    }
}
