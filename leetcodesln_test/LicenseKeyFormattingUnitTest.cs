using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LicenseKeyFormattingUnitTest
    {
        public LicenseKeyFormatting licenseKeyFormatting { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            licenseKeyFormatting = new LicenseKeyFormatting();
        }

        [TestMethod]
        public void LicenseKeyFormattingTestMethod1()
        {
            var S = "5F3Z-2e-9-w";
            var K = 4;
            var expected = "5F3Z-2E9W";
            var actual = licenseKeyFormatting.LicenseKeyFormattingSln(S,K);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LicenseKeyFormattingTestMethod2()
        {
            var S = "2-5g-3-J";
            var K = 2;
            var expected = "2-5G-3J";
            var actual = licenseKeyFormatting.LicenseKeyFormattingSln(S,K);
            Assert.AreEqual(expected, actual);
        }
    }
}