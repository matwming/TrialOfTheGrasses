using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FindWordsThatCanBeFormedByCharactersUnitTest
    {
        public FindWordsThatCanBeFormedByCharacters FindWordsThatCanBeFormedByCharacters { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindWordsThatCanBeFormedByCharacters = new FindWordsThatCanBeFormedByCharacters();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var words = new[] { "cat", "bt", "hat", "tree" };
            var chars = "atach";
            var expected = 6;
            var actual = FindWordsThatCanBeFormedByCharacters.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var words = new[] { "hello", "world", "leetcode" };
            var chars = "welldonehoneyr";
            var expected = 10;
            var actual = FindWordsThatCanBeFormedByCharacters.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }
    }
}
