using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ReverseStringUnitTest
    {
        public ReverseString reverseString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            reverseString = new ReverseString();
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseStringTestMethod1()
        {
            var input = "hello";
            var expected = "olleh";
            var actual = reverseString.ReverseStringSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseStringTestMethod2()
        {
            var input = "hello1";
            var expected = "1olleh";
            var actual = reverseString.ReverseStringSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseStringTestMethod3()
        {
            var input = "1";
            var expected = "1";
            var actual = reverseString.ReverseStringSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseStringTestMethod4()
        {
            var input = "A man, a plan, a canal: Panama";
            var expected = "amanaP :lanac a ,nalp a ,nam A";
            var actual = reverseString.ReverseStringSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
