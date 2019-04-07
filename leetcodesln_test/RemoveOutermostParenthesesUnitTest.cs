using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveOutermostParenthesesUnitTest
    {
        public RemoveOutermostParentheses RemoveOutermostParentheses { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RemoveOutermostParentheses = new RemoveOutermostParentheses();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "(()())(())";
            var expected = "()()()";
            var actual = RemoveOutermostParentheses.RemoveOutermostParenthesesSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "(()())(())(()(()))";
            var expected = "()()()()(())";
            var actual = RemoveOutermostParentheses.RemoveOutermostParenthesesSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "()()";
            var expected = "";
            var actual = RemoveOutermostParentheses.RemoveOutermostParenthesesSln(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
