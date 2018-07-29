using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ConstructStringFromBinaryTreeUnitTest
    {
        [TestMethod]
        public void ConstructStringFromBinaryTreeTestMethod()
        {
            ConstructStringFromBinaryTree csfbt = new ConstructStringFromBinaryTree();
            TreeNode input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = null,
                        right = null
                    },
                    right = null
                },
                right = new TreeNode(3)
                {
                    left = null,
                    right = null
                }
            };
            var expected = "1(2(4))(3)";
            Assert.AreEqual(expected, csfbt.Tree2Str(input));
        }
    }
}
