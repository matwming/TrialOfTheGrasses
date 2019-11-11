using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MagicalStringUnitTest
    {
        public MagicalString MagicalString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MagicalString = new MagicalString();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var n = 4;
            var expected = 2;
            var actual = MagicalString.MagicalStringSln(n);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var n = 5;
            var expected = 3;
            var actual = MagicalString.MagicalStringSln(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var n = 6;
            var expected = 3;
            var actual = MagicalString.MagicalStringSln(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
