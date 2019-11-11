using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DayOfTheYearUnitTest
    {
        public DayOfTheYear DayOfTheYear { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DayOfTheYear = new DayOfTheYear();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            string date = "2019-02-10";
            var expected = 41;
            var actual = DayOfTheYear.DayOfYear(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            string date = "2019-03-01";
            var expected = 60;
            var actual = DayOfTheYear.DayOfYear(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            string date = "2016-02-29";
            var expected = 60;
            var actual = DayOfTheYear.DayOfYear(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            string date = "1969-09-28";
            var expected = 271;
            var actual = DayOfTheYear.DayOfYear(date);
            Assert.AreEqual(expected, actual);
        }
    }
}
