using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class SameTreeUnitTest
    {
        [TestMethod]
        public void SameTreeTestMethod()
        {
            SameTree sameTree = new SameTree();
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
         

            TreeNode root1 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };

            Assert.AreEqual(true, sameTree.IsSameTree(root, root1));
            
        }

    }
}
