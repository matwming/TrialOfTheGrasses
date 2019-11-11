using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class NumberOfSegmentsInAStringUnitTest
    {
        public NumberOfSegmentsInAString NumberOfSegmentsInAString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            NumberOfSegmentsInAString = new NumberOfSegmentsInAString();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "Hello, my name is Join";
            var expected = 5;
            var actual = NumberOfSegmentsInAString.CountSegments(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
