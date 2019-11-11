using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PermutationInStringUnitTest
    {
        public PermutationInString PermutationInString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PermutationInString = new PermutationInString();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s1 = "ab";
            var s2 = "eidbaooo";
            var expected = true;
            var actual = PermutationInString.CheckInclusion(s1, s2);
            Assert.AreEqual(expected, actual);
        }

    }
}
