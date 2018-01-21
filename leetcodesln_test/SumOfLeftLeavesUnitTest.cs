using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SumOfLeftLeavesUnitTest
    {
        [TestMethod]
        public void SumOfLeftLeavesTestMethod()
        {
            SumOfLeftLeaves sumOfLeftLeaves = new SumOfLeftLeaves();
            TreeNode node1 = new TreeNode(3);
            TreeNode node2 = new TreeNode(9);
            TreeNode node3 = new TreeNode(20);
            TreeNode node4 = new TreeNode(15);
            TreeNode node5 = new TreeNode(7);
            node1.left = node2;
            node1.right = node3;
            node2.left = null;
            node2.right = null;
            node3.left = node4;
            node3.right = node5;
            node4.left = null;
            node4.right = null;
            node5.left = null;
            node5.right = null;
            Assert.AreEqual(24, sumOfLeftLeaves.SumOfLeftLeavesSln(node1));
        }
    }
}
