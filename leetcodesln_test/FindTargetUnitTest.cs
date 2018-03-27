using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FindTargetUnitTest
    {
        [TestMethod]
        public void FindTargetTestMethod()
        {
            TwoSumIV tsiv = new TwoSumIV();

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

            Assert.AreEqual(true, tsiv.FindTarget(tree1, 9));
            Assert.AreEqual(false, tsiv.FindTarget(tree1, 28));
        }
    }
}
