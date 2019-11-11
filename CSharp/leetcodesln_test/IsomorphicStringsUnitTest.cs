using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class IsomorphicStringsUnitTest
    {
        public IsomorphicStrings IsomorphicStrings { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            IsomorphicStrings = new IsomorphicStrings();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "egg";
            var t = "add";
            var expected = true;
            var actual = IsomorphicStrings.IsIsomorphic(s,t);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "foo";
            var t = "bar";
            var expected = false;
            var actual = IsomorphicStrings.IsIsomorphic(s,t);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var s = "paper";
            var t = "title";
            var expected = true;
            var actual = IsomorphicStrings.IsIsomorphic(s,t);
            Assert.AreEqual(expected, actual);
        }
    }
}