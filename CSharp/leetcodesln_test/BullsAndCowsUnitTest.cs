using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BullsAndCowsUnitTest
    {
        public BullsAndCows BullsAndCows { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BullsAndCows = new BullsAndCows();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var secret = "1807";
            var guess = "7810";
            var expected = "1A3B";
            var actual = BullsAndCows.GetHint(secret, guess);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var secret = "1123";
            var guess = "0111";
            var expected = "1A1B";
            var actual = BullsAndCows.GetHint(secret, guess);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var secret = "1807";
            var guess = "7810";
            var expected = "1A3B";
            var actual = BullsAndCows.GetHintOptimal(secret, guess);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var secret = "1123";
            var guess = "0111";
            var expected = "1A1B";
            var actual = BullsAndCows.GetHintOptimal(secret, guess);
            Assert.AreEqual(expected, actual);
        }
    }
}
