using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class GroupOfSpecial_EquivalentStringsUnitTest
    {
        public GroupOfSpecial_EquivalentStrings GroupOfSpecial_EquivalentStrings { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            GroupOfSpecial_EquivalentStrings = new GroupOfSpecial_EquivalentStrings();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new string[] { "a", "b", "c", "a", "c", "c" };
            var expected = 3;
            var actual = GroupOfSpecial_EquivalentStrings.NumSpecialEquivGroups(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new string[] { "aa", "bb", "ab", "ba" };
            var expected = 4;
            var actual = GroupOfSpecial_EquivalentStrings.NumSpecialEquivGroups(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new string[] { "abc", "acb", "bac", "bca", "cab", "cba" };
            var expected = 3;
            var actual = GroupOfSpecial_EquivalentStrings.NumSpecialEquivGroups(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new string[] { "abcd", "cdab", "adcb", "cbad" };
            var expected = 1;
            var actual = GroupOfSpecial_EquivalentStrings.NumSpecialEquivGroups(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
