using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BinaryPrefixDivisibleBy5UnitTest
    {
        public BinaryPrefixDivisibleBy5 BinaryPrefixDivisibleBy5 { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BinaryPrefixDivisibleBy5 = new BinaryPrefixDivisibleBy5();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 0, 1, 1 };
            var expected = new bool[] { true, false, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 1, 1 };
            var expected = new bool[] { false, false, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 0, 1, 1, 1, 1, 1 };
            var expected = new bool[] { true, false, false, false, true, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 1, 1, 1, 0, 1 };
            var expected = new bool[] { false, false, false, false, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 };
            var expected = new bool[] { false, false, false, false, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var input = new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 };
            var expected = new bool[] { false, false, false, false, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        //[TestMethod, Timeout(20_000)]
        //public void TestMethod7()
        //{
        //    var input = new int[] { 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0 };
        //    var expected = new bool[] { false, false, false, false, false };
        //    var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
        //    for (int i = 0; i < expected.Length; i++)
        //    {
        //        Assert.AreEqual(expected[i], actual[i]);
        //    }
        //}


        [TestMethod, Timeout(20_000)]
        public void TestMethod8()
        {
            var input = new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 };
            var expected = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false };
            var actual = BinaryPrefixDivisibleBy5.PrefixesDivBy5(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
