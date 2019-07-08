using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DefangingAnIPAddressUnitTest
    {
        public DefangingAnIPAddress DefangingAnIPAddress { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DefangingAnIPAddress = new DefangingAnIPAddress();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var address = "1.1.1.1";
            var expected = "1[.]1[.]1[.]1";
            var actual = DefangingAnIPAddress.DefangIPaddr(address);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var address = "255.100.50.0";
            var expected = "255[.]100[.]50[.]0";
            var actual = DefangingAnIPAddress.DefangIPaddr(address);
            Assert.AreEqual(expected, actual);
        }
    }
}
