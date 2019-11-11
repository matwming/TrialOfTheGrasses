using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class PreviousPermutationWithOneSwapUnitTest
    {
        public PreviousPermutationWithOneSwap PreviousPermutationWithOneSwap { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PreviousPermutationWithOneSwap = new PreviousPermutationWithOneSwap();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 3, 2, 1 };
            var expected = new int[] { 3, 1, 2 };
            var actual = PreviousPermutationWithOneSwap.PrevPermOpt1(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1,1,5 };
            var expected = new int[] { 1,1,5 };
            var actual = PreviousPermutationWithOneSwap.PrevPermOpt1(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 1,9,4,6,7 };
            var expected = new int[] { 1,7,4,6,9 };
            var actual = PreviousPermutationWithOneSwap.PrevPermOpt1(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 3,1,1,3 };
            var expected = new int[] { 1,3,1,3 };
            var actual = PreviousPermutationWithOneSwap.PrevPermOpt1(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new int[] { 6, 1, 5, 9, 1, 1, 9, 7, 7, 9, 7, 6, 2, 7, 3, 4, 5, 1, 7, 6, 3, 5, 3, 1, 4, 7, 1, 1, 8, 8, 9, 1, 9, 5, 1, 6, 5, 4, 7, 3, 2, 7, 4, 9, 7, 6, 2, 5, 7, 4, 3, 7, 5, 5, 4, 4, 2, 1, 3, 1, 6, 4, 8, 7, 5, 9, 3, 1, 4, 4, 7, 5, 3, 7, 2, 4, 4, 8, 5, 4, 8, 1, 1, 3, 4, 3, 5, 4, 8, 1, 5, 4, 9, 8, 4, 5, 3, 1, 1, 3 };
            var expected = new int[] {6, 1, 5, 9, 1, 1, 9, 7, 7, 9, 7, 6, 2, 7, 3, 4, 5, 1, 7, 6, 3, 5, 3, 1, 4, 7, 1, 1, 8, 8, 9, 1, 9, 5, 1, 6, 5, 4, 7, 3, 2, 7, 4, 9, 7, 6, 2, 5, 7, 4, 3, 7, 5, 5, 4, 4, 2, 1, 3, 1, 6, 4, 8, 7, 5, 9, 3, 1, 4, 4, 7, 5, 3, 7, 2, 4, 4, 8, 5, 4, 8, 1, 1, 3, 4, 3, 5, 4, 8, 1, 5, 4, 9, 8, 4, 5, 1, 3, 1, 3 };
            var actual = PreviousPermutationWithOneSwap.PrevPermOpt1(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
