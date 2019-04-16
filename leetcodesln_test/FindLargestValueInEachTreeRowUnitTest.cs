using leetcodesln;
using leetcodesln.common;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FindLargestValueInEachTreeRowUnitTest
    {
        public FindLargestValueInEachTreeRow FindLargestValueInEachTreeRow { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindLargestValueInEachTreeRow = new FindLargestValueInEachTreeRow();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node5 = new TreeNode(5);
            var node3b = new TreeNode(3);
            var node9 = new TreeNode(9);
            var node3a = new TreeNode(3)
            {
                left = node5,
                right = node3b
            };
            var node2 = new TreeNode(2)
            {
                right = node9
            };
            var root = new TreeNode(1)
            {
                left = node3a,
                right = node2
            };
            var expected = new int[] { 1, 3, 9 };
            var actual = FindLargestValueInEachTreeRow.LargestValues(root);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            TreeNode root = null;
            var expected = new int[] { };
            var actual = FindLargestValueInEachTreeRow.LargestValues(root);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
