using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumDistanceBetweenBSTNodesUnitTest
    {
        public MinimumDistanceBetweenBSTNodes MinimumDistanceBetweenBSTNodes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumDistanceBetweenBSTNodes = new MinimumDistanceBetweenBSTNodes();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var root = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(6)
            };

            var expected = 1;
            var actual = MinimumDistanceBetweenBSTNodes.MinDiffInBST(root);
            Assert.AreEqual(expected, actual);
        }

    }
}
