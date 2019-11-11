using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MinimumDpethOfBinaryTreeUnitTest
    {
        public MinimumDepthOfBinaryTree MinimumDepthOfBinaryTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumDepthOfBinaryTree = new MinimumDepthOfBinaryTree();
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
            var expected = 2;
            var actual = MinimumDepthOfBinaryTree.MinDepth(root);
            Assert.AreEqual(expected, actual);
        }

    }
}
