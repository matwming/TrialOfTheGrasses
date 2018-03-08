using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MergeTwoBinaryTreeUnitTest
    {
        [TestMethod]
        public void MergesTreesMethodTest()
        {
            MergeTwoBinaryTrees mergeTwoBinaryTrees = new MergeTwoBinaryTrees();
            TreeNode t1 = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(5),
                    right = null
                },
                right = new TreeNode(2)
                {
                    left = null,
                    right = null
                },
            };
            TreeNode t2 = new TreeNode(2)
            {
                left = new TreeNode(1)
                {
                    left = null,
                    right = new TreeNode(4)
                    {
                        left = null,
                        right = null
                    }
                },
                right = new TreeNode(3)
                {
                    left = null,
                    right = new TreeNode(7)
                    {
                        left = null,
                        right = null
                    }
                }
            };
            TreeNode mergedTree = new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(5)
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
                right = new TreeNode(5)
                {
                    left = null,
                    right = new TreeNode(7)
                    {
                        left = null,
                        right = null
                    }
                }
            };        
        }
    }
}
