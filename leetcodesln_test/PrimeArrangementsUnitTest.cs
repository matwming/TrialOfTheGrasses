using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PrimeArrangementsUnitTest
    {
        public PrimeArrangements PrimeArrangements { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PrimeArrangements = new PrimeArrangements();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var n = 5;
            var expected = 12;
            var actual = PrimeArrangements.NumPrimeArrangements(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var n = 100;
            int expected = checked(682289015);
            var actual = PrimeArrangements.NumPrimeArrangements(n);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var n = 2;
            int expected = 1;
            var actual = PrimeArrangements.NumPrimeArrangements(n);
            Assert.AreEqual(expected, actual);
        }

    }
}
