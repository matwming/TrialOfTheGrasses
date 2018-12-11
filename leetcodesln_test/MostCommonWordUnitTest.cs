using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MostCommonWordUnitTest
    {
        public MostCommonWord mostCommonWord { get; set; }
        [TestInitialize]
        public void BeforeEach()
        {
            mostCommonWord = new MostCommonWord();
        }

        [TestMethod]
        public void MostCommonWordTestMethod1()
        {
            var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = { "hit" };
            var expected = "ball";
            var actual = mostCommonWord.MostCommonWordSln(paragraph, banned);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MostCommonWordTestMethod2()
        {
            var paragraph = "a, a, a, a, b,b,b,c, c";
            string[] banned = { "a" };
            var expected = "b";
            var actual = mostCommonWord.MostCommonWordSln(paragraph, banned);
            Assert.AreEqual(expected, actual);
        }
    }
}
