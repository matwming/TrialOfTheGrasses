using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class GreatestCommonDivisorOfStringsUnitTest
    {
        public GreatestCommonDivisorOfStrings GreatestCommonDivisorOfStrings { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            GreatestCommonDivisorOfStrings = new GreatestCommonDivisorOfStrings();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var str1 = "ABCABC";
            var str2 = "ABC";
            var expected = "ABC";
            var actual = GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var str1 = "ABABAB";
            var str2 = "ABAB";
            var expected = "AB";
            var actual = GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);
            Assert.AreEqual(expected, actual);
        }

    }
}
