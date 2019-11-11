using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumAddToMakeParenthesesValidUnitTest
    {
        public MinimumAddToMakeParenthesesValid MinimumAddToMakeParenthesesValid { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumAddToMakeParenthesesValid = new MinimumAddToMakeParenthesesValid();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "())";
            var expected = 1;
            var actual = MinimumAddToMakeParenthesesValid.MinAddToMakeValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "(((";
            var expected = 3;
            var actual = MinimumAddToMakeParenthesesValid.MinAddToMakeValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "()";
            var expected = 0;
            var actual = MinimumAddToMakeParenthesesValid.MinAddToMakeValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = "()))((";
            var expected = 4;
            var actual = MinimumAddToMakeParenthesesValid.MinAddToMakeValid(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
