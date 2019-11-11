using leetcodesln;
using leetcodesln.common;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BinaryTreeLevelOrderTraversalUnitTest
    {
        public BinaryTreeLevelOrderTraversal BinaryTreeLevelOrderTraversal { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BinaryTreeLevelOrderTraversal = new BinaryTreeLevelOrderTraversal();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node15 = new TreeNode(15);
            var node7 = new TreeNode(7);
            var node20 = new TreeNode(20)
            {
                left = node15,
                right = node7
            };
            var node9 = new TreeNode(9);
            var root = new TreeNode(3)
            {
                left = node9,
                right = node20
            };
            var expected = new int[3][];
            expected[0] = new int[] { 3 };
            expected[1] = new int[] { 9, 20 };
            expected[2] = new int[] { 15, 7 };
            var actual = BinaryTreeLevelOrderTraversal.LevelOrder(root);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], actual[i]));
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            TreeNode root = null;
            var expected = new List<IList<int>>();
            var actual = BinaryTreeLevelOrderTraversal.LevelOrder(root);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], actual[i]));
            }
        }

    }
}
