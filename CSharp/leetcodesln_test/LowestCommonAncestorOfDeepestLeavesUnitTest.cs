using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LowestCommonAncestorOfDeepestLeavesUnitTest
    {
        public LowestCommonAncestorOfDeepestLeaves LowestCommonAncestorOfDeepestLeaves { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LowestCommonAncestorOfDeepestLeaves = new LowestCommonAncestorOfDeepestLeaves();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };

            var expected = LowestCommonAncestorOfDeepestLeaves.LcaDeepestLeaves(root);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };

            var expected = LowestCommonAncestorOfDeepestLeaves.LcaDeepestLeaves(root);
        }
    }
}
