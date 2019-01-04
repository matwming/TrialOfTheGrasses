using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PlusOneUnitTest
    {
        public PlusOne plusOne { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            plusOne = new PlusOne();
        }

        [TestMethod, Timeout(20_000)]
        public void PlusOneTestMethod1()
        {
            var input = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 4 };
            var actual = plusOne.PlusOneSln(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void PlusOneTestMethod2()
        {
            var input = new int[] { 1, 9, 9 };
            var expected = new int[] { 2, 0, 0 };
            var actual = plusOne.PlusOneSln(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
