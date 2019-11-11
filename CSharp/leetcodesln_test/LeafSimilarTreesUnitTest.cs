using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LeafSimilarTreesUnitTest
    {
        public LeafSimilarTrees LeafSimilarTrees { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LeafSimilarTrees = new LeafSimilarTrees();
        }

        [TestMethod, Timeout(5_000)]
        public void TestMethod1()
        {
            var node7 = new TreeNode(7);
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6);
            var node9 = new TreeNode(9);
            var node8 = new TreeNode(8);
            var node1 = new TreeNode(1)
            {
                left = node9,
                right = node8
            };
            var node2 = new TreeNode(2)
            {
                left = node7,
                right = node4
            };
            var node5 = new TreeNode(5)
            {
                left = node6,
                right = node2
            };
            var root1 = new TreeNode(3)
            {
                left = node5,
                right = node1
            };

            var node22 = new TreeNode(2)
            {
                left = node9,
                right = node8
            };
            var node11 = new TreeNode(1)
            {
                left = node4,
                right = node22
            };
            var node55 = new TreeNode(5)
            {
                left = node6,
                right = node7
            };
            var root2 = new TreeNode(3)
            {
                left = node55,
                right = node11
            };
            var expected = true;
            var actual = LeafSimilarTrees.LeafSimilar(root1, root2);
            Assert.AreEqual(expected, actual);
        }
    }
}