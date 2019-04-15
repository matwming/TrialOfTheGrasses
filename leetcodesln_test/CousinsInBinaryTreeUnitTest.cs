using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class CousinsInBinaryTreeUnitTest
    {
        public CousinsInBinaryTree CousinsInBinaryTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CousinsInBinaryTree = new CousinsInBinaryTree();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node4 = new TreeNode(4);
            var node3 = new TreeNode(3);
            var node2 = new TreeNode(2)
            {
                left = node4
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node3
            };
            var expected = false;
            var actual = CousinsInBinaryTree.IsCousins(root, 4, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);
            var node2 = new TreeNode(2)
            {
                right = node4
            };
            var node3 = new TreeNode(3)
            {
                right = node5
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node3
            };
            var expected = true;
            var actual = CousinsInBinaryTree.IsCousins(root, 5, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var node4 = new TreeNode(4);
            var node3 = new TreeNode(3);
            var node2 = new TreeNode(2)
            {
                right = node4
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node3
            };
            var expected = false;
            var actual = CousinsInBinaryTree.IsCousins(root, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6);
            var node3 = new TreeNode(3)
            {
                left = node4
            };
            var node5 = new TreeNode(5)
            {
                right = node6
            };
            var node2 = new TreeNode(2)
            {
                left = node3
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node5
            };
            var expected = true;
            var actual = CousinsInBinaryTree.IsCousins(root, 3,6);
            Assert.AreEqual(expected, actual);
        }

    }
}
