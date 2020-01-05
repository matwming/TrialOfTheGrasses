using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DecryptStringFromAlphabetToIntegerMappingUnitTest
    {
        public DecryptStringFromAlphabetToIntegerMapping DecryptStringFromAlphabetToIntegerMapping { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DecryptStringFromAlphabetToIntegerMapping = new DecryptStringFromAlphabetToIntegerMapping();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "10#11#12";
            var expected = "jkab";
            var actual = DecryptStringFromAlphabetToIntegerMapping.FreqAlphabets(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "1326#";
            var expected = "acz";
            var actual = DecryptStringFromAlphabetToIntegerMapping.FreqAlphabets(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var s = "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#";
            var expected = "abcdefghijklmnopqrstuvwxyz";
            var actual = DecryptStringFromAlphabetToIntegerMapping.FreqAlphabets(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
