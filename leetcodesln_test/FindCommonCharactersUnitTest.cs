using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcodesln_test
{
    [TestClass]
    public class FindCommonCharactersUnitTest
    {
        public FindCommonCharacters FindCommonCharacters { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindCommonCharacters = new FindCommonCharacters();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new string[] { "bella", "label", "roller" };
            var expected = new string[] { "e", "l", "l" };
            var actual = FindCommonCharacters.CommonChars(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new string[] { "cool", "lock", "cook" };
            var expected = new string[] { "c", "o" };
            var actual = FindCommonCharacters.CommonChars(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));

        }
    }
}
