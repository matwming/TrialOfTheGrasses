using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class SearchInsertPositionUnitTest
    {
        public SearchInsertPosition searchInsertPosition { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            searchInsertPosition = new SearchInsertPosition();
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod1()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var target = 5;
            var expected = 2;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod2()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var target = 2;
            var expected = 1;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod3()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var target = 7;
            var expected = 4;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod4()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var target = 0;
            var expected = 0;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod5()
        {
            var input = new int[] { 1, 3 };
            var target = 2;
            var expected = 1;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SearchInsertPositionTestMethod6()
        {
            var input = new int[] { 1, 3,5 };
            var target = 4;
            var expected = 2;
            var actual = searchInsertPosition.SearchInsert(input, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
