using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SortCharactersByFrequencyUnitTest
    {
        public SortCharactersByFrequency SortCharactersByFrequency { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SortCharactersByFrequency = new SortCharactersByFrequency();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "tree";
            var expected = "eetr";
            var actual = SortCharactersByFrequency.FrequencySort(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
