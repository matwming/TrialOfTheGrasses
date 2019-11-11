using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class PathInZigzagLabelledBinaryTreeUnitTest
    {
        public PathInZigzagLabelledBinaryTree PathInZigzagLabelledBinaryTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PathInZigzagLabelledBinaryTree = new PathInZigzagLabelledBinaryTree();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var label = 14;
            var expected = new List<int>() { 1, 3, 4, 14 };
            var actual = PathInZigzagLabelledBinaryTree.PathInZigZagTree(label);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
