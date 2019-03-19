using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidParenthesesUnitTest
    {
        public ValidParentheses ValidParentheses { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidParentheses = new ValidParentheses();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "()";
            var expected = true;
            var actual = ValidParentheses.IsValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "()[]{}";
            var expected = true;
            var actual = ValidParentheses.IsValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "(]";
            var expected = false;
            var actual = ValidParentheses.IsValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = "([)]";
            var expected = false;
            var actual = ValidParentheses.IsValid(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = "{[]}";
            var expected = true;
            var actual = ValidParentheses.IsValid(input);
            Assert.AreEqual(expected, actual);
        }
    }
}