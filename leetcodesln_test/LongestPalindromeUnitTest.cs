using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LongestPalindromeUnitTest
    {
        [TestMethod]
        public void LongestPalindromeTestMethod()
        {
            LongestPalindrome lp = new LongestPalindrome();
            int expected = 7;
            int actual = lp.FindLongestPalindrome("abccccdd");
            Assert.AreEqual(expected, actual);

            //case 2
            int expected2 = 3;
            int acutal = lp.FindLongestPalindrome("ccc");
            Assert.AreEqual(expected2, actual);
        }
    }
}
