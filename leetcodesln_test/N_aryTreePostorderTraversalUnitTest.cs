using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class N_aryTreePostorderTraversalUnitTest
    {
        [TestMethod]
        public void N_aryTreePostorderTraversalTestMethod()
        {
            N_aryTreePostorderTraversal ntpt = new N_aryTreePostorderTraversal();
            var node5 = new Node
            {
                val = 5,
                children = null
            };
            var node6 = new Node
            {
                val = 6,
                children = null
            };

            var node3 = new Node
            {
                val = 3,
                children = new List<Node>
                { node5, node6}
            };
            var node2 = new Node
            {
                val = 2,
                children = null
            };
            var node4 = new Node
            {
                val = 4,
                children = null
            };
            var root = new Node
            {
                val = 1,
                children = new List<Node>
                {
                    node3, node2,node4
                }
            };
            var expected = new List<int>{ 5,6,3,2,4,1};
            var actual = ntpt.Postorder(root);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
