using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class SequentialDigitsUnitTest
    {
        public SequentialDigits SequentialDigits { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SequentialDigits = new SequentialDigits();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var low = 100;
            var high = 300;
            var expected = new List<int> { 123, 234 };
            var actual = SequentialDigits.SequentialDigitsSln(low, high);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var low = 1000;
            var high = 13000;
            var expected = new List<int> { 1234, 2345, 3456, 4567, 5678, 6789, 12345 };
            var actual = SequentialDigits.SequentialDigitsSln(low, high);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var low = 58;
            var high = 155;
            var expected = new List<int> { 67, 78, 89, 123 };
            var actual = SequentialDigits.SequentialDigitsSln(low, high);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
