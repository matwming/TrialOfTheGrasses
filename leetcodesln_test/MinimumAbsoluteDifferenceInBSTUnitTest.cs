using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumAbsoluteDifferenceInBSTUnitTest
    {
        [TestMethod]
        public void MinimumAbsoluteDifferenceInBSTTestMethod()
        {
            MinimumAbsoluteDifferenceInBST minimumAbsoluteDifferenceInBST = new MinimumAbsoluteDifferenceInBST();
            TreeNode treeNode = new TreeNode(1)
            {
                left = null,
                right = new TreeNode(3)
                {
                    left = new TreeNode(2),
                    right = null
                }
            };

            Assert.AreEqual(1, minimumAbsoluteDifferenceInBST.GetMinimumDifference(treeNode));
        }
    }
}
