using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ReverseOnlyLettersUnitTest
    {
        [TestMethod]
        public void ReverseOnlyLettersTestMethod()
        {
            var reverseOnlyLetters = new ReverseOnlyLetters();
            var input1 = "ab-cd";
            var expected1 = "dc-ba";
            var actual1 = reverseOnlyLetters.ReverseOnlyLettersSln(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = "a";
            var expected2 = "a";
            var actual2 = reverseOnlyLetters.ReverseOnlyLettersSln(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = "-";
            var expected3 = "-";
            var actual3 = reverseOnlyLetters.ReverseOnlyLettersSln(input3);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
