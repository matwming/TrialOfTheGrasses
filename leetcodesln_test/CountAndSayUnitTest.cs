using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class CountAndSayUnitTest
    {
        public CountAndSay CountAndSay { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CountAndSay = new CountAndSay();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 1;
            var expected = "1";
            var actual = CountAndSay.CountAndSaySln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 4;
            var expected = "1211";
            var actual = CountAndSay.CountAndSaySln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
