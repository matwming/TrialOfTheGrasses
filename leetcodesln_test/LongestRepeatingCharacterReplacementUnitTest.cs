using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LongestRepeatingCharacterReplacementUnitTest
    {
        public LongestRepeatingCharacterReplacement LongestRepeatingCharacterReplacement { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LongestRepeatingCharacterReplacement = new LongestRepeatingCharacterReplacement();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "ABAB";
            var k = 2;
            var expected = 4;
            var actual = LongestRepeatingCharacterReplacement.CharacterReplacement(s, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "AABABBA";
            var k = 1;
            var expected = 4;
            var actual = LongestRepeatingCharacterReplacement.CharacterReplacement(s, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var s = "ABBB";
            var k = 0;
            var expected = 3;
            var actual = LongestRepeatingCharacterReplacement.CharacterReplacement(s, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
