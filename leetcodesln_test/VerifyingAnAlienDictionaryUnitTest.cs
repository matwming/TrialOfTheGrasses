using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class VerifyingAnAlienDictionaryUnitTest
    {
        public VerifyingAnAlienDictionary VerifyingAnAlienDictionary { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            VerifyingAnAlienDictionary = new VerifyingAnAlienDictionary();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var words = new string[] { "hello", "leetcode" };
            var order = "hlabcdefgijkmnopqrstuvwxyz";
            var actual = VerifyingAnAlienDictionary.IsAlienSorted(words, order);
            Assert.IsTrue(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var words = new string[] { "word", "world", "row" };
            var order = "worldabcefghijkmnpqstuvxyz";
            var actual = VerifyingAnAlienDictionary.IsAlienSorted(words, order);
            Assert.IsFalse(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var words = new string[] { "apple", "app" };
            var order = "abcdefghijklmnopqrstuvwxyz";
            var actual = VerifyingAnAlienDictionary.IsAlienSorted(words, order);
            Assert.IsFalse(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var words = new string[] { "l", "h" };
            var order = "xkbwnqozvterhpjifgualycmds";
            var actual = VerifyingAnAlienDictionary.IsAlienSorted(words, order);
            Assert.IsFalse(actual);
        }
    }
}