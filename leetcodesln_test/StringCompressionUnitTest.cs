using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class StringCompressionUnitTest
    {
        public StringCompression StringCompression { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            StringCompression = new StringCompression();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new char[] {'a','a', 'b','b','c','c','c'};
            var expected = 6;
            var actual = StringCompression.Compress(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new char[] {'a','a', 'a','b','b','a','a'};
            var expected = 6;
            var actual = StringCompression.Compress(input);
            Assert.AreEqual(expected, actual);
        }
    }
}