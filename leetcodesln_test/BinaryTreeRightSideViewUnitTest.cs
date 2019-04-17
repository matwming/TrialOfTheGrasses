using leetcodesln;
using leetcodesln.common;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BinaryTreeRightSideViewUnitTest
    {
        public BinaryTreeRightSideView BinaryTreeRightSideView { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BinaryTreeRightSideView = new BinaryTreeRightSideView();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node5 = new TreeNode(5);
            var node4 = new TreeNode(4);
            var node2 = new TreeNode(2)
            {
                right = node5
            };
            var node3 = new TreeNode(3)
            {
                right = node4
            };
            var root = new TreeNode(1)
            {
                left = node2,
                right = node3
            };
            var expected = new int[] { 1, 3, 4 };
            var actual = BinaryTreeRightSideView.RightSideView(root);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
