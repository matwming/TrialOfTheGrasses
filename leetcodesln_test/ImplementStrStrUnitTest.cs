using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ImplementStrStrUnitTest
    {
        public ImplementStrStr implementStrStr { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            implementStrStr = new ImplementStrStr();
        }

        [TestMethod]
        public void ImplementStrStrTestMethod1()
        {
            var haystack = "hello";
            var needle = "ll";
            var expected = 2;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ImplementStrStrTestMethod2()
        {
            var haystack = "aaaaa";
            var needle = "bba";
            var expected = -1;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ImplementStrStrTestMethod3()
        {
            var haystack = "a";
            var needle = "";
            var expected = 0;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ImplementStrStrTestMethod4()
        {
            var haystack = "";
            var needle = "";
            var expected = 0;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ImplementStrStrTestMethod5()
        {
            var haystack = "mississippi";
            var needle = "issip";
            var expected = 4;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ImplementStrStrTestMethod6()
        {
            var haystack = "mississippi";
            var needle = "issipi";
            var expected = -1;
            var actual = implementStrStr.StrStr(haystack, needle);
            Assert.AreEqual(expected,actual);
        }
    }
}