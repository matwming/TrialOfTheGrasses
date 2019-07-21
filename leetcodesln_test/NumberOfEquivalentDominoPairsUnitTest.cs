using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class NumberOfEquivalentDominoPairsUnitTest
    {
        public NumberOfEquivalentDominoPairs NumberOfEquivalentDominoPairs { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            NumberOfEquivalentDominoPairs = new NumberOfEquivalentDominoPairs();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var dominoes = new int[4][];
            dominoes[0] = new[] { 1, 2 };
            dominoes[1] = new[] { 2, 1 };
            dominoes[2] = new[] { 3, 4 };
            dominoes[3] = new[] { 5, 6 };
            var expected = 1;
            var actual = NumberOfEquivalentDominoPairs.NumEquivDominoPairs(dominoes);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var dominoes = new int[4][];
            dominoes[0] = new[] { 1, 2 };
            dominoes[1] = new[] { 2, 1 };
            dominoes[2] = new[] { 1, 2 };
            dominoes[3] = new[] { 1, 2 };
            var expected = 6;
            var actual = NumberOfEquivalentDominoPairs.NumEquivDominoPairs(dominoes);
            Assert.AreEqual(expected, actual);
        }

    }
}
