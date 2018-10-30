using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class InvertABinaryTreeUnitTest
    {
        //todo: test case for verify two binary tree are the same
        [TestMethod]
        public void InvertABinaryTreeTestMethod()
        {
            InvertABinaryTree invertABinaryTree = new InvertABinaryTree();
            var input = new TreeNode(4)
            {
                left = new TreeNode(2)
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
                },
                right = new TreeNode(7)
                {
                    left = new TreeNode(6)
                    {
                        left = null,
                        right = null
                    },
                    right = new TreeNode(9)
                    {
                        left = null,
                        right = null
                    }
                }
            };

            var expected = new TreeNode(4)
            {
                left = new TreeNode(7)
                {
                    left = new TreeNode(9)
                    {
                        left = null,
                        right = null
                    },
                    right = new TreeNode(6)
                    {
                        left = null,
                        right = null
                    }
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        left = null,
                        right = null
                    },
                    right = new TreeNode(1)
                    {
                        left = null,
                        right = null
                    }
                }
            };

        }
    }
}
