using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidAnagramUnitTest
    {
        public ValidAnagram ValidAnagram { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidAnagram = new ValidAnagram();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "anagram";
            var t = "nagaram";
            Assert.IsTrue(ValidAnagram.IsAnagram(s, t));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "cat";
            var t = "rat";
            Assert.IsFalse(ValidAnagram.IsAnagram(s, t));
        }
    }
}