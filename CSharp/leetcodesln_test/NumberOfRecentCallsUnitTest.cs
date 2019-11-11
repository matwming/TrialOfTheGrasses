using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class NumberOfRecentCallsUnitTest
    {
        public NumberOfRecentCalls NumberOfRecentCalls { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            NumberOfRecentCalls = new NumberOfRecentCalls();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            Assert.AreEqual(1, NumberOfRecentCalls.Ping(1));
            Assert.AreEqual(2, NumberOfRecentCalls.Ping(100));
            Assert.AreEqual(3, NumberOfRecentCalls.Ping(3001));
            Assert.AreEqual(3, NumberOfRecentCalls.Ping(3002));
        }

    }
}
