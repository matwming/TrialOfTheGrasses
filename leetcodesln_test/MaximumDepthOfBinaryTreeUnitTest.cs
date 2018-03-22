using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximumDepthOfBinaryTreeUnitTest
    {
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestMethod()
        {
            MaximumDepthOfBinaryTree mdobt = new MaximumDepthOfBinaryTree();

            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                    left = null,
                    right = null
                },
                right = new TreeNode(20)
                {
                    left = new TreeNode(15)
                    {
                        left = null,
                        right = null
                    },
                    right = new TreeNode(7)
                    {
                        left = null,
                        right = null
                    }
                }
            };

            Assert.AreEqual(3, mdobt.MaxDepth(node));

            TreeNode node2 = new TreeNode(1)
            {
                left = null,
                right = new TreeNode(2)
                {
                    left = null,
                    right = null
                }
            };

            Assert.AreEqual(2, mdobt.MaxDepth(node2));
        }
    }
}
