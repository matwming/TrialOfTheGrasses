using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SubstringOfSizeKWithKDistinctCharsUnitTest
    {
        public SubstringOfSizeKWithKDistinctChars SubstringOfSizeKWithKDistinctChars { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SubstringOfSizeKWithKDistinctChars = new SubstringOfSizeKWithKDistinctChars();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var str = "awaglknagawunagwkwagl";
            var k = 4;
            var actual = SubstringOfSizeKWithKDistinctChars.GetSubstrs(str, k);
            var expected = new HashSet<string> { "wagl", "aglk", "glkn", "lkna", "knag", "gawu", "awun", "wuna", "unag", "nagw", "agwk", "kwag" };
            Assert.AreEqual(actual.Count, expected.Count);
            foreach (var stri in expected)
            {
                Assert.IsTrue(actual.Contains(stri));
            }
        }

    }
}
