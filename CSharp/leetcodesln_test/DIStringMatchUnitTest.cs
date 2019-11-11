using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DIStringMatchUnitTest
    {
        public DIStringMatch DIStringMatch { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DIStringMatch = new DIStringMatch();
        }

        [TestMethod, Timeout(20_000)]
        public void MestMethod1()
        {
            var input = "IDID";
            var expected = new int[] { 0, 4, 1, 3, 2 };
            var actual = DIStringMatch.DiStringMatch(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void MestMethod2()
        {
            var input = "III";
            var expected = new int[] { 0, 1, 2, 3 };
            var actual = DIStringMatch.DiStringMatch(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void MestMethod3()
        {
            var input = "DDI";
            var expected = new int[] { 3, 2, 0, 1 };
            var actual = DIStringMatch.DiStringMatch(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
