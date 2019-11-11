using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ScoreOfParenthesesUnitTest
    {
        public ScoreOfParentheses ScoreOfParentheses { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ScoreOfParentheses = new ScoreOfParentheses();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "()";
            var expected = 1;
            var actual = ScoreOfParentheses.ScoreOfParenthesesSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}