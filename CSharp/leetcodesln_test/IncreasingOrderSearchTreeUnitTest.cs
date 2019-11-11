using leetcodesln;
using leetcodesln.common;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class IncreasingOrderSearchTreeUnitTest
    {
        public IncreasingOrderSearchTree IncreasingOrderSearchTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            IncreasingOrderSearchTree = new IncreasingOrderSearchTree();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            TreeNode root = null;
            var actual = IncreasingOrderSearchTree.IncreasingBST(root);
            Assert.IsNull(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var node1 = new TreeNode(1);
            var node7 = new TreeNode(7);
            var node9 = new TreeNode(9);
            var node8 = new TreeNode(8)
            {
                left = node7,
                right = node9
            };
            var node2 = new TreeNode(2)
            {
                left = node1
            };
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6)
            {
                right = node8
            };
            var node3 = new TreeNode(3)
            {
                left = node2,
                right = node4
            };
            var root = new TreeNode(5)
            {
                left = node3,
                right = node6
            };
            var expected = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    right = new TreeNode(3)
                    {
                        right = new TreeNode(4)
                        {
                            right = new TreeNode(5)
                            {
                                right = new TreeNode(6)
                                {
                                    right = new TreeNode(7)
                                    {
                                        right = new TreeNode(8)
                                        {
                                            right = new TreeNode(9)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            var actual = IncreasingOrderSearchTree.IncreasingBST(root);
            Assert.IsTrue(Helper<int>.HaveSameInorderSequenceForTwoTreeNodes(expected, actual));
        }

    }
}
