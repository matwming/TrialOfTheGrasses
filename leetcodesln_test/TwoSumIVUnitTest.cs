using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class TwoSumIVUnitTest
    {
        [TestMethod]
        public void FindTargetTestMethod()
        {
            leetcodesln.TwoSumIV tsiv = new leetcodesln.TwoSumIV();

            TreeNode tree1 = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = null,
                        right = null
                    },
                    right = new TreeNode(4)
                    {
                        left = null,
                        right = null
                    }

                },
                right = new TreeNode(6)
                {
                    left = null,
                    right = new TreeNode(7)
                    {
                        left = null,
                        right = null
                    }

                }
            };

            TreeNode tree3 = new TreeNode(2)
            {
                left = new TreeNode(1)
                {
                    left = null,
                    right = null
                },
                right = new TreeNode(3)
                {
                    left = null,
                    right = null
                }
            };

            Assert.AreEqual(true, tsiv.FindTarget(tree1, 9));
            Assert.AreEqual(false, tsiv.FindTarget(tree1, 28));
            Assert.AreEqual(false, tsiv.FindTarget(tree3, 1));
        }
    }
}
