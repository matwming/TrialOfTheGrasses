using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RepeatedStringMatchUnitTest
    {
        public RepeatedStringMatch RepeatedStringMatch { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RepeatedStringMatch = new RepeatedStringMatch();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = "abcd";
            var B = "cdabcdab";
            var expected = 3;
            var actual = RepeatedStringMatch.RepeatedStringMatchSln(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}