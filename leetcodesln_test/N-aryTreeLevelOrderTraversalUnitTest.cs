using leetcodesln;
using leetcodesln.common;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class N_aryTreeLevelOrderTraversalUnitTest
    {
        public N_aryTreeLevelOrderTraversal N_aryTreeLevelOrderTraversal { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            N_aryTreeLevelOrderTraversal = new N_aryTreeLevelOrderTraversal();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node5 = new Node
            {
                val = 5
            };
            var node6 = new Node
            {
                val = 6
            };
            var node3 = new Node
            {
                val = 3,
                children = new List<Node> { node5, node6 }
            };
            var node2 = new Node
            {
                val = 2
            };
            var node4 = new Node
            {
                val = 4
            };
            var root = new Node
            {
                val = 1,
                children = new List<Node> { node3, node2, node4 }
            };

            var expected = new List<IList<int>>();
            expected.Add(new int[] { 1 });
            expected.Add(new int[] { 3, 2, 4 });
            expected.Add(new int[] { 5, 6 });
            var actual = N_aryTreeLevelOrderTraversal.LevelOrder(root);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], actual[i]));
            }
        }

        [TestMethod, Timeout(20_000)]  // null condition
        public void TestMethod2()
        {
            Node root = null;
            var expected = new List<IList<int>>();
            var actual = N_aryTreeLevelOrderTraversal.LevelOrder(root);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], actual[i]));
            }

        }

    }
}
