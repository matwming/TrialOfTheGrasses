using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximumDepthOfN_aryTreeUnitTest
    {
        public MaximumDepthOfN_aryTree MaximumDepthOfN_aryTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MaximumDepthOfN_aryTree = new MaximumDepthOfN_aryTree();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node5 = new Node
            {
                val = 5,
                children = new Node[] { }
            };
            var node6 = new Node
            {
                val = 6,
                children = new Node[] { }
            };
            var node3 = new Node
            {
                val = 3,
                children = new Node[]
               {
                    node5, node6
               }
            };

            var node2 = new Node
            {
                val = 2,
                children = new Node[] { }
            };
            var node4 = new Node
            {
                val = 4,
                children = new Node[] { }
            };

            var root = new Node
            {
                val = 1,
                children = new Node[]
                {
                    node3, node2, node4
                }
            };

            var expected = 3;
            var actual = MaximumDepthOfN_aryTree.MaxDepth(root);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            Node root = null;
            var expected = 0;
            var actual = MaximumDepthOfN_aryTree.MaxDepth(root);
            Assert.AreEqual(expected, actual);
        }

    }
}
