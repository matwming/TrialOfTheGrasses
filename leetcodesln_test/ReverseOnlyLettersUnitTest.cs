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
        }
    }
}
