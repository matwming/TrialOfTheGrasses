using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DivisorGameUnitTest
    {
        public DivisorGame DivisorGame { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DivisorGame = new DivisorGame();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 2;
            Assert.IsTrue(DivisorGame.DivisorGameSln(input));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 3;
            Assert.IsFalse(DivisorGame.DivisorGameSln(input));
        }

    }
}
