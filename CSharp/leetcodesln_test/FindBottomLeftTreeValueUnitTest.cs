using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FindBottomLeftTreeValueUnitTest
    {
        public FindBottomLeftTreeValue FindBottomLeftTreeValue { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindBottomLeftTreeValue = new FindBottomLeftTreeValue();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node1 = new TreeNode(1);
            var node3 = new TreeNode(3);
            var root = new TreeNode(2)
            {
                left = node1,
                right = node3
            };
            var expected = 1;
            var actual = FindBottomLeftTreeValue.FindBottomLeftValue(root);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var node3 = new TreeNode(-1);
            var root = new TreeNode(0)
            {
                right = node3
        };
            var expected = -1;
            var actual = FindBottomLeftTreeValue.FindBottomLeftValue(root);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var node7 = new TreeNode(7);
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6);
            var node5 = new TreeNode(5)
            {
                left = node7
            };
            var node3 = new TreeNode(3)
            {
                left = node5,
                right = node6
            };
            var node2 = new TreeNode(2)
            {
                right = node4
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node3
            };
            var expected = 7;
            var actual = FindBottomLeftTreeValue.FindBottomLeftValue(root);
            Assert.AreEqual(expected, actual);
        }

    }
}
