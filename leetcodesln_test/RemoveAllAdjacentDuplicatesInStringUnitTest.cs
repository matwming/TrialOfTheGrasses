using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveAllAdjacentDuplicatesInStringUnitTest
    {
        public RemoveAllAdjacentDuplicatesInString RemoveAllAdjacentDuplicatesInString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RemoveAllAdjacentDuplicatesInString = new RemoveAllAdjacentDuplicatesInString();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "abbaca";
            var expected = "ca";
            var actual = RemoveAllAdjacentDuplicatesInString.RemoveDuplicates(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "aaaa";
            var expected = "";
            var actual = RemoveAllAdjacentDuplicatesInString.RemoveDuplicates(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
