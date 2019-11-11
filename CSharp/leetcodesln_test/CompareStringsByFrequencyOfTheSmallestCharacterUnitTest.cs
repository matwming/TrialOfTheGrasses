using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class CompareStringsByFrequencyOfTheSmallestCharacterUnitTest
    {
        public CompareStringsByFrequencyOfTheSmallestCharacter CompareStringsByFrequencyOfTheSmallestCharacter { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CompareStringsByFrequencyOfTheSmallestCharacter = new CompareStringsByFrequencyOfTheSmallestCharacter();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var queries = new[] { "cbd" };
            var words = new[] { "zaaaz" };
            var expected = new[] { 1 };
            var actual = CompareStringsByFrequencyOfTheSmallestCharacter.NumSmallerByFrequency(queries, words);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var queries = new[] { "bbb", "cc" };
            var words = new[] { "a", "aa", "aaa", "aaaa" };
            var expected = new[] { 1 };
            var actual = CompareStringsByFrequencyOfTheSmallestCharacter.NumSmallerByFrequency(queries, words);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
