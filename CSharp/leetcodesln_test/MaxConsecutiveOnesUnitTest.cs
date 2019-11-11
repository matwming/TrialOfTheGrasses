using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaxConsecutiveOnesUnitTest
    {
        public MaxConsecutiveOnes MaxConsecutiveOnes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MaxConsecutiveOnes = new MaxConsecutiveOnes();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 1, 0, 1, 1, 1 };
            var expected = 3;
            var actual = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
