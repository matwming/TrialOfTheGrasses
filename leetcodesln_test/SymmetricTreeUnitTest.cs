using leetcodesln;
using leetcodesln.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SymmetricTreeUnitTest
    {
        public SymmetricTree SymmetricTree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SymmetricTree = new SymmetricTree();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var node3l = new TreeNode(3);
            var node3r = new TreeNode(3);
            var node2l = new TreeNode(2)
            {
                right = node3l
            };
            var node2r = new TreeNode(2)
            {
                right = node3r
            };
            var root = new TreeNode(1)
            {
                left = node2l,
                right = node2r
            };
            var expected = false;
            var actual = SymmetricTree.IsSymmetric(root);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            TreeNode root = null;
            Assert.IsTrue(SymmetricTree.IsSymmetric(root));
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var node3l = new TreeNode(3);
            var node4l = new TreeNode(4);
            var node4r = new TreeNode(4);
            var node3r = new TreeNode(3);
            var node2l = new TreeNode(2)
            {
                left = node3l,
                right = node4l
            };
            var node2r = new TreeNode(2)
            {
                left = node4r,
                right = node3r
            };
            var root = new TreeNode(1)
            {
                left = node2l,
                right = node2r
            };
            var expected = true;
            var actual = SymmetricTree.IsSymmetric(root);
            Assert.AreEqual(expected, actual);
        }
    }
}
