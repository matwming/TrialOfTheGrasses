using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class FindAllNumbersDisappearedInAnArrayUnitTest
    {
        public FindAllNumbersDisappearedInAnArray FindAllNumbersDisappearedInAnArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindAllNumbersDisappearedInAnArray = new FindAllNumbersDisappearedInAnArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expected = new List<int> { 5, 6 };
            var actual = FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
