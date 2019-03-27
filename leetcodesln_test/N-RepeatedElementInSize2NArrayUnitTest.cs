using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class N_RepeatedElementInSize2NArrayUnitTest
    {
        public N_RepeatedElementInSize2NArray N_RepeatedElementInSize2NArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            N_RepeatedElementInSize2NArray = new N_RepeatedElementInSize2NArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3, 3 };
            var expected = 3;
            var actual = N_RepeatedElementInSize2NArray.RepeatedNTimes(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 2, 1, 2, 5, 3, 2 };
            var expected = 2;
            var actual = N_RepeatedElementInSize2NArray.RepeatedNTimes(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 5, 1, 5, 2, 5, 3, 5, 4 };
            var expected = 5;
            var actual = N_RepeatedElementInSize2NArray.RepeatedNTimes(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
